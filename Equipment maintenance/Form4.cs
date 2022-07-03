﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Equipment_maintenance
{
    public partial class Form4 : Form //акт приема передачи
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private Button button1;
        private TextBox textBox5;
        private Label label8;
        public List<string> act = new List<string>();
        public NpgsqlConnection conn = new NpgsqlConnection(Connection.ConnParam_Admin());
        //public NpgsqlConnection conn = new NpgsqlConnection("Server=62.113.111.2;Port=5432;User Id=postgres;Password=g5jT*CwX;Database=devices;"); //на сервере
        //public string conn_param = "Server=62.113.111.2;Port=5432;User Id=postgres;Password=g5jT*CwX;Database=devices;"; //строка подключения к БД
        public Form4()
        {
            InitializeComponent();
            conn.Open();
            //textBox3.Text = DateTime.Now.ToString();
            textBox1.Text = idDoc();
            
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание акта приема-передачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "idДокумента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заявитель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "idОборудования";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Получатель";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Описание";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 23);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 23);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 23);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(147, 168);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 23);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(147, 198);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(167, 23);
            this.textBox6.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Основание";
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(341, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            TextBox[] tbs = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            if (button1.Text == "Далее")
            {
                for (int i = 0; i < 6; i++)
                    act.Add(tbs[i].Text); //забираем ответы из формы

                for (int i = 0; i < 6; i++)
                    tbs[i].Text = "";
                
                button1.Text = "Создать";
                addressBD();
            }
            else
            {
                for (int i = 0; i < 6; i++)
                    act.Add(tbs[i].Text); //забираем ответы из формы
                insertBD(act); //добавляем данные в таблицы БД
                this.Hide();
                Form1 form1 = new Form1();
                form1.Enabled = true;
                
            }
        }
        private void insertBD(List<string> act)
        {
            //string conn_param = "Server=localhost;Port=5432;User Id=postgres;Password=*SCUOihj2;Database=Equipment_maintenance;"; //строка подключения к БД

            try
            {
                
                NpgsqlCommand com = new NpgsqlCommand($"insert into handover_acts values ({act[0]}, '{act[1]}', '{DateTime.Now.ToString()}', '{act[2]}', '{act[3]}', '{act[4]}', '{act[5]}', {act[6]})", conn); //insert-им акт передачи
                com.ExecuteNonQueryAsync(); //выполняем запрос

                //проверка на idАдреса 
                NpgsqlCommand com3 = new NpgsqlCommand($"select * from equipment_addresses ORDER BY idАдреса DESC LIMIT 1", conn); //insert-им адрес резерва
                DataTable dt = new DataTable();
                dt.Load(com3.ExecuteReader()); //загружаем в dt вывод запроса
                int numberID = Int32.Parse(dt.Rows[0].ItemArray[0].ToString());
                if(numberID == Int32.Parse(act[6]))
                {
                    numberID = 0; //ничего не делаем
                }
                else //добавляем новую запись
                {
                    NpgsqlCommand com1 = new NpgsqlCommand($"insert into equipment_addresses values ({act[6]}, '{act[7]}', {act[8]}, {act[9]}, {act[10]}, '{act[11]}')", conn); //insert-им новый адрес
                    com1.ExecuteNonQueryAsync(); //выполняем запрос
                }

                string idDvig = "";
                NpgsqlCommand com2 = new NpgsqlCommand($"SELECT idДвижения FROM equipment_movements ORDER BY idДвижения DESC LIMIT 1", conn); //выбор нового id для движения
                DataTable dt2 = new DataTable();
                dt.Load(com2.ExecuteReader()); //загружаем в dt вывод запроса
                if (dt.Rows.Count == 0) //если строк нет, создаем первый айди
                    idDvig = "1";
                else
                    idDvig = dt2.Rows[0].ItemArray[0].ToString();
                idDvig = (Int32.Parse(idDvig) + 1).ToString();
                NpgsqlCommand com4 = new NpgsqlCommand($"insert into equipment_movements values ({idDvig}, '{act[2]}', '{act[3]}', '{act[6]}', 'Акт приема-передачи', {act[0]}, '{DateTime.Now.ToString()}')", conn); //insert-им движение
                com4.ExecuteNonQueryAsync(); //выполняем запрос

                //и update оборудования
                NpgsqlCommand com5 = new NpgsqlCommand($"update equipment set idАдреса = {act[6]}, Статус = 1 where idОборудования = '{act[2]}'", conn); //insert-им движение
                com5.ExecuteNonQueryAsync(); //выполняем запрос

                MessageBox.Show("Успешно!");
            }
            catch (Exception ex)
            {
                conn.Close(); //Закрываем соединение
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private string idDoc() //берем id для нового документа (прибавляем 1 к старому)
        {
            conn.Open(); //Открываем соединение
            string idDoc = "";

            NpgsqlCommand com = new NpgsqlCommand($"SELECT NULLIF(idДокумента, '')::int FROM handover_acts ORDER BY NULLIF(idДокумента, '')::int DESC LIMIT 1", conn); 
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader()); //загружаем в dt вывод запроса
            if (dt.Rows.Count == 0) //если строк нет, создаем первый айди
                idDoc = "101";
            else
                idDoc = (Int32.Parse(dt.Rows[0].ItemArray[0].ToString()) + 1).ToString();
            conn.Close();
            return idDoc;
        }
        private void addressBD()
        {
            try
            {
                //TextBox[] tbs = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
                Label[] lbls = { label2, label3, label6, label7, label8, label9 };
                NpgsqlCommand com = new NpgsqlCommand($"select * from equipment_addresses ORDER BY idАдреса DESC LIMIT 1", conn); //insert-им адрес резерва
                DataTable dt = new DataTable();
                dt.Load(com.ExecuteReader()); //загружаем в dt вывод запроса
                for (int i = 0; i < 6; i++)
                {
                    lbls[i].Text = dt.Columns[i].ColumnName.ToString(); //меняем названия lablе-ов на те, что в таблице адресов
                    
                }
                if (dt.Rows.Count == 0) //если строк нет, создаем первый айди
                    textBox1.Text = "10";
                else
                {   
                    int numberID = Int32.Parse(dt.Rows[0].ItemArray[0].ToString());
                    textBox1.Text = (numberID + 1).ToString(); //подсказываем id, который уже есть
                }
            }
            catch (Exception ex)
            {
                conn.Close(); //Закрываем соединение
                MessageBox.Show("Error " + ex.Message);
            }

        }
        private void Form2_Load(object sender, System.EventArgs e)
        {

        }

    }
}