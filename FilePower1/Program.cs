using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("just 1 arg");
                return;
            }

            string filename = args[0];
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                queue.Enqueue(input);
            }
            }
            private static void WriteToFile(string filename, Queue<string> queue)
            {
                    while (queue.Count > 0)
                    {
                        StreamWriter File = new StreamWriter(filename, true);
                        string line = queue.Dequeue();
                        File.WriteLine(line);
                    }
        }


    }
}
