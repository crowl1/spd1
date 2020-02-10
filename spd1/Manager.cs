using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spd1
{
    class Manager
    {
        public string Name;
        public long TimeLeft;
        public long Time;

        /*
        string name_manager;
        long time_manager;


        List<long> manager_time = new List<long>();


        public void filling_list_managers()
        {
            Main.managers.Add(new Manager { Name = "First", TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds(), Time =  500 });
            Main.managers.Add(new Manager { Name = "Second", TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds(), Time = 200 });
        }

        public Tuple<string, long, long> availability_check_managers()
        {
            manager_time.Clear();


            foreach (Manager m in Main.managers) //наповнюється додатковий список, який потрібен для знаходження min значення
            {
                manager_time.Add(m.TimeLeft);
            }


            long time_left = manager_time.Min(); //знаходиться найменше значення

            int a = manager_time.Count;

            foreach (Manager m in Main.managers) //знаходиться ім'я
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
        */
    }

}
