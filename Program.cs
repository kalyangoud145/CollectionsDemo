using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        static void Main(string[] args)
        {
            //calling the methods
            ListDemo();
            StackDemo();
            QueueDemo();
            SetDemo();
            DictionaryDemo();
        }
        /// <summary>
        /// method for working with lists 
        /// </summary>
        private static void ListDemo()
        {
            Console.WriteLine("\n In  list demo");
            //Creating list
            List<string> list = new List<string>();
            //Adding elements to list
            list.Add("Bhanu");
            list.Add("anirudh");
            list.Add("keethi");
            list.Add("Kanch");
            //Iterating across the list to print the elements
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Method gives understanding about stack
        /// </summary>
        /// <returns></returns>
        private static void StackDemo()
        {
            Console.WriteLine("\n In  Stack demo");
            //Creating stack
            Stack<string> myStack = new Stack<string>();
            //Adding the elements to stack
            myStack.Push("first one");
            myStack.Push("second one");
            myStack.Push("Third one");
            //Iterating across the stack to print the elements
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            //In stack peek method gets the top element in the stack
            Console.WriteLine("peeking: " + myStack.Peek());
            //In stack pop method gets the top element in the stack and removes it
            Console.WriteLine("Poping: " + myStack.Pop());
            //Printing the finalelements after poping the element
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Gives understang about queue
        /// </summary>
        private static void QueueDemo()
        {
            Console.WriteLine("\n In  Queue demo");
            //Creating the queue
            Queue<string> queue = new Queue<string>();
            //Adding elements to queue
            queue.Enqueue("Kalyan");
            queue.Enqueue("Bhanu");
            queue.Enqueue("Anirudh");
            Console.WriteLine("Peeking: " + queue.Peek());
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            //Element at the starting of the queue will be removed
            Console.WriteLine("Dequeueing the element: " + queue.Dequeue());
            //Iterating queue elements using enumerator and printing elements
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            Console.WriteLine("Elements after dequeuing");
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        /// <summary>
        /// Gives understang about Set
        /// </summary>
        private static void SetDemo()
        {
            Console.WriteLine("\n In  Set demo");
            // Creating HashSet
            // Using HashSet class 
            HashSet<string> hashSet = new HashSet<string>();
            // Add the elements in HashSet 
            // Using Add method 
            hashSet.Add("Kalyan");
            hashSet.Add("Bhanu");
            hashSet.Add("Anirudh");
            hashSet.Add("Ted");
            Console.WriteLine("Elements of hashSet:");
            // Accessing elements of HashSet 
            // Using foreach loop 
            foreach (var val in hashSet)
            {
                Console.WriteLine(val);
            }
            //Removing specific element in the set
            hashSet.Remove("Ted");
            //Iterating queue elements using enumerator and printing elements
            HashSet<string>.Enumerator enumerator = hashSet.GetEnumerator();
            Console.WriteLine("Elements after removing");
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        //Gives understanding about dictionary
        private static void DictionaryDemo()
        {
            Console.WriteLine("In Dictionary");
            Dictionary<int, string> dictionay = new Dictionary<int, string>();
            dictionay.Add(100, "Amith");
            dictionay.Add(101, "Dev");
            dictionay.Add(103, "Vijay");
            Console.WriteLine("Acess value using key()key==100 is " + dictionay[100]);
            Console.WriteLine("Iterating Dictionary: ");
            foreach (var element in dictionay)
            {
                Console.WriteLine("key " + element.Key + " has value " + element.Value);
            }
            // removing element
            dictionay.Remove(103);
            Console.WriteLine("printing elementing after removing element");
            foreach (var element in dictionay)
            {
                Console.WriteLine("key " + element.Key + " has value " + element.Value);
            }
        }
    }
}
