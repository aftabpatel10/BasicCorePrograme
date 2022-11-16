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
            int BaseNumber = 2;
            Console.WriteLine("Enter a power Value to check power");
            int power = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i < power; i++)
            {
                BaseNumber = BaseNumber * 2;
            }
            Console.WriteLine(BaseNumber);
            Console.ReadLine();
        }
    }
}
