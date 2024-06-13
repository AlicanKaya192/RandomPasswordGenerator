using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Random Password Generator");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            while (true)
            {
                Console.Write("How long should your password be? : ");
                int passwordLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");

                Console.Write("Will your password have uppercase letters? - Y / N : ");
                string uppercaseCon = Console.ReadLine();
                string uppercaseConfirm = uppercaseCon.ToUpper();

                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");

                Console.Write("Will your password have lowercase letters? - Y / N : ");
                string lowercaseCon = Console.ReadLine();
                string lowercaseConfirm = lowercaseCon.ToUpper();

                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");

                Console.Write("Will your password have numbers? - Y / N : ");
                string numberCon = Console.ReadLine();
                string numberConfirm = numberCon.ToUpper();

                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");

                Console.Write("Will your password have special characters? - Y / N : ");
                string specialCon = Console.ReadLine();
                string specialConfirm = specialCon.ToUpper();

                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");

                Random rnd = new Random();

                string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string lowerCase = "abcdefghijklmnopqrstuvwxyz";
                string numbers = "0123456789";
                string specialCharacters = "!@#$%^&*()";

                string allCharacters = "";

                if (uppercaseConfirm == "Y")
                {
                    allCharacters += upperCase;
                }
                if (lowercaseConfirm == "Y")
                {
                    allCharacters += lowerCase;
                }
                if (numberConfirm == "Y")
                {
                    allCharacters += numbers;
                }
                if (specialConfirm == "Y")
                {
                    allCharacters += specialCharacters;
                }

                char[] password = new char[passwordLength];

                for (int i = 0; i < passwordLength; i++)
                {
                    password[i] = allCharacters[rnd.Next(allCharacters.Length)];
                }

                string finalPassword = new string(password);

                Console.WriteLine($"Your password is : {finalPassword}");

                Console.WriteLine("");
                Console.Write("Would you like to create a new password? - Y / N : ");
                string answer = Console.ReadLine();
                string answerr = answer.ToUpper();

                if(answerr == "Y")
                {
                    Console.Clear();
                }

                if (answerr == "N")
                {
                    break;
                }

                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
            }
        }
    }
}