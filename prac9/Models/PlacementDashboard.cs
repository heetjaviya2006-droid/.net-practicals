using System.Collections.Generic;

namespace Practical9.Models
{
    public class PlacementDashboard
    {
        public int TotalStudents { get; set; }

        public int PlacedStudents { get; set; }

        public int TotalCompanies { get; set; }

        public decimal PlacementPercentage { get; set; }

        public List<Student> Students { get; set; }
    }
}