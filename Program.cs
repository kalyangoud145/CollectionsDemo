using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDemo();
        }
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
    }
}
