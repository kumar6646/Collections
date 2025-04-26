using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /*
     * Collections: is representing Collections of elements
     * Every Collections will be provided by Microsoft as predefined class.
     * 
     * Before .net 2.0 which have normal collection class
     * Normal class all predefined within a base class called
     * system.collections
     * 
     * Normal collections class:
     * 1)stack
     * 2)queue
     * 3)arrayList
     * 4)Hashtable
     * 
     * Generic Colletions
     * system.collections.Generics
     * stack<>
     * Queue<>
     * List<>
     * Dictionary<>
     * 
    
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> mystack = new Stack<int>();
            mystack.Push(10);
            mystack.Push(20);
            mystack.Push(30);
            mystack.Push(40);
            mystack.Push(50);
            Console.WriteLine("mystack elements are");
            foreach (int i in mystack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("pop element is"+mystack.Pop());
            Console.WriteLine("peek element is" + mystack.Peek());
            foreach (int i in mystack)
            {
                Console.WriteLine(i);
            }
            int[] arr = new int[5];
            mystack.CopyTo(arr, 1);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            mystack.Clear();
            Console.WriteLine("my stack elements are"+mystack.Count);
        }
    }
}
