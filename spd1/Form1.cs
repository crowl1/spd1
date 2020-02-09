using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spd1
{
    public partial class Form1 : Form
    {
        Main main = new Main();
        Storage storage = new Storage();
        Order order = new Order();
        Goods goods = new Goods();
        Manager manager = new Manager();
        Driver driver = new Driver();
        int distance;
        long time;

        public Form1()
        {
            InitializeComponent();
            storage.filling_list_storages();
            goods.filling_list_goodss();
            manager.filling_list_managers();
            driver.filling_list_drivers();

            foreach (Storage s in Main.storages)
            {
                comboBox_storage.Items.Add(s.Name);
            }
            foreach (Goods g in Main.goodss)
            {
                comboBox_goods.Items.Add(g.Name);
            }
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            foreach (Storage s in Main.storages)
            {
                if (comboBox_storage.Text == s.Name)
                {
                    distance = s.Distance;
                }
            }


            foreach (Goods g in Main.goodss)
            {
                if (comboBox_goods.Text == g.Name)
                {
                    time = g.Time;
                }
            }


            order.order(textBox_name.Text, distance, time);
        }
    }
}
