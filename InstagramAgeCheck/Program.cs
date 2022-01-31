using System;

namespace InstagramAgeCheck
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutaja vanust
			//programm kontrollib kas kasutaja on vanem kui 13 või 13 aastat vana
			// kui kasutaja on 13 või rohkem siis võib IG kasutada
			//kui kasutaja on noorem kui 13, siis on ta liiga noor

			Console.WriteLine("Palun sisesta oma vanus:");
			int userAge = Convert.ToInt32(Console.ReadLine());

			if (userAge > 13)
			{
				Console.WriteLine("Oled piisavalt vana, et IG kontot luua.");
			}

			else if (userAge < 13)
			{
				Console.WriteLine("Oled liiga noor, et IG kontot luua.");
			}

			else
			{
				Console.WriteLine("Oled juba 13 ehk, piisavalt vana, et IG kontot luua.");
			}


			Console.WriteLine("Kena päeva!");


		}
	}
}
