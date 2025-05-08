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
        }
    }
}
