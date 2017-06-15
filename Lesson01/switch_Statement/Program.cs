using System;


namespace switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSwitch(10, 20, '+');
        }

        public static void TestSwitch(int op1, int op2, char op) {
            int result;
            switch (op) {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Unknown Operator");
                    return;
            }
            Console.WriteLine("Result: {0}", result);
        }
    }
}
