using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Test_Project.Models;

namespace Test_Project.Services
{
    public static class MedicationService
    {
        private static List<Medication> _medications = new();
        private static string _filePath = "Data/medications.json";

        static MedicationService()
        {
            LoadMedications();
        }

        public static void AddMedication(Medication med)
        {
            med.Id = _medications.Count + 1;
            _medications.Add(med);
            SaveMedications();
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
            if (File.Exists(_filePath))
                _medications = JsonSerializer.Deserialize<List<Medication>>(File.ReadAllText(_filePath));
        }

        private static void SaveMedications()
        {
            File.WriteAllText(_filePath, JsonSerializer.Serialize(_medications));
        }
    }
}
