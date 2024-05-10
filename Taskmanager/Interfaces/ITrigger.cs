using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ITrigger
    {
        TriggerType Type { get; }

        // Define method for specific trigger types
        void SetDailyTrigger(int interval = 1);
        void SetHourlyTrigger(int interval = 1);
        void SetAtSpecificTime(DateTime time);
        void SetWeeklyTrigger(DayOfWeek dayOfWeek, int interval = 1);
        void SetMonthlyTrigger(int dayOfMonth, int interval = 1);
        void SetYearlyTriger(int month, int dayOfMonth, int interval = 1);


    }
}
