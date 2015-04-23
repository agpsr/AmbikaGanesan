using System;

namespace PatientDemo.Domain.Entities
{
	public struct Address
	{
		public string AddressLine1;
		public string AddressLine2;
		public string AddressLine3;
		public string City;
		public string PostCode;
	}
    public class Patient
    {
        public string Surname { get; set; }
        public string Forename { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string gender { get; set; }

		public enum Gender
		{
			Unknown,
			Male,
			Female
		}
		public enum PatientType
		{
			Regular,
			Dummy,
			Emergency
		}

	    public static string GetGender(Gender gender)
	    {
		    switch (gender)
		    {
			    case Gender.Unknown:
				    return "Unknown";
			    case Gender.Male:
				    return "Male";
			    case Gender.Female:
				    return "Female";
				default:
				    return "Invalid";
		    }
		}
    }
}
