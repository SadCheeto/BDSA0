using System;
using System.IO;
using Xunit;

namespace LeapYear.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Main_print_Hello_World()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            
            
            Assert.Equal("Hello World!", output);
        }

        [Fact]
        public void IsLeapYear_Divisible_by_4_and_400_returns_true() 
        {
            Assert.True(Program.isLeapYear(2000));
            Assert.True(Program.isLeapYear(1996));
            Assert.True(Program.isLeapYear(1600));
            Assert.True(Program.isLeapYear(1200));
        }

        [Fact]
        public void IsLeapYear_Is_Divisible_by_100_returns_false() 
        {     
            Assert.False(Program.isLeapYear(1900));
            Assert.False(Program.isLeapYear(1800));
        }

        [Fact]
        public void IsLeapYear_Is_Not_Divisible_by_4_returns_false() 
        {     
            Assert.False(Program.isLeapYear(1937));
            Assert.False(Program.isLeapYear(1834));
        }
    }
}
