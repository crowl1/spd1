﻿using System;
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
        int distance;
        long time;

        public Form1()
        {
            InitializeComponent();
            Containers.main.filling_list();

            foreach (BusinessLayer.Storage s in Containers.main.storages)
            {
                comboBox_storage.Items.Add(s.Name);
            }
            foreach (BusinessLayer.Goods g in Containers.main.goodss)
            {
                comboBox_goods.Items.Add(g.Name);
            }
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            foreach (BusinessLayer.Storage s in Containers.main.storages)
            {
                if (comboBox_storage.Text == s.Name)
                {
                    distance = s.Distance;
                }
            }


            foreach (BusinessLayer.Goods g in Containers.main.goodss)
            {
                if (comboBox_goods.Text == g.Name)
                {
                    time = g.Time;
                }
            }


            Containers.main.order(textBox_name.Text, distance, time);
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = Containers.main.orders.Count;
            dataGridView1.ColumnCount = 2;


            //наповнення таблиці
            for (int i = 0; i < Containers.main.orders.Count ; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = Containers.main.orders[i].Name;
                    dataGridView1.Rows[i].Cells[1].Value = Convert.ToString(DateTimeOffset.FromUnixTimeSeconds(Containers.main.orders[i].TimeLeft));
                }
            }
        }
    }
    class Containers
    {
        public static BusinessLayer.IDelivery main { get; set; } = new BusinessLayer.Delivery();
    }
}
