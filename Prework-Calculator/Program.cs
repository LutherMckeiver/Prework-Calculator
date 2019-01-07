using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
             Add(4, 6);
             Subtract(6, 4);
             Multiply(4, 6);
             Divide(10, 2);

            Console.ReadLine();
        }

        static int Add(int a, int b) // add method (a, b) returns int 
        {
            Console.WriteLine(a + b);
            return a + b; // the sum of a and b 
        }

        static int Subtract(int a, int b) // subtract method (a, b) returns int 
        {
            Console.WriteLine(a - b);
            return a - b; // the difference of a and b
        }
        static int Multiply(int a, int b)  // multipy method (a, b) returns int 
        {
            Console.WriteLine(a * b);
            return a * b; // the product of a and b
        }
        static int Divide(int a, int b) // divide method (a, b) returns int 
        {
            Console.WriteLine(a / b);
            return a / b; // the quotient of a and b 
        }
            
    }
}
