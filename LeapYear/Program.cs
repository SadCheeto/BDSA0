using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static bool isLeapYear(int year) 
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) return true;
            else return false;   
        }
    }
}
