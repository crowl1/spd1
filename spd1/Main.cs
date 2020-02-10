using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spd1
{
    class  Main
    {
        public List<Storage> storages = new List<Storage>();
        public List<Order> orders = new List<Order>();
        public List<Goods> goodss = new List<Goods>();
        List<Manager> managers = new List<Manager>();
        List<Driver> drivers = new List<Driver>();

        string name_driver;
        long time_driver;

        string name_manager;
        long time_manager;


        List<long> drivers_time = new List<long>();

        List<long> manager_time = new List<long>();

        //Main main = new Main();

        public void filling_list_drivers()
        {
            drivers.Add(new Driver ( "First", DateTimeOffset.UtcNow.ToUnixTimeSeconds(), 212 ));
            drivers.Add(new Driver ("Second", DateTimeOffset.UtcNow.ToUnixTimeSeconds(), 324 ));
        }

        public void filling_list_storages()
        {
            storages.Add(new Storage ("ATB", 10 ));
            storages.Add(new Storage ("Fora", 20 ));
            storages.Add(new Storage ( "Furshet", 32 ));
            storages.Add(new Storage ( "EcoMarket", 8 ));
            storages.Add(new Storage ( "Novus", 40 ));
        }

        public void filling_list_managers()
        {
            managers.Add(new Manager ( "First", DateTimeOffset.UtcNow.ToUnixTimeSeconds(), 500 ));
            managers.Add(new Manager ( "Second", DateTimeOffset.UtcNow.ToUnixTimeSeconds(), 200 ));
        }

        public void filling_list_goodss()
        {
            goodss.Add(new Goods ( "Milk", 5 ));
            goodss.Add(new Goods ( "Bread", 15 ));
        }


        public Tuple<string, long, long> availability_check_drivers()
        {
            foreach (Driver d in drivers) //наповнюється додатковий список, який потрібен для знаходження min значення
            {
                drivers_time.Add(d.TimeLeft);
            }

            long time_left = drivers_time.Min(); //знаходиться найменше значення

            foreach (Driver d in drivers) //знаходиться ім'я
            {
                if (time_left == d.TimeLeft)
                {
                    name_driver = d.Name;
                    time_driver = d.Time;

                    //додаємо час виконання
                    if (d.TimeLeft > DateTimeOffset.UtcNow.ToUnixTimeSeconds())
                    {
                        d.TimeLeft = d.TimeLeft + d.Time;
                    }
                    else
                    {
                        d.TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + d.Time;
                    }

                }
            }

            return Tuple.Create(name_driver, time_left, time_driver); //вертається 3 значення - ім'я та час, що залишився та час виконання
        }

        public void order(string name, int distance, long time_goods)
        {
            var manager_info = availability_check_managers();
            //string name_manager = manager_info.Item1;
            long time_left_manager = manager_info.Item2;
            long time_manager = manager_info.Item3;

            var driver_info = availability_check_drivers();
            //string name_driver = driver_info.Item1;
            long time_left_driver = driver_info.Item2;
            long time_driver = driver_info.Item3;


            //розрахунок часу
            if (time_left_manager < DateTimeOffset.UtcNow.ToUnixTimeSeconds())
            {
                time_left_manager = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            }
            if (time_left_driver < DateTimeOffset.UtcNow.ToUnixTimeSeconds())
            {
                time_left_driver = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            }

            long time_left = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + (time_left_driver - DateTimeOffset.UtcNow.ToUnixTimeSeconds() + time_driver) + (time_left_manager - DateTimeOffset.UtcNow.ToUnixTimeSeconds() + time_manager) + time_goods + distance / 60;

            orders.Add(new Order ( name,  time_left ));
        }

        public Tuple<string, long, long> availability_check_managers()
        {
            manager_time.Clear();


            foreach (Manager m in managers) //наповнюється додатковий список, який потрібен для знаходження min значення
            {
                manager_time.Add(m.TimeLeft);
            }


            long time_left = manager_time.Min(); //знаходиться найменше значення

            int a = manager_time.Count;

            foreach (Manager m in managers) //знаходиться ім'я
            {
                if (time_left == m.TimeLeft)
                {
                    name_manager = m.Name;
                    time_manager = m.Time;

                    //додаємо час виконання
                    if (m.TimeLeft > DateTimeOffset.UtcNow.ToUnixTimeSeconds())
                    {
                        m.TimeLeft = m.TimeLeft + m.Time;
                    }
                    else
                    {
                        m.TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + m.Time;
                    }
                }
            }

            return Tuple.Create(name_manager, time_left, time_manager); //вертається 3 значення - ім'я та час, що залишився та час виконання

        }
    }
}
