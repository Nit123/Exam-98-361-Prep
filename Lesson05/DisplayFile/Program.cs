using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayFile
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
                return;

            try
            {
                string[] lines = File.ReadAllLines(args[0]);
                foreach (string item in lines)
                {
                    Console.WriteLine(item);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
