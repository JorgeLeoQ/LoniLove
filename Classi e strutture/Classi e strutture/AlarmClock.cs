﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_e_strutture
{
    public class AlarmClock
    {
        private int hours = 9; // Inline initialization
        private int minutes = 0; // Inline initialization

        // Parameterless constructor
        public AlarmClock()
        {
        }

        // Constructor with parameters
        public AlarmClock(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public int Hours
        {
            get { return this.hours; }
            set { this.hours = value; }
        }

        public int Minutes
        {
            get { return this.minutes; }
            set { this.minutes = value; }
        }
    }
}
