﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WageComputation
{
    internal class WageComputation
    {
        public void CheckPresence()
        {
            Random generateNum = new Random();
            int num = generateNum.Next(0,2);
            if (num == 1)
            {
                IsPresent = true;
                Console.WriteLine("Employee is Present");
            } else
            {
                IsPresent = false;
                Console.WriteLine("Employee is Absent");

            }
        }
    }
}
