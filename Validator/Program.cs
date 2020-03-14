using System;
using System.Text.RegularExpressions;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            // pin number - complete.
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

            //second test begins here - phone number - WIP
            Console.WriteLine("Please enter a 10-digit phone number. You may include spaces, dashes, and parentheses.");
            var phoneNumber = Console.ReadLine();
            phoneNumber = phoneNumber.Replace("-", String.Empty).Replace(" ", String.Empty).Replace("(", String.Empty).Replace(")", String.Empty);

            if (Regex.IsMatch(phoneNumber, @"^[a-zA-Z]*$"))
            {
                Console.WriteLine("No letters allowed. Try again!");
                Console.ReadLine();
            }

            Console.WriteLine(phoneNumber);
            Console.ReadLine();

            // email address

            // Power Rangers - complete. you have to account for spaces and lower/upper so unify the string that comes in.
            Console.WriteLine("In order to gain access to the Command Center, you must enter your first and last name.");
            string rangerName = Console.ReadLine();
            rangerName = rangerName.Replace(" ", String.Empty);
            rangerName = rangerName.ToLower();

            switch (rangerName)
            {
                case "zacktaylor":
                    Console.WriteLine("Welcome, Black Ranger!");
                    Console.ReadLine();
                    break;
                case "kimberlyhart":
                    Console.WriteLine("Welcome, Pink Ranger!");
                    Console.ReadLine();
                    break;
                case "billycranston":
                    Console.WriteLine("Welcome, Blue Ranger!");
                    Console.ReadLine();
                    break;
                case "trinikwan":
                    Console.WriteLine("Welcome, Yellow Ranger!");
                    Console.ReadLine();
                    break;
                case "jasonscott":
                    Console.WriteLine("Welcome, Red Ranger!");
                    Console.ReadLine();
                    break;
                case "tommyoliver":
                    Console.WriteLine("Welcome, Green or White Ranger! It is really hard to keep up with what color you are from day to day.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Nice try, Bulk and /or Skull!");
                    Console.ReadLine();
                    break;
            }

            // mocking

            // palindrome

        }
    }
}
