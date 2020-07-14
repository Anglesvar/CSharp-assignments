using System;
using System.Collections;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Calling LastWord static function
            Console.WriteLine("*********** FIRST PROGRAM ************ ");
            Console.WriteLine("POSITION - {0}\t STRING - {1}\t CHARTOPARSE - {2}",0, "Welcome to Angle's Code", ' ');
            Console.WriteLine(Utility.LastWord(0, "Welcome to Angle's Code", ' '));

            //2. Calling GetPalindromes non-static function
            Console.WriteLine("*********** PALINDROME PROGRAM ********");
            Utility utility = new Utility();
            ArrayList palindromeWords = new ArrayList();
            palindromeWords.Add("Anglesvar");
            palindromeWords.Add("New");
            palindromeWords.Add("pieeip");
            palindromeWords.Add("MadaM");
            palindromeWords.Add("nursesrun");
       
            var palindromeResult = utility.GetPalindromes(palindromeWords);
            foreach (string value in palindromeResult)
                Console.WriteLine(value);

            Console.WriteLine("****** Temperature Converter ********");
            Console.WriteLine("CELSIUS TO FARHENHEIT - " + TemperatureConverter.CelsiusToFahrenheit("32"));
            Console.WriteLine("FARHENHEIT TO CELSIUS - " + TemperatureConverter.FahrenheitToCelsius("100"));

        }
    }
}
