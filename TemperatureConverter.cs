using System;

class TemperatureConverter
{
	public void Start()
	{
		while (true)
		{
			Console.WriteLine("\nTemperature Conversion Menu:");
			Console.WriteLine("1. Fahrenheit to Celsius (List Conversion)");
			Console.WriteLine("2. Celsius to Fahrenheit (List Conversion)");
			Console.WriteLine("3. Convert a Specific Temperature");
			Console.WriteLine("0. Exit");
			Console.Write("Enter your choice: ");

			if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > 3)
			{
				Console.WriteLine("Invalid input. Please enter 0, 1, 2, or 3.");
				continue;
			}

			switch (choice)
			{
				case 1:
					ConvertFahrenheitToCelsius();
					break;
				case 2:
					ConvertCelsiusToFahrenheit();
					break;
				case 3:
					ConvertSpecificTemperature();
					break;
				case 0:
					Console.WriteLine("Exiting Temperature Converter.");
					return; // Exit the TemperatureConverter menu
			}
		}
	}

	private void ConvertFahrenheitToCelsius()
	{
		Console.WriteLine("\nFahrenheit to Celsius conversion:");
		for (int f = 0; f <= 212; f += 10)
		{
			Console.WriteLine($"{f} F is {((f - 32) * 5) / 9.0:F2} C");
		}
	}

	private void ConvertCelsiusToFahrenheit()
	{
		Console.WriteLine("\nCelsius to Fahrenheit conversion:");
		for (int c = 0; c <= 100; c += 5)
		{
			Console.WriteLine($"{c} C is {(c * 9 / 5.0) + 32:F2} F");
		}
	}

	private void ConvertSpecificTemperature()
	{
		int choice = 0;
		do
		{
			Console.WriteLine("Do you want to convert from (1) Fahrenheit to Celsius or (2) Celsius to Fahrenheit?");
			if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
			{
				Console.WriteLine("Invalid input. Please enter 1 or 2.");
			}
		} while (choice != 1 && choice != 2);

		Console.WriteLine($"Enter the temperature in {(choice == 1 ? "Fahrenheit" : "Celsius")}:");
		double temp;
		while (!double.TryParse(Console.ReadLine(), out temp))
		{
			Console.WriteLine($"Invalid input. Please enter a temperature in {(choice == 1 ? "Fahrenheit" : "Celsius")}.");
		}

		if (choice == 1)
		{
			double converted = (temp - 32) * 5 / 9;
			Console.WriteLine($"{temp} F is {converted:F2} C");
		}
		else
		{
			double converted = (temp * 9 / 5) + 32;
			Console.WriteLine($"{temp} C is {converted:F2} F");
		}
	}
}
