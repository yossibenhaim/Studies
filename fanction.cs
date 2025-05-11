// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {


        static void question1()
        {
            static bool IsValidAge(int age)
            {
                return (age >= 18 && age <= 65);
            }

            Console.WriteLine("send a number");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsValidAge(age));
        }


        static void question2()
        {


            static string FormatName(string firstName, string lastName)
            {
                if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
                {
                    return lastName + "," + firstName;
                }
                return "Invalid input";
            }
            Console.WriteLine("send first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("send lest name");
            string lastName = Console.ReadLine();
            Console.WriteLine(FormatName(firstName, lastName));
        }


        static void question3()
        {
            static bool IsStrongPassword(string password)
            {
                return (password.Length >= 8 && password.Any(char.IsDigit) && password.Any(char.IsLetter));
            }

            Console.WriteLine("send password");
            string password = Console.ReadLine();
            Console.WriteLine(IsStrongPassword(password));
        }

        static void question4()
        {
            static int sumIfEven(int[] numbers)
            {
                int count = 0;
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        count += number;
                    }
                
                }
                return count;
            }

            int[] numbers1 =  { 1, 4, 8, 6 };
            Console.WriteLine(sumIfEven(numbers1));
        }

        static void question5()
        {
            static string[] GetLongestWord(List <string> words)
            {
                int big = 0;
                List<string> bigWord = new List<string>();
                foreach (string word in words)
                {
                    if (word.Length > big)
                    {
                        big = word.Length;
                        bigWord.Clear();
                        bigWord.Add(word);

                    }else if (word.Length == big)
                    {
                        bigWord.Add(word);
                    }
                }
                return bigWord.ToArray();
                
            }
            List <string> words1 = new List<string> 
                {
            "apple",       // 5 תווים
            "banana",      // 6 תווים
            "cherryccvf",      // 6 תווים
            "date",        // 4 תווים
            "elderberry",  // 10 תווים
            "fig",         // 3 תווים
            "grape"        // 5 תווים
            };

        List<string> myList = new List<string> (GetLongestWord(words1));
            foreach (string word in myList)
            {
                Console.WriteLine(word);
            }
        }

        static void Main(string[] args)
        {
            //question1();
            //question2();
            //question3();
            //question4();
            question5();

        }
    }
}