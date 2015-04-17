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
			Console.WriteLine("Enter your Gender:");
			myPatient.Gender = Console.ReadLine();
		}

	}
}
