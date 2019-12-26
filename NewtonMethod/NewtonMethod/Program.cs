using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethod
{
    class NewtonMethod
    {
        static double Power(double x0, double n_1)
        {
            double power = 1;
            for (int i = 0; i < n_1; i++)
            {
                power *= x0;
            }
            return power;
        }
        internal static double Sqrt(double n, double a, double eps=0.001)
        {
            double x0 = a / n;          
            double x1 = (1 / n) * ((n - 1) * x0 + a / Power(x0, n - 1));
            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + a / Power(x0, n - 1));
            }
            return x1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert the power:");
            double n = Convert.ToDouble(Console.ReadLine());
            double n1 = 1 / n;
            Console.WriteLine("Math.Pow: " + Math.Pow(x, n1));
            Console.WriteLine();
            Console.WriteLine("Newton's Method: " + NewtonMethod.Sqrt(n, x));
            Console.ReadKey();
        }
    }
}
