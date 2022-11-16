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
            Console.WriteLine("Welcome To Even Or odd Number Problem");
            Console.WriteLine("Enter a Number ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number %2 == 0)
            {
                Console.WriteLine("Given Number is Even");
            }
            else
            {
                Console.WriteLine("Given Number is Odd");
            }
              
            Console.ReadLine();
        }
    }
}
