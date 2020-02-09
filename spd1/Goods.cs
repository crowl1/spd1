using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spd1
{
    class Goods
    {
        public string Name;
        public long Time;

        public void filling_list_goodss()
        {
            Main.goodss.Add(new Goods { Name = "Milk", Time = 5 });
            Main.goodss.Add(new Goods { Name = "Bread", Time = 15 });
        }
    }
}
