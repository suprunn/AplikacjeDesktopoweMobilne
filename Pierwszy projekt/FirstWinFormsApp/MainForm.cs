using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {

            string strAge = textBoxWiek.Text;
            if ( string.IsNullOrWhiteSpace(strAge))
            {
                MessageBox.Show("Nie podano wieku");
                return;
            }
            int age;
            if(!int.TryParse(strAge, out age))
            {
                MessageBox.Show("Wiek nie jest liczbą");
                return;
            }
            if (age<1)
            {
                MessageBox.Show("Podano wiek ujemny");
                return;
            }
            string message = "";
            if (age>=18)
            {
                message = "Jesteś pełnoletni";
            }
            else
            {
                message = "Jesteś niepełnoletni";
            }

            message = "Witaj " +textBoxName.Text +textBoxSurname.Text + "w tym programie\n" + message;

            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
