using System;

namespace DrivingLicense
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutaja sünniaastat
			//programm arvutab kasutaja vanust
			//kui kasutaja on noorem kui 18, siis kuvab konsoolis et oled liiga noor
			//kui kasutaja on vanem kui 18 siis kuvab konsoolis et piisavalt vana
			//kui oled kasutaja on 18 konsoolis et oled täpselt piisavalt vana


			Console.WriteLine("Palun sisesta oma sünniaasta:");
			int yearOfBirth = Convert.ToInt32(Console.ReadLine());

			int userAge = 2022 - yearOfBirth;




			if (userAge > 18)
			{
				Console.WriteLine("Oled piisavalt vana, et juhilube teha.");
			}

			else if (userAge < 18)
			{
				Console.WriteLine("Oled liiga noor, et juhilube saada.");
			}

			else
			{
				Console.WriteLine("Oled juba 18, täpselt piisav vanus juhilubade jaoks.");
			}


			Console.WriteLine("Kena päeva!");

		}
	}
}
