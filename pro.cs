using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kérek egy másik számot");
            int y = Int32.Parse(Console.ReadLine());
            int eredmeny = x - y;

            Console.WriteLine("Az eredmény: {0}", eredmeny);
            Console.ReadKey();
        }
    }
}
