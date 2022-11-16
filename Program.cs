using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Leap Year Program");
            Console.WriteLine("Enter a Year");
            Random random = new Random();
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 400 == 0) && ( year % 4 ==0) && ( year % 100 == 0))
            {
                Console.WriteLine("Year is a Leap Year");
              
            }
            else
            {
                Console.WriteLine("Year is Not a Leap Year");
            }
            Console.ReadLine();
        }
    }
}
