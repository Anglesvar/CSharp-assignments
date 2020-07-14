using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string temperature)
        {
            double celsius = double.Parse(temperature);
            double farenheit = (celsius * 9 / 5) + 32;
            return farenheit;
        }
        public static double FahrenheitToCelsius(string temperature)
        {
            double fahrenheit = double.Parse(temperature);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
