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
            Console.WriteLine("peeking " + myStack.Peek());
            //In stack pop method gets the top element in the stack and removes it
            Console.WriteLine("Poping " + myStack.Pop());
            //Printing the finalelements after poping the element
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
