using System;
using System.IO;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userInput = Console.ReadLine().Trim();
            if (isLeapYear(Convert.ToInt32(userInput))) Console.WriteLine("yay");
            else Console.WriteLine("nay");
        }
        public static bool isLeapYear(int year) 
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) return true;
            else return false;   
        }
    }
}
