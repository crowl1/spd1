using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Program
    {
        public List<List<string>> drivers_data = new List<List<string>>();
        public List<List<string>> managers_data = new List<List<string>>();
        public List<List<string>> storages_data = new List<List<string>>();
        public List<List<string>> goodss_data = new List<List<string>>();

        static void Main(){}

        public void filling_list_drivers()
        {
            var sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Data\\\\drivers.txt")); //читаємо файл
            string file_cont = sr.ReadToEnd(); //переводимо в string

            string[] lines = file_cont.Split(' '); //розбиваємо на об'єкти
            var a = lines.Count();
            for (int k = 0; k < lines.Length; k++)
            {
                string[] bit = lines[k].Split('_');
                drivers_data.Add(new List<string>() { bit[0], Convert.ToString(DateTimeOffset.UtcNow.ToUnixTimeSeconds()), bit[1] }); //додаємо дані в список
            }
        }

        public void filling_list_managers()
        {
            var sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Data\\\\managers.txt"));
            string file_cont = sr.ReadToEnd();

            string[] lines = file_cont.Split(' ');
            var a = lines.Count();
            for (int k = 0; k < lines.Length; k++)
            {
                string[] bit = lines[k].Split('_');
                managers_data.Add(new List<string>() { bit[0], Convert.ToString(DateTimeOffset.UtcNow.ToUnixTimeSeconds()), bit[1] });
            }
        }

        public void filling_list_storages()
        {
            var sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Data\\\\storages.txt"));
            string file_cont = sr.ReadToEnd();

            string[] lines = file_cont.Split(' ');
            var a = lines.Count();
            for (int k = 0; k < lines.Length; k++)
            {
                string[] bit = lines[k].Split('_');
                storages_data.Add(new List<string>() { bit[0], bit[1] });
            }
        }

        public void filling_list_goodss()
        {
            var sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Data\\\\goodss.txt"));
            string file_cont = sr.ReadToEnd();

            string[] lines = file_cont.Split(' ');

            for (int k = 0; k < lines.Length; k++)
            {
                string[] bit = lines[k].Split('_');
                goodss_data.Add(new List<string>() { bit[0], bit[1] });
            }
        }
    }
}
