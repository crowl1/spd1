using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spd1
{
    class Manager
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


        public Manager(string Name, long TimeLeft, long Time)
        {
            this.Name = Name;
            this.TimeLeft = TimeLeft;
            this.Time = Time;
        }
    }
}
