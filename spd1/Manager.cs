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

        string name;
        long time;


        List<long> manager_time = new List<long>();


        public void filling_list_managers()
        {
            Main.managers.Add(new Manager { Name = "First", TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
            Main.managers.Add(new Manager { Name = "Second", TimeLeft = DateTimeOffset.UtcNow.ToUnixTimeSeconds() });
        }

        public Tuple<string, long, long> availability_check_drivers()
        {
            foreach (Manager m in Main.managers) //наповнюється список
            {
                manager_time.Add(m.TimeLeft);
            }

            long time_left = manager_time.Where(x => x % 2 == 0).Min(); //знаходиться найменше значення

            foreach (Manager m in Main.managers) //знаходиться ім'я
            {
                if (time_left == m.TimeLeft)
                {
                    name = m.Name;
                    time = m.Time;
                }
            }

            return Tuple.Create(name, time_left, time); //вертається 3 значення - ім'я та час, що залишився та час виконання

        }

}
