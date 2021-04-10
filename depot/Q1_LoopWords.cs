using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_LoopWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一句話: ");
            string input = Console.ReadLine();
            bool isRept = true;
            for (int i = 0; i < (input.Length /2); i++)
            {
                if (input[i] != input[input.Length - i - 1])
                    isRept = false;
            }
            if (isRept == true) 
                Console.WriteLine("是"); 
            else 
                Console.WriteLine("不是"); 
            Console.ReadLine();
        }
    }
}
