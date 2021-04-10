using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                    Console.WriteLine("金槍魚");
                else if (i % 3 == 0)
                    Console.WriteLine("章魚");
                else if (i % 2 == 0)
                    Console.WriteLine("螃蟹");
                else  
                    Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
