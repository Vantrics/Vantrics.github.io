using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入一串整數: ");
            string _input = Console.ReadLine();
            int[] _result = _input.Split(',').Select(int.Parse).ToArray();
            Array.Sort(_result);
            Console.Write("奇數為: ");
            for (int i = 0; i < _result.Length; i++)
            {
                if (i == _result.Length - 1 )
                {
                    if (_result[i] % 2 != 0)
                        Console.WriteLine(_result[i]);
                }
                else if (_result[i] % 2 != 0)
                    Console.Write($"{_result[i]},");
            }
            Console.Write("偶數為: ");
            for (int i = 0; i < _result.Length; i++)
            {
                // Array 判斷是否為最後一筆
                if (i == _result.Length - 1 )
                {
                    if(_result[i] % 2 == 0)
                    Console.WriteLine(_result[i]);
                } 
                else if (_result[i] % 2 == 0)
                    Console.Write($"{_result[i]},");
            }
            Console.ReadLine();
        }
    }
}
