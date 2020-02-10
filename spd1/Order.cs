using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spd1
{
    class Order
    {
        public string Name { get; }
        public long TimeLeft { get; }

        public Order (string Name, long TimeLeft)
        {
            this.Name = Name;
            this.TimeLeft = TimeLeft;
        }
    }
}
