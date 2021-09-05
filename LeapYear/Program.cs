using System;
using System.IO;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try 
            {
                var userInput = Convert.ToInt32(Console.ReadLine().Trim());
                if (userInput >= 1582) 
                {
                    if (isLeapYear(userInput))Console.WriteLine("yay");
                    else Console.WriteLine("nay");
                } 
                else Console.WriteLine("Please enter a value above 1582");
            } 
            catch (FormatException e) 
            {
                Console.WriteLine("Years are numerical...");
            }
            
            
            
        }
        public static bool isLeapYear(int year) 
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) return true;
            else return false;   
        }
    }
}
