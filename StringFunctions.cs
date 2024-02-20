using System;

class StringFunctions
{
	public void StringLength()
	{
		Console.WriteLine("Enter any text:");
		string text = Console.ReadLine();
		int length = text.Length;
		Console.WriteLine($"Length: {length}, Uppercase: {text.ToUpper()}");
	}

	public void PredictMyDay()
	{
		Console.WriteLine("Enter a number between 1 and 7:");
		if (int.TryParse(Console.ReadLine(), out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
		{
			switch (dayNumber)
			{
				case 1: Console.WriteLine("Keep calm on Mondays! You can fall apart!"); break;
				case 2: Console.WriteLine("Tuesdays and Wednesdays break your heart!"); break;
				case 3: Console.WriteLine("Thursday is your lucky day, don't wait for Friday!"); break;
				case 4: Console.WriteLine("Friday, you are in love!"); break;
				case 5: Console.WriteLine("Saturday, do nothing and do plenty of it!"); break;
				case 6: Console.WriteLine("And Sunday always comes too soon!"); break;
				default: Console.WriteLine("No day? A good day but it doesn't exist!"); break;
			}
		}
		else
		{
			Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
		}
	}

	public bool RunAgain()
	{
		Console.WriteLine("Do you want to run again? (yes/no)");
		string answer = Console.ReadLine().ToLower();
		return answer == "yes";
	}
}
