using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Validator

            //Pin
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
        }
    }
}
