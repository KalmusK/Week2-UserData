using System;

namespace UserAge
{
	class Program
	{
		static void Main(string[] args)
		{

			//programm küsib kasutaja vannust
			//programm arvutab sünniaasta
			//programm kuvab sünniaasta konsoolis "oled sündinud aastal {yearOfBirth}"

			Console.WriteLine("Palun sisesta oma vanus:");

			int UserAge = Convert.ToInt32(Console.ReadLine());

			int yearOfBirth = 2022 - UserAge;


			Console.WriteLine($"Oled sündinud aastal {yearOfBirth}.");


		}
	}
}
