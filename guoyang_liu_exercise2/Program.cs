using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guoyang_liu_exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "If at first the idea is not absurd, then there is no hope for it.";
            string string2 = "COMP212 is my favorite class!";

            Console.WriteLine();

            int result;
            result = string1.StringBuilder();
            Console.WriteLine(string1);
            Console.WriteLine($"=> contains {result} words.");

            Console.WriteLine();

            result = string2.StringBuilder();
            Console.WriteLine(string2);
            Console.WriteLine($"=> contains {result} words.");
        }
    }
}
