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
    public partial class Form2 : Form
    {
        int index;
        public Form2()
        {
            int indx = 0;
            InitializeComponent();
            this.index = indx;

            //pictureBox1.Load( "pictures\\" +  Program.getProducts().ElementAt(indx).getPhotoName());

            //textBox1.Text = (Program.getProducts().ElementAt(indx).getName());
            //textBox2.Text = (Program.getProducts().ElementAt(indx).getDescription());

            //textBox3.Text = "rating " + (Program.getProducts().ElementAt(indx).getScore()) + " stars";

            //if ((Program.getProducts().ElementAt(indx).getQuantity()) == 0)
            //    textBox4.Text = "UNAVAILABLE";
            //else
            //    textBox4.Text = "IN STOCK";

            //textBox5.Text = (Program.getProducts().ElementAt(indx).getPrice()) + " $";


            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.getCurrentAccount() == null)
            {
                MessageBox.Show("You have to log in first", "Message");

                
            }
            else
            {

                //if ((Program.getProducts().ElementAt(index).getQuantity()) == 0)
                //{
                //    MessageBox.Show("Product not in stock right now :(", "Message");
                //}
                //else
                //{
                //    if (Program.getCurrentAccount().getMoney() >=
                //        Program.getProducts().ElementAt(index).getPrice())
                //    {
                //        MessageBox.Show("Bought :)", "Message");
                //        Program.getProducts().ElementAt(index).setQuantity(
                //            Program.getProducts().ElementAt(index).getQuantity() - 1);

                //        Program.getCurrentAccount().addMoney(-Program.getProducts().ElementAt(index).getPrice());
                //        //Program.WriteAccounts();

                //        Program.f1.SetUsername();

                //       // Program.WriteProducts();

                //    }
                //    else
                //    {
                //        MessageBox.Show("You're too poor to afford this :/", "Message");
                //    }


                //}


            }
        }
    }
}
