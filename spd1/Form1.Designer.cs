namespace spd1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_goods = new System.Windows.Forms.ComboBox();
            this.comboBox_storage = new System.Windows.Forms.ComboBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_order = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_goods
            // 
            this.comboBox_goods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_goods.FormattingEnabled = true;
            this.comboBox_goods.Location = new System.Drawing.Point(139, 40);
            this.comboBox_goods.Name = "comboBox_goods";
            this.comboBox_goods.Size = new System.Drawing.Size(121, 24);
            this.comboBox_goods.TabIndex = 0;
            // 
            // comboBox_storage
            // 
            this.comboBox_storage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_storage.FormattingEnabled = true;
            this.comboBox_storage.Location = new System.Drawing.Point(12, 40);
            this.comboBox_storage.Name = "comboBox_storage";
            this.comboBox_storage.Size = new System.Drawing.Size(121, 24);
            this.comboBox_storage.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(46, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(214, 22);
            this.textBox_name.TabIndex = 2;
            // 
            // button_order
            // 
            this.button_order.Location = new System.Drawing.Point(12, 70);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(248, 23);
            this.button_order.TabIndex = 3;
            this.button_order.Text = "Замовити";
            this.button_order.UseVisualStyleBackColor = true;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ім\'я";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 347);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.comboBox_storage);
            this.Controls.Add(this.comboBox_goods);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_goods;
        private System.Windows.Forms.ComboBox comboBox_storage;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

