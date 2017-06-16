using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            divideWithoutExceptions();
        }

        private static void divideWithoutExceptions() {
            try
            {
                int x = 100000;
                int y = 200;
                // int y = 0; //Divide by zero
               // double y = -0.543;//part of overflow
                int result = x / y;
                //int result =(int) (x / y) * 99999999999; //Overflow?
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e) {
                Console.WriteLine(e.Message);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(InvalidDataException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Exception testing is complete.");
            }
        }
    }
}
