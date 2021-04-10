using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入一個整數: ");
            #region 方法一
            //string _input = Console.ReadLine();
            //int _result = int.Parse(_input);

            //for (int i = _result; i > 0; i--)
            //{
            //    for (int j = _result; j != (i - 1); j--)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine("");
            //}
            #endregion
            Console.WriteLine(
                string.Join(
                    Environment.NewLine, 
                    Enumerable.Range(1, 
                    int.Parse(Console.ReadLine()))
                    .Reverse()
                    .Select((x, index) => string.Concat(Enumerable.Repeat(x, index + 1)))
                    )
                );
            Console.ReadLine();
        }
    }
}
