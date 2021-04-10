using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNum = 0;
            for (int i = 2; i <= 200; i++)
            {
                bool modnum = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        modnum = false;
                        break;
                    }
                }
                if (modnum != false)
                {
                    Console.WriteLine(i);
                    totalNum++;
                }
            }
            Console.WriteLine($"質數共 {totalNum}個");
            Console.ReadLine();
        }
    }
}
