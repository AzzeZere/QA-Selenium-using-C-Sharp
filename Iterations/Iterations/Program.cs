using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 10; a++)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
            }

            for (int b = 10; b >= 1; b--)
            {
                if (b % 2 == 0)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
