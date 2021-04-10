using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06
{

    class BasicData
    {
        public int item { get; set; }
        public string ModeI()
        {
            DateTime _result = new DateTime(item, 01, 01);
            int totalSatday = 0;
            int totalSunday = 0;
            int getsetDays;
            if (DateTime.IsLeapYear(item)== true)
                getsetDays = 366;
            else
                getsetDays = 365;
            for (int i = 0; i < getsetDays; i++)
            {
                if (_result.DayOfWeek == DayOfWeek.Saturday) totalSatday++;
                if (_result.DayOfWeek == DayOfWeek.Sunday) totalSunday++;
                _result = _result.AddDays(1);
            }
            item = item - 1911;
            string totaldays;
            totaldays = $"民國 {item}年 週六 {totalSatday}天 週日 {totalSunday}天";
            return totaldays;
        }
        public string ModeII()
        {
            item = item + 1911;
            DateTime _result = new DateTime(item, 01, 01);
            int totalSatday = 0;
            int totalSunday = 0;
            int getsetDays;
            if (DateTime.IsLeapYear(item) == true)
                getsetDays = 366;
            else
                getsetDays = 365;
            for (int i = 0; i < getsetDays; i++)
            {
                if (_result.DayOfWeek == DayOfWeek.Saturday) totalSatday++;
                if (_result.DayOfWeek == DayOfWeek.Sunday) totalSunday++;
                _result = _result.AddDays(1);
            }
            string totaldays;
            totaldays = $"西元 {this.item}年 週六 {totalSatday}天 週日 {totalSunday}天";
            return totaldays;
        }
    }
}
