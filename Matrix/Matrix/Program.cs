using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Matrix
{
    class EnterTheMatrixParameters
    {
        public int n;      
        public int m;
        public  void  InputN()
        {
            Console.WriteLine("Enter the number of rows in matrix: ");
            n = Convert.ToInt32(Console.ReadLine());            
        }
        public void InputM()
        {            
            Console.WriteLine("Enter the number of columns in matrix: ");
            m = Convert.ToInt32(Console.ReadLine());
        }
    }  
    class Mat: EnterTheMatrixParameters
    {
        static Random r1 = new Random();

        public int[,] GetMat(int n,int m)          
        {
            int[,] ma1 = new int[n, m];        
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ma1[i, j] = r1.Next(1, 10);
                    Console.Write(ma1[i, j] + " ");
                }
                Console.WriteLine();
            }
            return ma1;
        }
    }
    class Mat_A : Mat { }
    class Mat_B : Mat { }
    public class Sum
    {
        public void SumM(int n,int m,int[,] ma1,int[,] ma2)
        {           
            int[,] ma3 = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ma3[i, j] = ma1[i, j] + ma2[i, j];
                    Console.Write(ma3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    public class Multiplaction
    {
        public void MultM(int n, int m, int[,] ma1, int[,] ma2)
        {
            int[,] ma4 = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ma4[i, j] = 0;                  
                    for (int k = 0; k < n; k++)
                    {
                        ma4[i, j] += ma1[i, k] * ma2[k, j];

                    }
                    Console.Write(ma4[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            EnterTheMatrixParameters num = new EnterTheMatrixParameters();
            num.InputN();
            num.InputM();
            Mat_A a = new Mat_A { };
            Console.WriteLine("A=");
            int[,] array_a=a.GetMat(num.n, num.m);
            Console.WriteLine();
            Mat_B b = new Mat_B { };
            Console.WriteLine("B=");
            int[,] array_b=b.GetMat(num.n, num.m);
            Console.WriteLine();
            Sum s = new Sum();
            Console.WriteLine("A+B=");
            s.SumM(num.n, num.m, array_a, array_b);
            Console.WriteLine();
            Multiplaction m = new Multiplaction();
            Console.WriteLine("A*B=");
            m.MultM(num.n, num.m, array_a, array_b);
            Console.ReadKey();
        }
    }
}
