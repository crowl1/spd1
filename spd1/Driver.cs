using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spd1
{
    class Driver
    {
        public string Name;
        public long TimeLeft;
        public void filling_list_drivers()
        {
            Main.drivers.Add(new Driver { Name = "First", TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
            Main.drivers.Add(new Driver { Name = "Second", TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
        }
    }
}
