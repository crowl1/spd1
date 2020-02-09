using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spd1
{
    class Main
    {
        public List<Storage> storages = new List<Storage>();
        public List<Order> orders = new List<Order>();
        public List<Goods> goodss = new List<Goods>();
        public List<Manager> managers = new List<Manager>();
        public List<Driver> drivers = new List<Driver>();

        public void filling_list_storages()
        {
            storages.Add(new Storage { Name = "ATB", Distance = 10 });
            storages.Add(new Storage { Name = "Fora", Distance = 20 });
            storages.Add(new Storage { Name = "Furshet", Distance = 32 });
            storages.Add(new Storage { Name = "EcoMarket", Distance = 8 });
            storages.Add(new Storage { Name = "Novus", Distance = 40 });
        }

        public void filling_list_goodss()
        {
            goodss.Add(new Goods { Name = "Milk", Time = 5 });
            goodss.Add(new Goods { Name = "Bread", Time = 15 });
        }

        public void filling_list_managers()
        {
            managers.Add(new Manager { Name = "First", TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
            managers.Add(new Manager { Name = "Second", TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
        }
        public void filling_list_drivers()
        {
            drivers.Add(new Driver { Name = "First", TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
            drivers.Add(new Driver { Name = "Second", TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
        }
    }
}
