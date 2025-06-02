using System;
using System.Collections.Generic;

namespace Test_Project.Models
{
    public class Medication
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Dosage { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<TimeSpan> IntakeTimes { get; set; } = new();
        public string ImagePath { get; set; } = string.Empty;
    }
}