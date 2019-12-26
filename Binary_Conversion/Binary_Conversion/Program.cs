using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Conversion
{
    class Binary_Conversion
    {      
        public void Conversion(int x)
        { 
            List<int> s = new List<int>();           
            while (x > 0)
            {    
                int o = x % 2;
                x = x / 2;
                s.Add(o);
            }
            s.Reverse();
            Console.Write("Binary conversion: ");
            foreach (int p in s)
            {
                Console.Write(p);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number:");
            int x = Convert.ToInt32(Console.ReadLine());
            
            if (x > 9 && x < 100)
            {
                string BinaryCode = Convert.ToString(x, 2);
                Console.WriteLine("Convert.ToString: " + BinaryCode);
                Binary_Conversion b = new Binary_Conversion();
                b.Conversion(x);
            }
            else
            {
                Console.WriteLine("The number is not included in the segment from 10 to 99!");
            }
            Console.ReadKey();
        }
    }
}
