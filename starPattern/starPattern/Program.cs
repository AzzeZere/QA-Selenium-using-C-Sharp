using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IT Sutra First Assignment\n");
            Console.Write("Input the value: ");
            var value = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= value; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else if (i % 2 == 1)
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
