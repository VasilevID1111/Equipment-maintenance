﻿using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Equipment_maintenance
{

    public partial class Form1 : Form
    {

        public bool a = true;
        private DataTable dt_for_address_id_equipment = new DataTable(); //пипец костыль, для работы местоположения, сюда запишем idшники, по хорошему переделать заполнение таблицы на форме
        public Form1()
        {
            InitializeComponent();

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if(a)
                Environment.Exit(0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBD(); //загружаем БД
        }

        private void LoadBD() 
        {
            //menuStrip1.Visible = true;
            //актВводаToolStripMenuItem.Enabled = false;

            pictureBox3.Visible = true;
            актВводавэксплуатацию.Visible = false;
            актПриемапередачи.Visible = false;
            служебнаяЗаписка.Visible = false;
            актВывода.Visible = false;
            актСписания.Visible = false; //делаем недоступным создние документов
            отчетОРаботе.Visible = false;


            //актПриемапередачиToolStripMenuItem.Enabled = false;
            //служебнаяЗапискаToolStripMenuItem.Enabled = false;

            //string conn_param = "Server=62.113.111.2;Port=5432;User Id=postgres;Password=g5jT*CwX;Database=devices;"; //строка подключения к БД
            if (Connection.Nickname == "purchasing") //и даем "права" на создание документов
            {
                this.Text = "Ведение оборудования - Отдел закупок";
                актВводавэксплуатацию.Visible = true;
            }
            else if(Connection.Nickname == "repair")
            {
                this.Text = "Ведение оборудования - Отдел ремонта и обслуживания";
                актПриемапередачи.Visible = true;
                служебнаяЗаписка.Visible = true;
                отчетОРаботе.Visible = true;
            }
            else if (Connection.Nickname == "decommissing")
            {
                this.Text = "Ведение оборудования - Отдел вывода из эксплуатации";
                актВывода.Visible = true;
                актСписания.Visible = true;
            }
            else if (Connection.Nickname == "default_user")
            {
                this.Text = "Ведение оборудования - Обычный пользователь";
                toolStripMenuItem1.Visible = false;
                menuStrip1.Visible = false;
                pictureBox3.Visible = false;
            }
            NpgsqlConnection conn = new NpgsqlConnection(Connection.ConnParam());
            conn.Open(); //Открываем соединение
            try
            {
                NpgsqlCommand com;
                if (Connection.Nickname == "default_user")
                    com = new NpgsqlCommand(@"select idОборудования, Статус, ТипОборудования, Наименование, Пользователь, 'Корпус ' || A.Корпус || ', этаж ' ||  A.Этаж::text || ', комната ' || A.Комната::text as Адрес, Прочее, idКомпановки, Стоимость, ДопОборудование from equipment as O inner join equipment_addresses as A on O.idАдреса = A.idАдреса", conn); //запрос - select
                else if(Connection.Nickname == "repair")
                    com = new NpgsqlCommand(@"select idОборудования, Статус, ТипОборудования, Наименование, Пользователь, 'Корпус ' || A.Корпус || ', этаж ' ||  A.Этаж::text || ', комната ' || A.Комната::text as Адрес, Прочее, idКомпановки, Стоимость, ДопОборудование from equipment as O inner join equipment_addresses as A on O.idАдреса = A.idАдреса where Статус = 1::text or Статус = 2::text or Статус = 3::text", conn); //запрос - select
                else if(Connection.Nickname == "purchasing")
                    com = new NpgsqlCommand(@"select idОборудования, Статус, ТипОборудования, Наименование, Пользователь, 'Корпус ' || A.Корпус || ', этаж ' ||  A.Этаж::text || ', комната ' || A.Комната::text as Адрес, Прочее, idКомпановки, Стоимость, ДопОборудование from equipment as O inner join equipment_addresses as A on O.idАдреса = A.idАдреса where Статус = 3::text", conn); //запрос - select
                else
                    com = new NpgsqlCommand(@"select idОборудования, Статус, ТипОборудования, Наименование, Пользователь, 'Корпус ' || A.Корпус || ', этаж ' ||  A.Этаж::text || ', комната ' || A.Комната::text as Адрес, Прочее, idКомпановки, Стоимость, ДопОборудование from equipment as O inner join equipment_addresses as A on O.idАдреса = A.idАдреса where Статус = 3::text or Статус = 4::text", conn); //запрос - select

                DataTable dt = new DataTable(); 
                dt.Load(com.ExecuteReader()); //загружаем в dt вывод запроса
                
                conn.Close(); //Закрываем соединение
                string proverka;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    proverka = dt.Rows[i][1].ToString();
                    if (proverka == "1")
                    {
                        dt.Rows[i][1] = "В эксплуатации";
                    }
                    else if (proverka == "2")
                    {
                        dt.Rows[i][1] = "В ремонте";
                    }
                    else if (proverka == "3")
                    {
                        dt.Rows[i][1] = "В резерве";
                    }
                    else if (proverka == "4")
                    {
                        dt.Rows[i][1] = "Утилизировано";
                    }
                }

                dataGridView1.DataSource = null; //reset
                dataGridView1.DataSource = dt;

                conn.Open();
                com = new NpgsqlCommand(@"select idОборудования, idАдреса from equipment", conn);
                dt_for_address_id_equipment.Load(com.ExecuteReader());
                conn.Close();

            }
            catch(Exception ex)
            {
                conn.Close(); //Закрываем соединение
                MessageBox.Show("Error " + ex.Message);
            }  
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoadBD();
        }

        private void pictureBox5_Click(object sender, EventArgs e) //выход из аккаунта
        {
            a = false;
            this.Close();
            Form3 form3 = new Form3();
            form3.Show();
            a = true;
        }
        private void EquipmentDepartmentButton_Click(object sender, EventArgs e)
        {
            
        }

        private DataTable SelectDB(string select)
        {
            

            NpgsqlConnection conn = new NpgsqlConnection(Connection.ConnParam());
            conn.Open(); //Открываем соединение
            try
            {
                NpgsqlCommand com = new NpgsqlCommand(@select, conn); //запрос - select
                DataTable dt = new DataTable();
                dt.Load(com.ExecuteReader()); //загружаем в dt вывод запроса

                conn.Close(); //Закрываем соединение
                return dt;
            }
            catch (Exception ex)
            {
                conn.Close(); //Закрываем соединение
                MessageBox.Show("Error " + ex.Message);
                throw ex;
            }
        }
        private void актВводавэксплуатациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        
        private void актПриемапередачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void служебнаяЗапискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void актВыводаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void актСписанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void отчетОРаботеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {

        }

        private void оборудованиеВОтделеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserChoice UserChoice = new UserChoice("Введите название отдела");
            UserChoice.ShowDialog();
            
            if(UserChoiceClass.Value != null)
            {
                DataTable dt;
                string select = "select O.idОборудования, O.ТипОборудования, O.Наименование, O.Пользователь, MAX(Д.ДатаДвижения)  from equipment as O inner join equipment_addresses as A on O.idАдреса = A.idАдреса and A.Отдел = '" + UserChoiceClass.Value + "' inner join equipment_movements as Д on O.idОборудования = Д.idОборудования and O.Пользователь = Д.НовыйВладелец group by O.idОборудования, O.ТипОборудования, O.Наименование, O.Пользователь";
                dt = SelectDB(select);
                dataGridView1.DataSource = null; //reset
                dataGridView1.DataSource = dt;
            }
            UserChoiceClass.Value = null;


        }

        private void историяПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string FIO = dataGridView1[4, dataGridView1.SelectedRows[0].Index].Value.ToString();
                UserChoice UserChoice = new UserChoice("Введите ФИО пользователя", FIO);
                UserChoice.ShowDialog();
            }
            else
            {
                UserChoice UserChoice = new UserChoice("Введите ФИО пользователя");
                UserChoice.ShowDialog();
            }

            if (UserChoiceClass.Value != null)
            {
                DataTable dt;
                string select = "select О.idОборудования, О.ТипОборудования, О.Наименование, О.Стоимость, О.ДопОборудование, MAX(Д.ДатаДвижения) from equipment as О inner join equipment_movements as Д on О.idОборудования = Д.idОборудования where Д.НовыйВладелец = '" + UserChoiceClass.Value + "' group by О.idОборудования, О.ТипОборудования, О.Наименование, О.Пользователь, О.ДопОборудование";
                dt = SelectDB(select);
                dataGridView1.DataSource = null; //reset
                dataGridView1.DataSource = dt;
            }
            UserChoiceClass.Value = null;
        }

        private void датаВведенияВЭксплуатациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DataTable dt;
            string select = "select  O.idОборудования, O.Наименование, Д.ДатаДвижения from equipment as O inner join equipment_movements as Д on O.idОборудования = Д.idОборудования where Д.ТипДокумента = 'Ввод в эксплуатацию'";
            dt = SelectDB(select);
            dataGridView1.DataSource = null; //reset
            dataGridView1.DataSource = dt;
        }

        private void работыПоОборудованиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string idEquipment = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                UserChoice UserChoice = new UserChoice("Введите id оборудования", idEquipment);
                UserChoice.ShowDialog();
            } else
            {
                UserChoice UserChoice = new UserChoice("Введите id оборудования");
                UserChoice.ShowDialog();
            }
            if (UserChoiceClass.Value != null)
            {
                DataTable dt;
                string select = "select R.idОборудования, ТипРаботы, Причина, Описание, Д.ДатаДвижения from reports_works as R inner join equipment_movements as Д on R.idОборудования = Д.idОборудования where  ТипДокумента = 'Отчет о ремонте' and R.idОборудования = '" + UserChoiceClass.Value + "'";
                dt = SelectDB(select);
                dataGridView1.DataSource = null; //reset
                dataGridView1.DataSource = dt;
            }
            UserChoiceClass.Value = null;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e) //ввод в эксп
        {
            
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string note = dataGridView1[6, dataGridView1.SelectedRows[0].Index].Value.ToString();
                string idEquipment = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                string name = dataGridView1[3, dataGridView1.SelectedRows[0].Index].Value.ToString();
                string type = dataGridView1[2, dataGridView1.SelectedRows[0].Index].Value.ToString();
                string price = dataGridView1[8, dataGridView1.SelectedRows[0].Index].Value.ToString();
                //form2 = note;
                Form2.note = note;
                Form2.idEquipment = idEquipment;
                Form2.name = name;
                Form2.type = type;
                Form2.price = price;
            }
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e) //приема передачи
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string idEquipment = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                string dopEquipment = dataGridView1[9, dataGridView1.SelectedRows[0].Index].Value.ToString();

                Form4.idEquipment = idEquipment;
                Form4.dopEquipment = dopEquipment;
            }
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void актСписания_Click(object sender, EventArgs e) 
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string idEquipment = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();

                Form7.idEquipment = idEquipment;
            }
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }
    
        private void служебнаяЗаписка_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string idEquipment = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();

                Form5.idEquipment = idEquipment;
            }
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void актВывода_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string idEquipment = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();

                Form6.idEquipment = idEquipment;
            }
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void отчетОРаботе_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string idEquipment = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();

                Form8.idEquipment = idEquipment;
            }
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string idОборудования = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();

                DataTable dt;
                string select = "select idОборудования, НовыйВладелец, 'Корпус ' || A.Корпус || ', этаж ' ||  A.Этаж::text || ', комната ' || A.Комната::text as Адрес, ТипДокумента, ДатаДвижения from equipment_movements as Д inner join equipment_addresses as A on Д.НовыйАдрес = A.idАдреса where idОборудования = '" + idОборудования + "'";
                dt = SelectDB(select);
                dataGridView1.DataSource = null; //reset
                dataGridView1.DataSource = dt;
            } else
            {
                MessageBox.Show("Выделите интересующую строку!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string idАдреса = "1";
                //string idАдреса = dataGridView1[5, dataGridView1.SelectedRows[0].Index].Value.ToString();
                string idОборудования = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                
                foreach (DataRow row in dt_for_address_id_equipment.Rows)
                {
                    if (idОборудования == row[0].ToString())
                    {
                        idАдреса = row[1].ToString();
                        break;
                    }
                }

                DataTable dt;
                string select = "select O.idОборудования, O.Наименование, O.Пользователь, Ad.Отдел, Ad.Корпус, Ad.Этаж, Ad.Комната, Ad.Стол from equipment as O inner join equipment_addresses as Ad on Ad.idАдреса = O.idАдреса and O.idОборудования ='"+ idОборудования + "' where O.idАдреса = '" + idАдреса + "'";
                dt = SelectDB(select);
                dataGridView1.DataSource = null; //reset
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Выделите интересующую строку!");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
