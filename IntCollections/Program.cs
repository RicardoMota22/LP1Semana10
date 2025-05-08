using System;
using System.Collections.Generic;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[]values = { 1, 10, -30, 10, -5 };

            // 1. List
            List<int> list = new List<int>();

            // 2. Stack
            Stack<int> stack = new Stack<int>();

            // 3. Queue
            Queue<int> queue = new Queue<int>();

            // 4. HashSet
            HashSet<int> hashset = new HashSet<int>();

            foreach (int value in values)
            {
                list.Add(value);
                stack.Push(value);
                queue.Enqueue(value);
                hashset.Add(value);
            }


            //List
            Console.WriteLine("List:");
            foreach (int i in list)
                Console.Write(i + " ");
            Console.WriteLine();

            //Stack
            Console.WriteLine("Stack:");
            foreach (int i in stack)
                Console.Write(i + " ");
            Console.WriteLine();

            //Queue
            Console.WriteLine("Queue:");
            foreach (int i in queue)
                Console.Write(i + " ");
            Console.WriteLine();

            //Hashset
            Console.WriteLine("Hashset:");
            foreach (int i in hashset)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
