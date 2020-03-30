using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IData
    {
        List<List<string>> drivers_data { get; set; }
        List<List<string>> managers_data { get; set; }
        List<List<string>> storages_data { get; set; }
        List<List<string>> goodss_data { get; set; }

        string Dir();

        void filling_list_drivers();
        void filling_list_managers();
        void filling_list_storages();
        void filling_list_goodss();

    }
    public class Data : IData
    {
        public List<List<string>> drivers_data { get; set; } = new List<List<string>>();
        public List<List<string>> managers_data { get; set; } = new List<List<string>>();
        public List<List<string>> storages_data { get; set; } = new List<List<string>>();
        public List<List<string>> goodss_data { get; set; } = new List<List<string>>();

        static void Main() { }

        public string Dir()
        {
            string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] BaseDirectory_list = BaseDirectory.Split('\\');
            string Directory = "";
            for(int a = 0; a < BaseDirectory_list.Count() - 4; a++)
            {
                Directory = Directory + BaseDirectory_list[a] + "\\";
            }
            Directory = Directory + "DataAccessLayer\\Data\\";
            return Directory;
        }

        public void filling_list_drivers()
        {
            var sr = new StreamReader(Path.Combine(Dir(), "..\\..\\DataAccessLayer\\Data\\\\drivers.txt")); //читаємо файл
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
            var sr = new StreamReader(Path.Combine(Dir(), "..\\..\\DataAccessLayer\\Data\\\\managers.txt"));
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
            var sr = new StreamReader(Path.Combine(Dir(), "..\\..\\DataAccessLayer\\Data\\\\storages.txt"));
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
            var sr = new StreamReader(Path.Combine(Dir(), "..\\..\\DataAccessLayer\\Data\\\\goodss.txt"));
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
