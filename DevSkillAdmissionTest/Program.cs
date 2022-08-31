using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DevSkillAdmissionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Repository<int, Student> oRepository = new Repository<int, Student>();

            Console.WriteLine(MethodExtension.StringToPascal("This is a test"));
            
            LinqQuery oLinqQuery = new LinqQuery();

            foreach (int number in oLinqQuery.FindNumbersGreaterThanFifty(new List<int>()
                     {
                         50, 45, 54, 68, 21, 98, 1, 5, 4
                     }))
            {
                Console.WriteLine(number);
            }
            
            Console.ReadKey();
        }
    }
}
