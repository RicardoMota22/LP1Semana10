using System;

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
        }
    }
}
