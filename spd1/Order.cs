using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spd1
{
    class Order
    {
        public string Name;
        public long TimeLeft;

        Driver driver = new Driver();
        Manager manager = new Manager();

        public void order(string name, int distance, long time_goods)
        {
            var manager_info = manager.availability_check_drivers();
            string name_manager = manager_info.Item1;
            long time_left_manager = manager_info.Item2;
            long time_manager = manager_info.Item3;

            var driver_info = driver.availability_check_drivers();
            string name_driver = driver_info.Item1;
            long time_left_driver = driver_info.Item2;
            long time_driver = driver_info.Item3;


        }
    }
}
