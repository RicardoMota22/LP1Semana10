using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            /*if (args.Length != 1)
            {
                Console.WriteLine("just 1 arg");
                return;
            }

            string filename = args[0];
            */
            //Console.WriteLine("Enter Filenames:");
            
            //string filename = Console.ReadLine();
            //Queue<string> queue = new Queue<string>();

            string input_path = args[0];
            string input;
            bool input_loop = true;
            using StreamWriter sw = new StreamWriter(input_path);

            while(input_loop == true)
            {
                input = Console.ReadLine();
                if(input == "")
                {
                    input_loop = false;
                }
                else
                {
                    sw.WriteLine(input);
                }
            }
            /*{
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                queue.Enqueue(input);
            }*/
                //WriteToFile(filename, queue);
        }
            /*
            private static void WriteToFile(string filename, Queue<string> queue)
            {
                    while (queue.Count > 0)
                    {
                        StreamWriter File = new StreamWriter(filename, true);
                        string line = queue.Dequeue();
                        File.WriteLine(line);
                    }
        }*/


    }
}
