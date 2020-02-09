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
        public long Time;

        string name;
        long time;


        List<long> drivers_time = new List<long>();


        public void filling_list_drivers()
        {
            Main.drivers.Add(new Driver { Name = "First", TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds(), Time = 212 });
            Main.drivers.Add(new Driver { Name = "Second", TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds(), Time = 324 });
        }

        public Tuple<string, long, long> availability_check_drivers()
        {
            foreach (Driver d in Main.drivers) //наповнюється додатковий список, який потрібен для знаходження min значення
            {
                drivers_time.Add(d.TimeLeft);
            }

            long time_left = drivers_time.Min(); //знаходиться найменше значення

            foreach (Driver d in Main.drivers) //знаходиться ім'я
            {
                if (time_left == d.TimeLeft)
                {
                    name = d.Name;
                    time = d.Time;

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

            return Tuple.Create(name, time_left, time); //вертається 3 значення - ім'я та час, що залишився та час виконання
        }
    }
}
