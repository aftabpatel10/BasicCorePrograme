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
            Console.WriteLine("Welcome To Largest Of Three Numbers Problem");
            Console.WriteLine("Enter a Three Numbers");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            int Number2 = Convert.ToInt32(Console.ReadLine());
            int Number3 = Convert.ToInt32(Console.ReadLine());
            if (Number1 > Number2 && Number1 > Number3)
            {
                Console.WriteLine("{0} is largest", Number1);
            }
            else if (Number2 > Number3 && Number2 > Number3)
            {
                Console.WriteLine("{0} is largets", Number2);
            }
            else
            {
                Console.WriteLine("{0} is largest", Number3);
            }
            Console.ReadLine();
        }
    }
}
