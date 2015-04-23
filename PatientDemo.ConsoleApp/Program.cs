using PatientDemo.Domain.Entities;
using System;

namespace PatientDemo.ConsoleApp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Patient myPatient = new Patient();
			myPatient.Surname = "Smith";
			myPatient.Forename = "John";
			Console.WriteLine("Name: " + myPatient.Forename + " " + myPatient.Surname);
			Console.ReadLine();
			Console.WriteLine("Hello {0} {1} Please enter your Date of Birth in YYYY/MM/DD format:", myPatient.Forename, myPatient.Surname);
			string DOB = Console.ReadLine();
			myPatient.DateOfBirth = Convert.ToDateTime(DOB);
			Console.WriteLine("your Date of Birth is: " + myPatient.DateOfBirth);
			Console.ReadKey();
			Console.WriteLine("Enter your Gender 0 for Unknown| 1 for Male| 2 for Female:");
			string gender = Console.ReadLine();
			Patient.Gender pGender = (Patient.Gender)Enum.Parse(typeof(Patient.Gender), gender);
			myPatient.gender = Patient.GetGender(pGender);
			Console.WriteLine("Gender:"+ myPatient.gender);
			Console.ReadKey();
			Address address;
			//Enter Address
			Console.WriteLine("Enter Address1:");
			address.AddressLine1 = Console.ReadLine();
			Console.WriteLine("Enter Address2:");
			address.AddressLine2 = Console.ReadLine();
			Console.WriteLine("Enter City:");
			address.City = Console.ReadLine();
			Console.WriteLine("Enter PostCode:");
			address.PostCode = Console.ReadLine();
			Console.WriteLine("Patient's Address :"+"\r\n" + "{0},{1}" + "\r\n" +"{2}", address.AddressLine1, address.AddressLine2,address.City);
			Console.ReadKey();

		}

	}
}
