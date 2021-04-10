using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入一個年份: ");
            string _input = Console.ReadLine();
            int _result = int.Parse(_input)+ 1911;
            // 閏年規則
            // 年份 Mod 400 = 0 (亦即為可被400整除) = "閏年"
            // 年份 Mod 4 = 0 且 Mod 100 != 0 = "閏年"
            if (_result % 400 == 0 ||( _result % 4 == 0 && _result % 100 != 0)) 
                Console.WriteLine("閏年");
            else
                Console.WriteLine("平年");

            #region 方法二
            Console.WriteLine(DateTime.IsLeapYear(_result) ? "閏年" : "平年");
            #endregion

            Console.ReadLine();
        }
    }
}
