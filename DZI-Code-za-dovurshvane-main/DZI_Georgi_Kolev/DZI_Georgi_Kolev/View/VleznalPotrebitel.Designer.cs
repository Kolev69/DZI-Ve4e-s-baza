﻿namespace DZI_Georgi_Kolev
{
    partial class VleznalPotrebitel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dZI_Georgi_12ADataSet = new DZI_Georgi_Kolev.DZI_Georgi_12ADataSet();
            this.potrebitelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.potrebitelTableAdapter = new DZI_Georgi_Kolev.DZI_Georgi_12ADataSetTableAdapters.potrebitelTableAdapter();
            this.имеИФамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерНаПоръчкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.мястоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бройПосетителиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видМасаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.роляНаПотребителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паролаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dZI_Georgi_12ADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrebitelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Влезнал потребител";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вид маса";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Брой посетители";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Място";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер на поръчка";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име и фамилия";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(303, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавяне";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(412, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "Изпращане на поръчка";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(683, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Изтриване";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(574, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 55);
            this.button5.TabIndex = 6;
            this.button5.Text = "Затваряне";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.имеИФамилияDataGridViewTextBoxColumn,
            this.номерНаПоръчкаDataGridViewTextBoxColumn,
            this.мястоDataGridViewTextBoxColumn,
            this.бройПосетителиDataGridViewTextBoxColumn,
            this.видМасаDataGridViewTextBoxColumn,
            this.роляНаПотребителяDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.паролаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.potrebitelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(303, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // dZI_Georgi_12ADataSet
            // 
            this.dZI_Georgi_12ADataSet.DataSetName = "DZI_Georgi_12ADataSet";
            this.dZI_Georgi_12ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // potrebitelBindingSource
            // 
            this.potrebitelBindingSource.DataMember = "potrebitel";
            this.potrebitelBindingSource.DataSource = this.dZI_Georgi_12ADataSet;
            // 
            // potrebitelTableAdapter
            // 
            this.potrebitelTableAdapter.ClearBeforeFill = true;
            // 
            // имеИФамилияDataGridViewTextBoxColumn
            // 
            this.имеИФамилияDataGridViewTextBoxColumn.DataPropertyName = "Име  и фамилия";
            this.имеИФамилияDataGridViewTextBoxColumn.HeaderText = "Име  и фамилия";
            this.имеИФамилияDataGridViewTextBoxColumn.Name = "имеИФамилияDataGridViewTextBoxColumn";
            // 
            // номерНаПоръчкаDataGridViewTextBoxColumn
            // 
            this.номерНаПоръчкаDataGridViewTextBoxColumn.DataPropertyName = "Номер на поръчка";
            this.номерНаПоръчкаDataGridViewTextBoxColumn.HeaderText = "Номер на поръчка";
            this.номерНаПоръчкаDataGridViewTextBoxColumn.Name = "номерНаПоръчкаDataGridViewTextBoxColumn";
            // 
            // мястоDataGridViewTextBoxColumn
            // 
            this.мястоDataGridViewTextBoxColumn.DataPropertyName = "Място";
            this.мястоDataGridViewTextBoxColumn.HeaderText = "Място";
            this.мястоDataGridViewTextBoxColumn.Name = "мястоDataGridViewTextBoxColumn";
            // 
            // бройПосетителиDataGridViewTextBoxColumn
            // 
            this.бройПосетителиDataGridViewTextBoxColumn.DataPropertyName = "Брой посетители";
            this.бройПосетителиDataGridViewTextBoxColumn.HeaderText = "Брой посетители";
            this.бройПосетителиDataGridViewTextBoxColumn.Name = "бройПосетителиDataGridViewTextBoxColumn";
            // 
            // видМасаDataGridViewTextBoxColumn
            // 
            this.видМасаDataGridViewTextBoxColumn.DataPropertyName = "Вид маса";
            this.видМасаDataGridViewTextBoxColumn.HeaderText = "Вид маса";
            this.видМасаDataGridViewTextBoxColumn.Name = "видМасаDataGridViewTextBoxColumn";
            // 
            // роляНаПотребителяDataGridViewTextBoxColumn
            // 
            this.роляНаПотребителяDataGridViewTextBoxColumn.DataPropertyName = "Роля на потребителя";
            this.роляНаПотребителяDataGridViewTextBoxColumn.HeaderText = "Роля на потребителя";
            this.роляНаПотребителяDataGridViewTextBoxColumn.Name = "роляНаПотребителяDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // паролаDataGridViewTextBoxColumn
            // 
            this.паролаDataGridViewTextBoxColumn.DataPropertyName = "Парола";
            this.паролаDataGridViewTextBoxColumn.HeaderText = "Парола";
            this.паролаDataGridViewTextBoxColumn.Name = "паролаDataGridViewTextBoxColumn";
            // 
            // VleznalPotrebitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "VleznalPotrebitel";
            this.Text = "VleznalPotrebitel";
            this.Load += new System.EventHandler(this.VleznalPotrebitel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dZI_Georgi_12ADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrebitelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DZI_Georgi_12ADataSet dZI_Georgi_12ADataSet;
        private System.Windows.Forms.BindingSource potrebitelBindingSource;
        private DZI_Georgi_12ADataSetTableAdapters.potrebitelTableAdapter potrebitelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn имеИФамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерНаПоръчкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn мястоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бройПосетителиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видМасаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn роляНаПотребителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паролаDataGridViewTextBoxColumn;
    }
}