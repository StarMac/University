﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static lab2_2.Program;

namespace lab2_2
{
    class Timer
    {
        public static int Count()
        {
            Console.Write("Enter the number of seconds: ");
            var seconds = int.Parse(Console.ReadLine());

            TimerCallback tm = new TimerCallback(Say_Hi);

            var timer = new System.Threading.Timer(tm, 0, 0, seconds * 1000);

            return 0;
        }
        public static void Say_Hi(object obj)
        {
            Console.WriteLine("Hi! " + DateTime.Now);
        }

    }
}

