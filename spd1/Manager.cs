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
        public long Time { get; set; }

        public Manager(string Name, long TimeLeft, long Time)
        {
            this.Name = Name;
            this.TimeLeft = TimeLeft;
            this.Time = Time;
        }
    }
}
