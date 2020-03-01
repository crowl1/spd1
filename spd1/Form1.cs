using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        BusinessLayer.IDelivery main = new BusinessLayer.Program();
    


        int distance;
        long time;

        public Form1()
        {
            InitializeComponent();
            main.filling_list();

            foreach (BusinessLayer.Storage s in main.storages)
            {
                comboBox_storage.Items.Add(s.Name);
            }
            foreach (BusinessLayer.Goods g in main.goodss)
            {
                comboBox_goods.Items.Add(g.Name);
            }
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            foreach (BusinessLayer.Storage s in main.storages)
            {
                if (comboBox_storage.Text == s.Name)
                {
                    distance = s.Distance;
                }
            }


            foreach (BusinessLayer.Goods g in main.goodss)
            {
                if (comboBox_goods.Text == g.Name)
                {
                    time = g.Time;
                }
            }


            main.order(textBox_name.Text, distance, time);
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = main.orders.Count;
            dataGridView1.ColumnCount = 2;


            //наповнення таблиці
            for (int i = 0; i < main.orders.Count ; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = main.orders[i].Name;
                    dataGridView1.Rows[i].Cells[1].Value = Convert.ToString(DateTimeOffset.FromUnixTimeSeconds(main.orders[i].TimeLeft));
                }
            }
        }
    }
}
