using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入一個整數: ");
            #region 方法一
            //string _input = Console.ReadLine();
            //int _result = int.Parse(_input);
            //if (_result % 2 != 0)
            //    Console.WriteLine("基數");
            //else
            //    Console.WriteLine("偶數 ");
            #endregion

            #region 方法二
            Console.WriteLine(int.Parse(Console.ReadLine()) % 2 != 0 ? $"基數" : $"偶數");
            #endregion
        }
    }
}
