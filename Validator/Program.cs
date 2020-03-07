using System;
using System.Text.RegularExpressions;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            // first instruction set complete
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

            //second test begins here
            Console.WriteLine("Please enter a 10-digit phone number. You may include spaces, dashes, and parentheses.");
            var phoneNumber = Console.ReadLine();

            if (phoneNumber.Length < 11 && phoneNumber.Length > 0 && Regex.IsMatch(testPin, @"^\d+$") && phoneNumber.IndexOf("555") == -1) ;
            {
                Console.WriteLine("That's a fine looking phone number you got there.");
                Console.ReadLine();
            }
            Console.WriteLine("what is the truth?" + phoneNumber.IndexOf("555"));
            Console.ReadLine();
        }
    }
}
