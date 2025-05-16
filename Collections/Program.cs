using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
     * In .NET, the Stack<T> class is a generic collection that operates on the 
     * Last-In, First-Out (LIFO) principle.
     * You can push elements onto the stack and pop them off in reverse order.

     * 
    
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(400);
            list.Add(500);
            foreach (var item in list)
            {
                Console.WriteLine("my list items are {0}", item);
            }
            
            Stack<int> mystack = new Stack<int>();
            mystack.Push(10);
            mystack.Push(20);
            mystack.Push(30);
            mystack.Push(40);
            mystack.Push(50);
            /*
             *Push() - Adds elements to the stack.
- Pop(): Removes and returns the top element.
- Peek(): Returns the top element without removing it.
- Iteration: You can loop through the stack elements.

             */
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
            Console.WriteLine("my stack elements are" + mystack.Count);

         //   Queue – A first-in, first -out (FIFO)data structure where the first item
         //* added is the first to be removed, similar to a queue of people waiting in line

            Queue<int> queue = new Queue<int>();

            // Enqueue elements (adding items)
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

//            Enqueue() - Adds elements to the queue.
//-Dequeue() – Removes and returns the front element.
//-Peek() – Returns the front element without removing it.
//- Iteration – You can loop through queue items.


            Console.WriteLine("Queue contents:");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            // Dequeue an element (removing the first item)
            int removedValue = queue.Dequeue();
            Console.WriteLine("Dequeued value: {0}", removedValue);

            // Peek at the front element without removing it
            int frontValue = queue.Peek();
            Console.WriteLine("Front value after dequeue: {0}", frontValue);



            ArrayList arrayList = new ArrayList();

            // Add elements of different types
            arrayList.Add(10);          // Integer
            arrayList.Add("Hello");     // String
            arrayList.Add(3.14);        // Double
            arrayList.Add(true);        // Boolean

            Console.WriteLine("ArrayList contents:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Access elements by index
            Console.WriteLine("First element: {0}", arrayList[0]);

            // Remove an element
            arrayList.Remove("Hello");

            Console.WriteLine("ArrayList after removal:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            //            -Stores mixed data types(not recommended for strong typing).
            //- Elements are accessed via index, like arrays.
            //- Allows dynamic resizing—no need to specify a fixed size.
            //-Less efficient than List<T>, since boxing/ unboxing occurs for value types.
            //While ArrayList is still available in .NET, it's better to use List<T> for type safety and performance. Would you like an example with List<T> instead? 🚀



            Hashtable hashtable = new Hashtable();

            // Add key-value pairs
            hashtable.Add(1, "Apple");
            hashtable.Add(2, "Banana");
            hashtable.Add(3, "Cherry");
            hashtable.Add(4, "Apple");

            // Retrieve value using a key
            Console.WriteLine("Value for key 2: {0}", hashtable[2]);

            // Iterate over Hashtable
            Console.WriteLine("Hashtable contents:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
            }

            // Remove an entry
            hashtable.Remove(1);
            Console.WriteLine("Hashtable after removal:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
            }
           

//            -Stores key - value pairs for fast lookup.
//-Keys must be unique, while values can be duplicated.
//- Uses hashing for optimized search and retrieval.
//- Supports different types of keys and values,
//but lacks type safety compared to Dictionary<TKey, TValue>.
//The Hashtable class is still available,
//but Dictionary<TKey, TValue> is preferred in modern.NET development for better type
//safety and performance

        /*
          * - Queue – A first-in, first-out (FIFO) data structure where the first item 
          * added is the first to be removed, similar to a queue of people waiting in line.
- ArrayList – A dynamic array that allows elements to be stored in indexed order. Unlike regular arrays, an ArrayList can grow and shrink dynamically, making it more flexible.
- Hashtable – A collection that stores key-value pairs using a hashing 
        mechanism, enabling fast data retrieval. 
        It's useful for situations where quick lookups are needed.

          */
    }
}
}
