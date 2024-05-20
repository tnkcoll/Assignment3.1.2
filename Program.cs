using System.Security.Cryptography.X509Certificates;

namespace Assignment3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string year;

            year = GetYear();
            IfYearIsLeap(year);
        }

        public static string GetYear()
        {
            string userInput;

            Console.WriteLine("Let's play IS IT A LEAP YEAR!");
            Console.WriteLine("Please enter a year and the program will tell you if it is a leap year or not!");
            do
            {
                userInput = Console.ReadLine();
            } while (userInput == "");
            
            return userInput;
        }

        public static void IfYearIsLeap(string year) 
        {
            bool isLeapYear = DateTime.IsLeapYear(Convert.ToInt32(year));

            if (isLeapYear)
            {
                Console.WriteLine($"YES! {year} is a leap year!");
            }
            else
            {
                Console.WriteLine($"NO! {year} is not a leap year!");
            }
        }
    }
}
