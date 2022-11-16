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
            Console.WriteLine("Welcome To Vowal And Consonant Problem");
            Console.WriteLine("Enter An Alphabet");
            char Alphabet = Convert.ToChar(Console.ReadLine().ToLower());
            switch (Alphabet)
            {
                case 'a':
                    Console.WriteLine("{0} is an Vowel", Alphabet);
                    break;
                case 'e':
                    Console.WriteLine("{0} is an Vowel", Alphabet);
                    break;
                case 'i':
                    Console.WriteLine("{0} is an Vowel", Alphabet);
                    break;
                case 'o':
                    Console.WriteLine("{0} is an Vowel", Alphabet);
                    break;
                case 'u':
                    Console.WriteLine("{0} is an Vowel", Alphabet);
                    break;
                default:
                    Console.WriteLine("{0} is an Consonant", Alphabet);
                    break;
            }
                    Console.ReadLine();
        }
    }
}
