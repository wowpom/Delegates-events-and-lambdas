﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates__events__and_lambdas
{ delegate void Time();
    class SimpleDelegates
    {
        public static void WhatYime()
        {
            Time time;
            if (DateTime.Now.Hour < 12)
                time = Morning;
            else
                time = Evening;
            time();
        }
        private static void Morning()
        {
            Console.WriteLine("Доброе утро");
        }
        private static void Evening()
        {
            Console.WriteLine("Добрый вечер");
        }
    }
}
