using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Checker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Palindrome Checker");
            while (true)
            {
                Console.Write("Please enter a string (or 'q' to quit): ");
                string input = Console.ReadLine();
                string lower = input.ToLower();

                if (lower == "q")
                {
                    Console.WriteLine("\nThanks for using Palindrome Checker!");
                    break;
                }

                string reversed = "";

                for (int i = lower.Length - 1; i >= 0; i--)
                {
                    reversed += lower[i];
                }

                if (reversed == lower)
                {
                    Console.WriteLine("\nPalindrome!");

                }
                else
                {
                    Console.WriteLine("\nNot palindrome");
                }

                Console.WriteLine("\nTry again? (y/n)\n");
                string input2 = Console.ReadLine();
                string lower2 = input2.ToLower();

                if (lower2 != "y" && lower2 != "yes")
                {
                    Console.WriteLine("\nThanks for using Palindrome Checker!");
                    break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nEnter a exit Program...");
            Console.ReadKey();
        }
    }
}
