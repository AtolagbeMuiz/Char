using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @char
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            char ch;

            Console.WriteLine("Number Value");

            for (i = 63; i <= 94; i++)
            {
                ch = (char) i ;
                Console.WriteLine("{0} is {1}", i, ch);
            }

        }
    }
}
