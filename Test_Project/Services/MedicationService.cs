using System.Text.Json;
using Test_Project.Models;

namespace Test_Project.Services
{
    public static class MedicationService
    {
        private static List<Medication> _medications = new();
        private static readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "medications.json");
        private static readonly string _imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "MedicationImages");
        private static readonly object _fileLock = new();

        static MedicationService()
        {
            _ = Directory.CreateDirectory(Path.GetDirectoryName(_filePath)!);
            _ = Directory.CreateDirectory(_imageFolder);
            LoadMedications();
        }

        public static void AddMedication(Medication med)
        {
            lock (_fileLock)
            {
                med.Id = _medications.Count > 0 ? _medications.Max(m => m.Id) + 1 : 1;
                _medications.Add(med);
                SaveMedications();
            }
        }

        public static void UpdateMedication(Medication updatedMed)
        {
            lock (_fileLock)
            {
                var med = _medications.FirstOrDefault(m => m.Id == updatedMed.Id);
                if (med != null)
                {
                    med.Name = updatedMed.Name;
                    med.Dosage = updatedMed.Dosage;
                    med.StartDate = updatedMed.StartDate;
                    med.EndDate = updatedMed.EndDate;
                    med.IntakeTimes = new List<TimeSpan>(updatedMed.IntakeTimes);
                    med.ImagePath = updatedMed.ImagePath;
                    SaveMedications();
                }
            }
        }

        public static void SaveMedication(Medication med)
        {
            if (med.Id == 0)
            {
                AddMedication(med);
            }
            else
            {
                UpdateMedication(med);
            }
        }


        public static void DeleteMedication(int id)
        {
            lock (_fileLock)
            {
                var med = _medications.FirstOrDefault(m => m.Id == id);
                if (med != null)
                {
                    if (!string.IsNullOrEmpty(med.ImagePath) && File.Exists(med.ImagePath))
                    {
                        try { File.Delete(med.ImagePath); } catch (Exception ex) { Console.WriteLine($"Failed to delete image: {ex.Message}"); }
                    }

                    _ = _medications.Remove(med);
                    SaveMedications();
                }
            }
        }

        public static string SaveMedicationImage(string sourcePath, int medicationId)
        {
            if (!File.Exists(sourcePath))
            {
                return string.Empty;
            }

            try
            {
                string extension = Path.GetExtension(sourcePath);
                string fileName = $"med_{medicationId}{extension}";
                string destPath = Path.Combine(_imageFolder, fileName);
                File.Copy(sourcePath, destPath, true);
                return destPath;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error copying image: {ex.Message}");
                return string.Empty;
            }
        }

        public static List<Medication> GetMedicationsForDate(int userId, DateTime date)
        {
            lock (_fileLock)
            {
                return _medications.Where(m =>
                    m.UserId == userId &&
                    date >= m.StartDate &&
                    date <= m.EndDate).ToList();
            }
        }

        public static List<Medication> GetAllMedications(int userId)
        {
            lock (_fileLock)
            {
                return _medications.Where(m => m.UserId == userId).ToList();
            }
        }

        public static void Cleanup()
        {
            lock (_fileLock)
            {
                _medications.Clear();
            }
        }

        private static void LoadMedications()
        {
            lock (_fileLock)
            {
                try
                {
                    if (File.Exists(_filePath))
                    {
                        var json = File.ReadAllText(_filePath);
                        _medications = JsonSerializer.Deserialize<List<Medication>>(json) ?? new List<Medication>();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading medications: {ex.Message}");
                    _medications = new List<Medication>();
                }
            }
        }

        private static void SaveMedications()
        {
            lock (_fileLock)
            {
                try
                {
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    File.WriteAllText(_filePath, JsonSerializer.Serialize(_medications, options));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saving medications: {ex.Message}");
                }
            }
        }
    }
}
