using System;
using System.Collections.Generic;
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

        static void Main()
        {

        }

        public void filling_list_drivers()
        {
            drivers_data.Add(new List<string>() { "First", Convert.ToString(DateTimeOffset.UtcNow.ToUnixTimeSeconds()), "212" });
            drivers_data.Add(new List<string>() { "Second", Convert.ToString(DateTimeOffset.UtcNow.ToUnixTimeSeconds()), "324" });
        }

        public void filling_list_managers()
        {
            managers_data.Add(new List<string>() { "First", Convert.ToString(DateTimeOffset.UtcNow.ToUnixTimeSeconds()), "500" });
            managers_data.Add(new List<string>() { "First", Convert.ToString(DateTimeOffset.UtcNow.ToUnixTimeSeconds()), "200" });
        }

        public void filling_list_storages()
        {
            storages_data.Add(new List<string>() { "ATB", "10" });
            storages_data.Add(new List<string>() { "Fora", "20" });
        }

        public void filling_list_goodss()
        {
            goodss_data.Add(new List<string>() { "Milk", "5" });
            goodss_data.Add(new List<string>() { "Bread", "20" });
        }
    }
}
