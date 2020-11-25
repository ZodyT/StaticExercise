using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    class TempConverter
    {

        //The class should have at least 2 methods, one called FahrenheitToCelsius 
        //that will require a parameter and return a double, the other CelsiusToFahrenheit
        //which will also require a parameter and return a double.

        public static double FahrenheitToCelsius(double Fahrenheit)
        {
            return (Fahrenheit - 32) /1.8;
        }

        public static double CelsiusToFahrenheit(double Celsius)
        {
            return (Celsius * 9) / 5 + 32;
        }
    }
}
