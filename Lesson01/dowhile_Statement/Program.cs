using System;


namespace dowhile_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWhileTest();
        }

        private static void DoWhileTest() {
            int i = 1;
            do
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
            while (i <= 5);
        }
    }
}
