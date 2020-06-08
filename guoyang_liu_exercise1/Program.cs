using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guoyang_liu_exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            char[] charArray = { 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q' };

            Console.Write("Array dataArray contains: ");
            DisplayArray(intArray);
            Console.Write("Array searchKey contains: ");
            DisplayArray(charArray);
            Console.WriteLine();

            //test
            Console.WriteLine($"The location of 4 in intArray: {Search<int>(intArray, 4)}");
            Console.WriteLine($"The location of 5 in intArray: {Search<int>(intArray, 5)}");
            Console.WriteLine($"The location of u in charArray: {Search<char>(charArray, 'u')}");
            Console.WriteLine($"The location of c in charArray: {Search<char>(charArray, 'c')}");
        }

        private static int Search<T>(T[] dataArray, T searchKey) where T : IComparable<T>
        {
            int a = 0;

            for (int i = 0; i < 10; i++)
            {
                if (dataArray[i].CompareTo(searchKey) == 0)
                {
                    a = i + 1;
                    break;
                }
            }
            if (a > 10 || a < 1)
            {
                return -1;
            }
            else
            {
                return a;
            }

        }

        private static void DisplayArray(int[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        private static void DisplayArray(char[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }//end displayArray method
    }//end class
}//end namespace
