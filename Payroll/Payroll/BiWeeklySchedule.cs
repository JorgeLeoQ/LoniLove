﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class BiWeeklySchedule : PaymentSchedule
    {
        public bool IsPayDate(DateTime payDate)
        {
            return payDate.DayOfWeek == DayOfWeek.Friday &&
                payDate.Day % 2 == 0;
        }
        public DateTime GetPayPeriodStartDate(DateTime date)
        {
            return date.AddDays(-13);
        }

        public override string ToString()
        {
            return "bi-weekly";
        }
    }
}
