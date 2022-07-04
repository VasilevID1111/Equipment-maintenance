using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment_maintenance
{
    public partial class UserChoice : Form
    {
        public UserChoice(string text)
        {
            InitializeComponent();
            label1.Text = text; //присваиваем текст из предыдущей формы
            
        }

        public UserChoice(string text,string into)
        {
            InitializeComponent();
            label1.Text = text; //присваиваем текст из предыдущей формы
            textBox1.Text = into;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && textBox1.Text != null ) //если энтер и не пусто то выходим
            {
                UserChoiceClass.Value = textBox1.Text; //не забываем запомнить переменную
                this.Close();
            }

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
        }
    }
}
