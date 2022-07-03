using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Equipment_maintenance
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBD(); //загружаем БД
        }
        
        private void LoadBD() 
        {
            актВводаToolStripMenuItem.Enabled = false;
            актПриемапередачиToolStripMenuItem.Enabled = false;
            служебнаяЗапискаToolStripMenuItem.Enabled = false;
            актВыводаToolStripMenuItem.Enabled = false;
            актСписанияToolStripMenuItem.Enabled = false; //делаем недоступным создние документов
            
            //string conn_param = "Server=62.113.111.2;Port=5432;User Id=postgres;Password=g5jT*CwX;Database=devices;"; //строка подключения к БД
            if (Connection.Nickname == "purchasing") //и даем "права" на создание документов
            {
                актВводаToolStripMenuItem.Enabled = true;
            }
            else if(Connection.Nickname == "repair")
            {
                актПриемапередачиToolStripMenuItem.Enabled = true;
                служебнаяЗапискаToolStripMenuItem.Enabled = true;
            }
            else if (Connection.Nickname == "decommissing")
            {
                актВыводаToolStripMenuItem.Enabled = true;
                актСписанияToolStripMenuItem.Enabled = true;
            }
            NpgsqlConnection conn = new NpgsqlConnection(Connection.ConnParam());
            conn.Open(); //Открываем соединение
            try
            {
                NpgsqlCommand com = new NpgsqlCommand(@"select * from equipment", conn); //запрос - select
                DataTable dt = new DataTable(); 
                dt.Load(com.ExecuteReader()); //загружаем в dt вывод запроса
                
                conn.Close(); //Закрываем соединение
                string proverka;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    proverka = dt.Rows[i][1].ToString();
                    if (proverka == "1")
                    {
                        dt.Rows[i][1] = "Рабочее";
                    }
                    else if (proverka == "2")
                    {
                        dt.Rows[i][1] = "Сломано";
                    }
                    else if (proverka == "3")
                    {
                        dt.Rows[i][1] = "В ремонте";
                    }
                    else if (proverka == "4")
                    {
                        dt.Rows[i][1] = "В резерве";
                    }
                    else if (proverka == "5")
                    {
                        dt.Rows[i][1] = "Утилизировано";
                    }
                }


                dataGridView1.DataSource = null; //reset
                dataGridView1.DataSource = dt;
                
                
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.Show();
        }
        private void EquipmentDepartmentButton_Click(object sender, EventArgs e)
        {
            UserChoice UserChoice = new UserChoice("Введите название отдела");
            UserChoice.ShowDialog();
            DataTable dt;
            string select = "select O.Наименование from equipment as O inner join equipment_addresses as A on O.idАдреса = A.idАдреса and A.Отдел = '" + UserChoiceClass.Value + "'";
            dt = SelectDB(select);
            dataGridView1.DataSource = null; //reset
            dataGridView1.DataSource = dt;
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

        }

        private void актВыводаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void актСписанияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
