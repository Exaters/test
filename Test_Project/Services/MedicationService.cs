using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Test_Project.Models;

namespace Test_Project.Services
{
    public static class MedicationService
    {
        private static List<Medication> _medications = new();
        private static readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "medications.json");
        private static readonly object _fileLock = new object();

        static MedicationService()
        {
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
                    SaveMedications();
                }
            }
        }

        public static void DeleteMedication(int id)
        {
            lock (_fileLock)
            {
                var med = _medications.FirstOrDefault(m => m.Id == id);
                if (med != null)
                {
                    _medications.Remove(med);
                    SaveMedications();
                }
            }
        }

        public static List<Medication> GetMedicationsForDate(int userId, DateTime date)
        {
            return _medications.Where(m =>
                m.UserId == userId &&
                date >= m.StartDate &&
                date <= m.EndDate).ToList();
        }

        public static List<Medication> GetAllMedications(int userId)
        {
            return _medications.Where(m => m.UserId == userId).ToList();
        }

        private static void LoadMedications()
        {
            try
            {
                lock (_fileLock)
                {
                    if (File.Exists(_filePath))
                    {
                        var json = File.ReadAllText(_filePath);
                        _medications = JsonSerializer.Deserialize<List<Medication>>(json) ?? new List<Medication>();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading medications: {ex.Message}");
                _medications = new List<Medication>();
            }
        }

        private static void SaveMedications()
        {
            try
            {
                lock (_fileLock)
                {
                    var directory = Path.GetDirectoryName(_filePath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    var options = new JsonSerializerOptions { WriteIndented = true };
                    File.WriteAllText(_filePath, JsonSerializer.Serialize(_medications, options));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving medications: {ex.Message}");
            }
        }

        public static void Cleanup()
        {
            _medications.Clear();
        }
    }
}
