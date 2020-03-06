using System;
using System.Text.RegularExpressions;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numeric pin between 4 and 8 characters");
            var testPin = Console.ReadLine();

            if (testPin.Length > 3 && testPin.Length < 9 && Regex.IsMatch(testPin, @"^\d+$"))
            {
                Console.WriteLine(true);
                Console.ReadLine();
            }
            else if (testPin.Length <= 3 || testPin.Length >= 9 || Regex.IsMatch(testPin, @"^[A-Za-z]+$"))
            {
                Console.WriteLine("Something's not right");
                Console.ReadLine();
            }
        }
    }
}
