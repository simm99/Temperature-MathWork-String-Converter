using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nGlobal Main Menu:");
            Console.WriteLine("1. Temperature Converter");
            Console.WriteLine("2. String Functions");
            Console.WriteLine("3. Math Work");
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
                    TemperatureConverter converter = new TemperatureConverter();
                    converter.Start();
                    break;
                case 2:
                    StringFunctions stringFunctions = new StringFunctions();
                    stringFunctions.Start();
                    break;
                case 3:
                    MathWork mathWork = new MathWork();
                    mathWork.Start();
                    break;
                case 4:
                    // Scheduler logic here... never got implemented.
                    break;
                case 0:
                    Console.WriteLine("Exiting program.");
                    return; // Exit the program
            }
        }
    }
}
