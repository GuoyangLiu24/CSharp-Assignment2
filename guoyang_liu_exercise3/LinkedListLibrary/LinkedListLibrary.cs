using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    public class ListNode<T>
    {
        // automatic read-only property Data
        // public int Data { get; private set; }
        public T Data { get; private set; }

        // automatic property Next
        // public ListNode Next { get; set; }
        public ListNode<T> Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        // public ListNode(int dataValue) : this(dataValue, null) { }
        public ListNode(T dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        //public ListNode(int dataValue, ListNode nextNode)
        //{
        //    Data = dataValue;
        //    Next = nextNode;
        //}
        // Generic
        public ListNode(T dataValue, ListNode<T> nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }

    public class List<T>
    {
        private ListNode<T> firstNode;
        private ListNode<T> lastNode;
        private string name; // string like "list" to display

        // construct empty List with specified name
        public List(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        // construct empty List with "list" as its name 
        public List() : this("list") { }

        // Insert object at front of List. If List is empty, 
        // firstNode and lastNode will refer to same object.
        // Otherwise, firstNode refers to new node.
        public void InsertAtFront(T insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode<T>(insertItem);
            }
            else
            {
                firstNode = new ListNode<T>(insertItem, firstNode);
            }
        }

        // Insert object at end of List. If List is empty, 
        // firstNode and lastNode will refer to same object.
        // Otherwise, lastNode's Next property refers to new node.
        public void InsertAtBack(T insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode<T>(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode<T>(insertItem);
            }
        }
        // remove first node from List
        public T RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            T removeItem = firstNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            return removeItem; // return removed data
        }
        // remove last node from List
        public T RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            T removeItem = lastNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNode<T> current = firstNode;

                // loop while current.Next is not lastNode
                while (current.Next != lastNode)
                {
                    current = current.Next; // move to next node
                }

                // current is new lastNode
                lastNode = current;
                current.Next = null;
            }

            return removeItem; // return removed data
        }
        // return true if List is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        // output List contents
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                ListNode<T> current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }

        // Minimum method
        public T Minimum<T>(T[] dataArray) where T : IComparable<T>
        {
            int a = dataArray.Length;
            int result = 0;
            for (int i = 0; i < a; i++)
            {
                if (dataArray[i].CompareTo(dataArray[0]) <= 0)
                {
                    result = i;
                }
                else
                {
                    result = 0;
                }
            }
            return dataArray[result];
        }

        // GetLastNode method
        public T GetLastNode()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            T last = lastNode.Data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNode<T> current = firstNode;

                while (current.Next != lastNode)
                {
                    current = current.Next;
                }


                lastNode = current;
                current.Next = null;
            }

            return last;
        }


        // Add method Count() ..
        // Add method Sum() for finding the sum of the all the list elements
        // Add method Average()
        // Add method Search()
        // Add method Maxmimum()
        // Add method Minimum()

    } // end class

    class EmptyListException : Exception
    {
        // parameterless constructor
        public EmptyListException() : base("The list is empty") { }

        // one-parameter constructor
        public EmptyListException(string name) : base($"The {name} is empty") { }

        // two-parameter constructor
        public EmptyListException(string exception, Exception inner)
           : base(exception, inner) { }
    } // end class

}
