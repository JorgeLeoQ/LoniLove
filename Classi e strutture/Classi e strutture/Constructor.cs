﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_e_strutture
{
    class Constructor
    {
        static void Main(string[] args)
        {
            Person anonymous = new Person();
            Console.WriteLine("Person 1: name: {0}, age: {1}",
                anonymous.Name, anonymous.Age);

            Person peter = new Person("Peter", 19);
            Console.WriteLine("Person 2: name: {0}, age: {1}",
                peter.Name, peter.Age);
            Console.WriteLine();

            AlarmClock defaultAlarm = new AlarmClock();
            Console.WriteLine("Wake up! It's {0:D2}:{1:D2} o'clock.",
                defaultAlarm.Hours, defaultAlarm.Minutes);

            AlarmClock earlyAlarm = new AlarmClock(5, 15);
            Console.WriteLine("Wake up! It's {0:D2}:{1:D2} o'clock.",
                earlyAlarm.Hours, earlyAlarm.Minutes);
            Console.WriteLine();

            Point centerPoint = new Point();
            centerPoint.Name = "Center of the coordinate system";
            Console.WriteLine("First point: ({0},{1}) has name '{2}'",
            centerPoint.XCoord, centerPoint.YCoord, centerPoint.Name);

            Point point77 = new Point(7, 7);
            Console.WriteLine("Second point: ({0},{1}) has name '{2}'",
                point77.XCoord, point77.YCoord, point77.Name);
            Console.WriteLine();
        }
    }
}
