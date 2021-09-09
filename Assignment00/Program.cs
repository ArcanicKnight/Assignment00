using System;

namespace Assignment00
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ProgramClass = new Program();
            var x = Int32.Parse(Console.ReadLine());
            if (ProgramClass.IsLeapYear(x))
            {
                Console.WriteLine("yay");
            }
            else
            {
                Console.WriteLine("nay");
            }
        }

        bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
