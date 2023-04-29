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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(textBox1.Text, out id);

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            pictureBox1.Image = null;

            foreach (Product p in Program.getProducts())
            {
                if(p.getCode() == id)
                {
                    textBox2.Text = p.getName();
                    textBox3.Text = p.getDescription();
                    textBox4.Text = p.getQuantity().ToString();
                    textBox5.Text = p.getScore().ToString();
                    textBox6.Text = p.getPrice().ToString();
                    textBox7.Text = p.getPhotoName();

                    pictureBox1.Load("pictures\\" + textBox7.Text);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(textBox1.Text, out id);

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            pictureBox1.Image = null;

            int i=-1;

            foreach (Product p in Program.getProducts())
            {
                if (p.getCode() == id)
                {
                    i = Program.getProducts().IndexOf(p);

                }

            }

            if(i!=-1)
            {
                Program.getProducts().RemoveAt(i);
                //Program.WriteProducts();
                Program.f1.ShowProducts();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(textBox1.Text, out id);

            string name = textBox2.Text;
            string desc = textBox3.Text;
            int quant;
            Int32.TryParse(textBox4.Text , out quant);
            if (quant < 0)
                quant = 0;
            textBox4.Text = quant.ToString();

            double score;
            Double.TryParse(textBox5.Text, out score);
            if (score < 0)
                score = 0;
            if (score > 5)
                score = 5;
            textBox5.Text = score.ToString();

            int price;
            Int32.TryParse(textBox6.Text, out price);
            if (price < 0)
                price = 0;
            textBox6.Text = price.ToString();


            string photo = textBox7.Text;

            try
            {
                pictureBox1.Load("pictures\\" + photo);
            }
            catch(Exception exc)
            {
                photo = "";
            }

            if (!photo.Equals(""))
            {

                int i = -1;

                foreach (Product p in Program.getProducts())
                {
                    if (p.getCode() == id)
                    {
                        i = Program.getProducts().IndexOf(p);

                    }

                }

                if (i != -1)
                {
                    Program.getProducts().ElementAt(i).setPrice(price);
                    Program.getProducts().ElementAt(i).setQuantity(quant);
                    Program.getProducts().ElementAt(i).setName(name);
                    Program.getProducts().ElementAt(i).setDescription(desc);
                    Program.getProducts().ElementAt(i).setScore(score);
                    Program.getProducts().ElementAt(i).setPhotoName(photo);


                    //Program.WriteProducts();
                    Program.f1.ShowProducts();

                }
                else
                {
                    Product pr = new Product(id, price, name, photo, quant, score, desc);
                    Program.getProducts().Add(pr);
                    //Program.WriteProducts();
                    Program.f1.ShowProducts();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
