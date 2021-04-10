using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入: ");
            #region 方法一
            //string _input = Console.ReadLine();
            //string[] _result = _input.Split(',');

            //Array.Reverse(_result);
            //Console.Write("結果: ");
            //for (int i = 0; i < _result.Length; i++)
            //{
            //    if (i == _result.Length - 1)
            //        Console.WriteLine(_result[i]);
            //    else
            //        Console.Write($"{_result[i]},");
            //}
            #endregion

            #region 方法二
            Console.WriteLine($"結果: {string.Join(", ",Console.ReadLine().Split(',').Reverse())}");
            #endregion

            Console.ReadLine();
        }
    }
}
"