using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {

            //////// Pincode tester /////////

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

            //////// Phone number ////////
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
            var digitCheckCounter = 0;
            foreach (var digit in phoneNumber)
            {
                if (digit == ' ' || digit == '-' || digit == '(' || digit == ')')
                {
                    digitCheckCounter += 0;
                }
                else if (digit < '0' || digit > '9')
                {
                    digitCheckCounter += 1;
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
            if (phoneLength == true && digitCheckCounter == 0 && areaCode == true)
            {
                Console.WriteLine("Valid Phone number");
            }
            else
            {
                Console.WriteLine("Invalid Phone number");
            }

            //////// Email Address //////////
            Console.WriteLine("Enter an email address");
            var userEmail = Console.ReadLine();

            // check for 1 @ symbol
            var atChecker = 0;
            foreach (var c in userEmail)
            {
                if (c == '@')
                {
                    atChecker += 1;
                }
            }

            //split email into domain and username at the @ symbol
            var userName = "";
            var domainSection = "";
            if (atChecker == 1)
            {
                string[] emailSections = userEmail.Split('@');
                userName = emailSections[0];
                domainSection = emailSections[1];
            }
            else
            {
                Console.WriteLine("Invalid Email Address");
            }

            //check for a dot in the domain section
            var dotChecker = 0;
                foreach (var c in domainSection)
                {
                    if (c == '.')
                    {
                        dotChecker += 1;
                    }
                }

            //split domain section into domain and top level domain
            var domain = "";
            var topLevelDomain = "";
            if (dotChecker == 1)
            {
                string[] domainSections = domainSection.Split('.');
                domain = domainSections[0];
                topLevelDomain = domainSections[1];
            }       
            else
            {
                Console.WriteLine("Invalid Email Address");
            }

            //Confirm there is a domain and top level domain
            var domainSectionChecker = false;
            if (domain.Length > 0 && topLevelDomain.Length > 0)
            {
                domainSectionChecker = true;
            }
            else
            {
                domainSectionChecker = false;
            }

            //check for a username
            var userNameChecker = false;
            if (userName.Length >= 1)
            {
                userNameChecker = true;
            }
            else
            {
                userNameChecker = false;
            }

            if (dotChecker == 1 && atChecker == 1 && userNameChecker == true && domainSectionChecker == true)
            {
                Console.WriteLine("Valid Email Address");
            }
             else
            {
                Console.WriteLine("Invalid Email Address");
            }
        }
    }
}
