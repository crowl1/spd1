using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public interface IDelivery
    {
        List<Storage> storages { get; set; }
        List<Order> orders { get; set; }
        List<Goods> goodss { get; set; }
        void filling_list();
        void order(string name, int distance, long time_goods);
    }

    class Containers
    {
        public static DataAccessLayer.IData main { get; set; } = new DataAccessLayer.Data();
    }

    public class Delivery : IDelivery
    {
        public List<Storage> storages { get; set; } = new List<Storage>();
        public List<Order> orders { get; set; } = new List<Order>();
        public List<Goods> goodss { get; set; } = new List<Goods>();
        List<Manager> managers = new List<Manager>();
        List<Driver> drivers = new List<Driver>();

        static void Main()
        {

        }

        public Delivery()
        {

        }

        public void filling_list()
        {
            //Containers.main.Dir();
            Containers.main.filling_list_drivers();
            Containers.main.filling_list_managers();
            Containers.main.filling_list_goodss();
            Containers.main.filling_list_storages();
            for (byte a = 0; a < Containers.main.drivers_data.Count; a++)
            {
                var k = Containers.main.drivers_data[a].Count;
                drivers.Add(new Driver(Containers.main.drivers_data[a][0], Convert.ToInt64(Containers.main.drivers_data[a][1]), Convert.ToInt64(Containers.main.drivers_data[a][2])));
            }
            for (byte b = 0; b < Containers.main.managers_data.Count; b++)
            {
                managers.Add(new Manager(Containers.main.managers_data[b][0], Convert.ToInt64(Containers.main.managers_data[b][1]), Convert.ToInt64(Containers.main.managers_data[b][2])));
            }
            for (byte c = 0; c < Containers.main.goodss_data.Count; c++)
            {
                goodss.Add(new Goods(Containers.main.goodss_data[c][0], Convert.ToInt64(Containers.main.goodss_data[c][1])));
            }
            for (byte d = 0; d < Containers.main.storages_data.Count; d++)
            {
                storages.Add(new Storage(Containers.main.storages_data[d][0], Convert.ToInt32(Containers.main.storages_data[d][1])));
            }
        }

        string name_driver;
        long time_driver;

        string name_manager;
        long time_manager;


        List<long> drivers_time = new List<long>();

        List<long> manager_time = new List<long>();

        private Tuple<string, long, long> availability_check_drivers()
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



        private Tuple<string, long, long> availability_check_managers()
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

        public void order(string name, int distance, long time_goods)
        {
            var manager_info = availability_check_managers();
            long time_left_manager = manager_info.Item2;
            long time_manager = manager_info.Item3;

            var driver_info = availability_check_drivers();

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

            orders.Add(new Order(name, time_left));
        }
    }   
}
