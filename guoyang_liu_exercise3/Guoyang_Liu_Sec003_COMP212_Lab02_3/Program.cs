using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;

namespace Guoyang_Liu_Sec003_COMP212_Lab02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // test int linked list
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var intList = new LinkedListLibrary.List<int>();
            int result = intList.Minimum<int>(intArray);
            Console.WriteLine($"The smallest value: {result}");

            // test double linked list
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9 };

            var doubleList = new LinkedListLibrary.List<double>();
            double result2 = doubleList.Minimum<double>(doubleArray);
            Console.WriteLine($"The smallest value: {result2}");

            // test string linked list
            var stringList = new LinkedListLibrary.List<string>();

            stringList.InsertAtFront("ab");
            stringList.InsertAtFront("bc");
            stringList.InsertAtBack("cd");
            stringList.InsertAtBack("de");
            stringList.InsertAtBack("ef");
            stringList.InsertAtBack("fg");
            stringList.Display();

            string result3 = stringList.GetLastNode();
            Console.WriteLine($"Last node: {result3}");


        }
    }
}
