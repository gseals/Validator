using System;
using System.Text.RegularExpressions;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            // first instruction set complete
            // Console.WriteLine("Please enter a numeric pin between 4 and 8 characters");
            // var testPin = Console.ReadLine();

            // if (testPin.Length > 3 && testPin.Length < 9 && Regex.IsMatch(testPin, @"^\d+$"))
            // {
            //    Console.WriteLine(true);
            //    Console.ReadLine();
            // }
            // else if (testPin.Length <= 3 || testPin.Length >= 9 || Regex.IsMatch(testPin, @"^[A-Za-z]+$"))
            // {
            //    Console.WriteLine("Something's not right");
            //    Console.ReadLine();
            // }

            //second test begins here
            Console.WriteLine("Please enter a 10-digit phone number. You may include spaces, dashes, and parentheses.");
            var phoneNumber = Console.ReadLine();
            int phoneWithoutLetters;

            if (Regex.IsMatch(phoneNumber, @"^[a-zA-Z]$"))
            {
                Console.WriteLine("There are letters in this sequence");
                Console.ReadLine();
            }
            else if (Regex.IsMatch(phoneNumber, @"^[0-9]{10}$") && phoneNumber.IndexOf("555") == -1)
            {
                Console.WriteLine("That's a fine looking phone number you got there.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Something doesn't match.");
                Console.ReadLine();
            }
        }
    }
}
