﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class TimeCardTransaction : Transaction
    {
        private readonly DateTime date;
        private readonly double hours;
        private readonly int empId;

        public TimeCardTransaction(DateTime date, double hours, int empId)
        {
            this.date = date;
            this.hours = hours;
            this.empId = empId;
        }

        public void Execute()
        {
            Employee e = PayrollDatabase.GetEmployee(empId);
            if (e != null)
            {
                HourlyClassification hc =
                    e.Classification as HourlyClassification;
                if (hc != null)
                    hc.AddTimeCard(new TimeCard(date, hours));
                else
                    throw new InvalidOperationException(
                        "Tried to add timecard to" +
                        "non-hourly employee");
            }
            else
                throw new InvalidOperationException(
                "No such employee.");
        }
    }
}
