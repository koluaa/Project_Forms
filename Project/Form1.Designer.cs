namespace Project
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
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.passAddress = new System.Windows.Forms.TextBox();
            this.passReceivingDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passNumber = new System.Windows.Forms.MaskedTextBox();
            this.passSeries = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passFullName = new System.Windows.Forms.TextBox();
            this.passIss = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.licenseNumber = new System.Windows.Forms.MaskedTextBox();
            this.licenseReceivingDate = new System.Windows.Forms.DateTimePicker();
            this.licenseSeries = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView = new System.Windows.Forms.ListView();
            this.Номер = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Марка = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Длительность = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Стоимость = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.carModel = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.duration = new System.Windows.Forms.NumericUpDown();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.carNumber = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 407);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(150, 40);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load from xml";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(638, 407);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 40);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save to xml";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // passAddress
            // 
            this.passAddress.Location = new System.Drawing.Point(104, 195);
            this.passAddress.Multiline = true;
            this.passAddress.Name = "passAddress";
            this.passAddress.Size = new System.Drawing.Size(214, 66);
            this.passAddress.TabIndex = 3;
            // 
            // passReceivingDate
            // 
            this.passReceivingDate.Location = new System.Drawing.Point(104, 97);
            this.passReceivingDate.Name = "passReceivingDate";
            this.passReceivingDate.Size = new System.Drawing.Size(214, 20);
            this.passReceivingDate.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passNumber);
            this.groupBox1.Controls.Add(this.passSeries);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.passFullName);
            this.groupBox1.Controls.Add(this.passIss);
            this.groupBox1.Controls.Add(this.passAddress);
            this.groupBox1.Controls.Add(this.passReceivingDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 274);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Паспортные данные";
            // 
            // passNumber
            // 
            this.passNumber.Location = new System.Drawing.Point(104, 45);
            this.passNumber.Name = "passNumber";
            this.passNumber.Size = new System.Drawing.Size(100, 20);
            this.passNumber.TabIndex = 12;
            // 
            // passSeries
            // 
            this.passSeries.Location = new System.Drawing.Point(104, 19);
            this.passSeries.Name = "passSeries";
            this.passSeries.Size = new System.Drawing.Size(100, 20);
            this.passSeries.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кем выдан";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата выдачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Адрес прописки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Серия";
            // 
            // passFullName
            // 
            this.passFullName.Location = new System.Drawing.Point(104, 71);
            this.passFullName.Name = "passFullName";
            this.passFullName.Size = new System.Drawing.Size(214, 20);
            this.passFullName.TabIndex = 7;
            // 
            // passIss
            // 
            this.passIss.Location = new System.Drawing.Point(104, 123);
            this.passIss.Multiline = true;
            this.passIss.Name = "passIss";
            this.passIss.Size = new System.Drawing.Size(214, 66);
            this.passIss.TabIndex = 4;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "xml files|*.xml";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.licenseNumber);
            this.groupBox2.Controls.Add(this.licenseReceivingDate);
            this.groupBox2.Controls.Add(this.licenseSeries);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 111);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Водительское удостоверение";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Дата выдачи";
            // 
            // licenseNumber
            // 
            this.licenseNumber.Location = new System.Drawing.Point(104, 45);
            this.licenseNumber.Name = "licenseNumber";
            this.licenseNumber.Size = new System.Drawing.Size(100, 20);
            this.licenseNumber.TabIndex = 16;
            // 
            // licenseReceivingDate
            // 
            this.licenseReceivingDate.Location = new System.Drawing.Point(104, 71);
            this.licenseReceivingDate.Name = "licenseReceivingDate";
            this.licenseReceivingDate.Size = new System.Drawing.Size(214, 20);
            this.licenseReceivingDate.TabIndex = 13;
            // 
            // licenseSeries
            // 
            this.licenseSeries.Location = new System.Drawing.Point(104, 19);
            this.licenseSeries.Name = "licenseSeries";
            this.licenseSeries.Size = new System.Drawing.Size(100, 20);
            this.licenseSeries.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Серия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Номер";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView);
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Controls.Add(this.carModel);
            this.groupBox3.Controls.Add(this.price);
            this.groupBox3.Controls.Add(this.duration);
            this.groupBox3.Controls.Add(this.deleteButton);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.carNumber);
            this.groupBox3.Location = new System.Drawing.Point(347, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 389);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Транспортные средства";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Номер,
            this.Марка,
            this.Длительность,
            this.Стоимость});
            this.listView.Location = new System.Drawing.Point(6, 121);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(429, 228);
            this.listView.TabIndex = 23;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Номер
            // 
            this.Номер.Text = "Номер";
            this.Номер.Width = 86;
            // 
            // Марка
            // 
            this.Марка.Text = "Марка";
            this.Марка.Width = 150;
            // 
            // Длительность
            // 
            this.Длительность.DisplayIndex = 3;
            this.Длительность.Text = "Длительность";
            this.Длительность.Width = 85;
            // 
            // Стоимость
            // 
            this.Стоимость.DisplayIndex = 2;
            this.Стоимость.Text = "Стоимость";
            this.Стоимость.Width = 104;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(285, 355);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 28);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // carModel
            // 
            this.carModel.Location = new System.Drawing.Point(179, 43);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(256, 20);
            this.carModel.TabIndex = 13;
            // 
            // price
            // 
            this.price.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.price.Location = new System.Drawing.Point(179, 95);
            this.price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(256, 20);
            this.price.TabIndex = 21;
            this.price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(179, 69);
            this.duration.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.duration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(256, 20);
            this.duration.TabIndex = 20;
            this.duration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(6, 355);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 28);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Стоимость страховки за год";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Длительность страховки (лет)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Номер ТС";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Марка ТС";
            // 
            // carNumber
            // 
            this.carNumber.Location = new System.Drawing.Point(179, 17);
            this.carNumber.Name = "carNumber";
            this.carNumber.Size = new System.Drawing.Size(112, 20);
            this.carNumber.TabIndex = 14;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "xml files|*.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 456);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox passAddress;
        private System.Windows.Forms.DateTimePicker passReceivingDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passFullName;
        private System.Windows.Forms.TextBox passIss;
        private System.Windows.Forms.MaskedTextBox passNumber;
        private System.Windows.Forms.MaskedTextBox passSeries;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox licenseNumber;
        private System.Windows.Forms.DateTimePicker licenseReceivingDate;
        private System.Windows.Forms.MaskedTextBox licenseSeries;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox carNumber;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.NumericUpDown duration;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox carModel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Номер;
        private System.Windows.Forms.ColumnHeader Марка;
        private System.Windows.Forms.ColumnHeader Длительность;
        private System.Windows.Forms.ColumnHeader Стоимость;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

