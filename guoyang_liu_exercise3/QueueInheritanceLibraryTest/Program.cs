using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using LinkedListLibrary;
using QueueInheritanceLibrary;

namespace QueueInheritanceLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // test GetLast method
            QueueInheritance doubleList = new QueueInheritance();
            doubleList.Enqueue(1.1);
            doubleList.Enqueue(2.2);
            doubleList.Enqueue(3.3);
            doubleList.Enqueue(4.4);
            doubleList.Enqueue(5.5);
            doubleList.Display();

            object last = doubleList.GetLast<object>();
            Console.WriteLine($"Last element: {last}");

            // test Minimum method
            int[] intArray = { 9, 19, 29, 39, 49, 59, 69, 79, 89, 99 };

            var intList = new QueueInheritance();
            int result = intList.Minimum<int>(intArray);
            Console.WriteLine($"The smallest value: {result}");

        }

    }

}
