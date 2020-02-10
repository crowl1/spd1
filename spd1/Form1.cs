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

        int distance;
        long time;

        public Form1()
        {
            InitializeComponent();
            main.filling_list_storages();
            main.filling_list_goodss();
            main.filling_list_managers();
            main.filling_list_drivers();

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


            main.order(textBox_name.Text, distance, time);
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = Main.orders.Count;
            dataGridView1.ColumnCount = 2;


            //наповнення таблиці
            for (int i = 0; i < Main.orders.Count ; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = Main.orders[i].Name;
                    dataGridView1.Rows[i].Cells[1].Value = Convert.ToString(DateTimeOffset.FromUnixTimeSeconds(Main.orders[i].TimeLeft));
                }
            }
        }
    }
}
