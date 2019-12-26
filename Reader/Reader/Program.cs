using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader
{
    public class ReaderData
    {
        struct Coordinates
        {
            public decimal x;
            public decimal y;
            public decimal z;
            public decimal v;
            public Coordinates(string[] ads)
            {
                x = Convert.ToDecimal(ads[0]);
                y = Convert.ToDecimal(ads[1]);
                z = Convert.ToDecimal(ads[2]);
                v = Convert.ToDecimal(ads[3]);
            }
            public void Show()
            {
                Console.WriteLine("X: {0},{1}  Y: {2},{3} ", x, y, z, v);
            }
        }
        public void Act()
        {
            Coordinates[] array = new Coordinates[3];
            for (int i = 0; i < 3; i++)
            {
                array[i] = new Coordinates(Console.ReadLine().Split('.', ','));
            }
            foreach (Coordinates s in array)
                s.Show();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ReaderData a = new ReaderData { };
            a.Act();
        }
    }
}
