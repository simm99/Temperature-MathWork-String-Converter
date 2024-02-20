using System;

class MathWork
{
	public void Start()
	{
		bool continueCalculating = true;
		while (continueCalculating)
		{
			Console.WriteLine("\nMath Work Menu:");
			Console.WriteLine("1. Sum Numbers in Range");
			Console.WriteLine("2. Print Even Numbers in Range");
			Console.WriteLine("3. Print Odd Numbers in Range");
			Console.WriteLine("4. Calculate Square Roots in Range");
			Console.WriteLine("0. Exit");
			Console.Write("Enter your choice: ");

			if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > 4)
			{
				Console.WriteLine("Invalid input. Please enter a number between 0 and 4.");
				continue;
			}

			switch (choice)
			{
				case 1:
					SumNumbers();
					break;
				case 2:
					PrintEvenNumbers();
					break;
				case 3:
					PrintOddNumbers();
					break;
				case 4:
					CalculateSquareRoots();
					break;
				case 0:
					continueCalculating = false;
					break;
			}
		}
	}

	private void SumNumbers()
	{
		Console.WriteLine("Enter the starting number:");
		int start = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the ending number:");
		int end = int.Parse(Console.ReadLine());

		int sum = 0;
		for (int i = start; i <= end; i++)
		{
			sum += i;
		}
		Console.WriteLine($"The sum of numbers from {start} to {end} is: {sum}");
	}

	private void PrintEvenNumbers()
	{
		Console.WriteLine("Enter the starting number:");
		int start = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the ending number:");
		int end = int.Parse(Console.ReadLine());

		Console.WriteLine("Even numbers in range:");
		for (int i = start; i <= end; i++)
		{
			if (i % 2 == 0)
			{
				Console.WriteLine(i);
			}
		}
	}

	private void PrintOddNumbers()
	{
		Console.WriteLine("Enter the starting number:");
		int start = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the ending number:");
		int end = int.Parse(Console.ReadLine());

		Console.WriteLine("Odd numbers in range:");
		for (int i = start; i <= end; i++)
		{
			if (i % 2 != 0)
			{
				Console.WriteLine(i);
			}
		}
	}

	private void CalculateSquareRoots()
	{
		Console.WriteLine("Enter the starting number:");
		int start = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the ending number:");
		int end = int.Parse(Console.ReadLine());

		Console.WriteLine("Square roots in range:");
		for (int i = start; i <= end; i++)
		{
			Console.WriteLine($"Square root of {i} is: {Math.Sqrt(i):F2}");
		}
	}
}
