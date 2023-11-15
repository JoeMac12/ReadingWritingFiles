using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadingWritingFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading / Writing Files");
            Console.WriteLine();

            string path = @"Test.txt";
            string[] input;
            input = File.ReadAllLines(path);
            Console.WriteLine(input);
            Console.WriteLine();
            string[] lines;
            lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length ; i++)
            {
                Console.WriteLine(lines[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey(true);
        }
    }
}
