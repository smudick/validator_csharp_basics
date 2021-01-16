using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Validator

            //Pincode tester

            Console.WriteLine("Enter a pin code");
            var pinCode = Console.ReadLine();
            bool lengthProp = false;
            if (pinCode.Length >= 4 && pinCode.Length <= 8)
            {
                lengthProp = true;
            }
            else
            {
                lengthProp = false;
            }
            var counter = 0;
            foreach (var digit in pinCode) 
            {
                if (digit < '0' || digit > '9')
                {
                    counter += 1;
                }
            }
            if (lengthProp == true && counter < 1)
            {
                Console.WriteLine("Valid Pin");
            }
            else
            {
                Console.WriteLine("Invalid Pin");
            }

            //Phone number 
            Console.WriteLine("Enter a phone number");
            var phoneNumber = Console.ReadLine();
            var justNumbers = System.Text.RegularExpressions.Regex.Replace(phoneNumber, "[^0-9]", "");
            bool phoneLength = false;
            if (justNumbers.Length == 10)
            {
                phoneLength = true;
            } else
            {
                phoneLength = false;
            }
            var phoneCounter = 0;
            foreach (var digit in phoneNumber)
            {
                if (digit == ' ' || digit == '-' || digit == '(' || digit == ')')
                {
                    phoneCounter += 0;
                }
                else if (digit < '0' || digit > '9')
                {
                    phoneCounter += 1;
                }
            }
            bool areaCode = false;
            if (justNumbers[0] == '5' && justNumbers[1] == '5' && justNumbers[2] == '5')
            {
                areaCode = false;
            }
            else
            {
                areaCode = true;
            }
            if (phoneLength == true && phoneCounter == 0 && areaCode == true)
            {
                Console.WriteLine("Valid Phone number");
            }
            else
            {
                Console.WriteLine("Invalid Phone number");
            }
        }
    }
}
