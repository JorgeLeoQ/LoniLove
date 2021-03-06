﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Die : IComparable
    {
        private int number;
        static private Random randomNumberSupplier = new Random((int)DateTime.Now.Ticks);
        private const int maxNumberOfEyes = 6;

        public Die()
        {
            number = NewToss();
        }

        public void Toss()
        {
            number = NewToss();
        }

        private int NewToss()
        {
            return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
        }

        public int Number()
        {
            return number;
        }

        public override String ToString()
        {
            return String.Format("[{0}]", number);
        }

        public int CompareTo(object die)
        {
            Die myDeal = (Die)die;
            int compElem = myDeal.number; 
            return number.CompareTo(compElem);
        }
    }
}
