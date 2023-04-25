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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Account> accountsList = Program.getAccounts();

            string name = textBox1.Text;
            string pass = textBox2.Text;


            if (name.Length < 4 || name.Length > 10 ||
                pass.Length < 4 || pass.Length > 10)
            {
                if(name.Length<4)
                    textBox3.Text = "username too short";
                else
                {
                    if (name.Length >10)
                        textBox3.Text = "username too long";
                    else
                    {
                        if (pass.Length < 4)
                            textBox3.Text = "password too short";
                        else
                        {
                            textBox3.Text = "password too long";
                        }
                    }
                }
            }
            else
            { 
                bool ok = true;

                foreach(Account a in accountsList)
                {
                    if (a.getName().Equals(name))
                        ok = false;

                }

                Account acc = new Account(name, pass, false, false, 0);

                if (ok)
                {
                    Program.NewAccount(acc);
                    Program.WriteAccounts();
                    textBox3.Text = "";


                    Program.f3.Show();
                    Program.f4.Hide();

                }
                else
                    textBox3.Text = "username in use";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
