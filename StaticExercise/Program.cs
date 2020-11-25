using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is your temperature in C or F?");
            string temp = Console.ReadLine().ToLower();

            if (temp == "c")
            {
                Console.WriteLine("What is your Celsius temperature?");
                double C = Convert.ToDouble(Console.ReadLine());

                var CFinal = TempConverter.CelsiusToFahrenheit(C);
                Console.WriteLine($"Your tempature is {CFinal} in Fahrenheit.");
            }
            else if (temp == "f")
            {
                Console.WriteLine("What is your Fahrenheit temperature?");
                double F = Convert.ToDouble(Console.ReadLine());

                var FFinal = TempConverter.FahrenheitToCelsius(F);
                Console.WriteLine($"Your tempature is {FFinal} in Celsius.");

            }

        }
    }
}
