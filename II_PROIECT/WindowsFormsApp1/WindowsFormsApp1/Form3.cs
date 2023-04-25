using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Program.f1 = new Form1();
            Program.f4 = new Form4();

            Program.f1.Hide();
            Program.f4.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f4.Show();
            Program.f3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Account> accountsList = Program.getAccounts();

            string name = textBox1.Text;
            string pass = textBox2.Text;

            bool ok = false;

            foreach (Account a in accountsList)
            {
                if (a.getName().Equals(name) && a.getPass().Equals(pass))
                {
                    ok = true;
                    Program.SetCurrentAccount(a);
                }
            }

            if (!ok)
                textBox3.Text = "invalid";
            else
            {
                textBox3.Text = "";

                Program.f1.Show();
                Program.f3.Hide();


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
