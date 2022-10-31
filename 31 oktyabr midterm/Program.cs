using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _31_oktyabr_midterm
{
    internal class Program
    {
        static int Factorial(int x)
        {
            int output = 1;
            for(int i=1; i <= x; i++)
            {
                output *= i;
            }
            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(x));
            
        }
    }
}
