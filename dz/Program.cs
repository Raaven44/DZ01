using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Drobi d1 = new Drobi(2, 3);
            Drobi d2 = new Drobi(-2);
            Drobi d3 = new Drobi(2, 3, 4);
            Console.WriteLine(d1.ToDouble());
            Console.WriteLine((d1 * d3).ToDouble());
            Console.WriteLine((d1 * d2).Znak);
            Console.ReadKey();

        }
    }
}