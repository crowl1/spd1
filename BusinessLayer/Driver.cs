﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Driver
    {
        public string Name { get; set; }
        public long TimeLeft { get; set; }
        long time;

        public long Time
        {
            get { return time; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                else
                {
                    time = value;
                }
            }
        }

        public Driver(string Name, long TimeLeft, long Time)
        {
            this.Name = Name;
            this.TimeLeft = TimeLeft;
            time = Time;
        }
    }
}
