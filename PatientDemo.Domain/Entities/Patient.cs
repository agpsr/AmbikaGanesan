using System;

namespace PatientDemo.Domain.Entities
{
    public class Patient
    {
        public string Surname { get; set; }
        public string Forename { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Gender { get; set; }
		public string PatientType { get; set; }
    }
}
