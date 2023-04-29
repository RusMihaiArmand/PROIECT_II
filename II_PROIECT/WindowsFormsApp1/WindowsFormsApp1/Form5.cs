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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            /*
            if (Program.getCurrentAccount() == null || Program.getCurrentAccount().getAdmin() == false)
                button5.Hide();
            else
                button5.Show();


            if (Program.getCurrentAccount() == null || Program.getCurrentAccount().getPremium() == true)
                button4.Hide();
            else
                button4.Show();
                */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.SetCurrentAccount(null);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.getCurrentAccount() == null)
                MessageBox.Show("You have to log in first", "Message");
            else
            {
                int s;
                Int32.TryParse(textBox1.Text, out s);

                if (s < 0)
                    s = 0;

                textBox1.Text = s.ToString();

                if(s>0)
                {
                    MessageBox.Show("Money added", "Message");
                    Program.getCurrentAccount().addMoney(s);

                    //Program.WriteAccounts();
                    Program.f1.SetUsername();

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Program.getCurrentAccount() != null)
            {
                /*
                if (Program.getCurrentAccount().getMoney() >= 50
                      && Program.getCurrentAccount().getPremium() == false)
                {
                    Program.getCurrentAccount().addMoney(-50);
                    //Program.getCurrentAccount().setPremium(true);
                    //Program.WriteAccounts();
                    Program.f1.SetUsername();

                    button4.Hide();


                }
                else
                    MessageBox.Show("Can't buy premium", "Message");
                    */
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
