﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<int> productsIndex = new List<int>();
        public Form1()
        {
            InitializeComponent();

            button3.Hide();

            while (panel1.Controls.Count > 0)
                foreach (Control c in panel1.Controls)
                {
                    //groupBox1.Controls.Remove(c);
                    panel1.Controls.Remove(c);
                }

            

            productsIndex.Clear();

            Random rand = new Random();

            foreach (Product p in Program.getProducts())
            {

                getNextPos(out int x, out int y);
                PictureBox pb = new PictureBox();
                pb.Load( "pictures\\" +   p.getPhotoName());
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Size = new Size(200, 100);
                    panel1.Controls.Add(pb);
                pb.Location = new Point(x, y);
                pb.Name = p.getName();

                pb.MouseClick += new MouseEventHandler(PageOpener);

                productsIndex.Add(Program.getProducts().IndexOf(p));

            }



            int pictureCount = Directory.GetFiles("ads").Length;
            int nr = rand.Next(0, pictureCount);
            AddPicture.Load("ads\\ad" + nr + ".jpg");


            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(TimeUp);
            myTimer.Interval = 10000; // change every 10s
            myTimer.Start();

        }

        public void TimeUp(object source, ElapsedEventArgs e)
        {
            Random rand = new Random();
            int pictureCount = Directory.GetFiles("ads").Length;
            int nr = rand.Next(0, pictureCount);
            AddPicture.Load("ads\\ad" + nr + ".jpg");
        }

        private void getNextPos(out int x, out int y)
        {
            int c = panel1.Controls.Count;

            int cc = c % 3;
            c = c / 3;

            x =  cc * 210;
            y =  c * 140;



        }

        public void ShowProducts()
        {
            string name = textBox3.Text.ToLower();

            int min_price, max_price;
            Int32.TryParse(textBox1.Text, out min_price);
            Int32.TryParse(textBox2.Text, out max_price);

            if (min_price < 0)
                min_price = 0;
            textBox1.Text = min_price.ToString();

            if (max_price < min_price)
                max_price = 0;

            if (max_price == 0)
                textBox2.Text = "";
            else
                textBox2.Text = max_price.ToString();


            double rating = 0;

            if (radioButton1.Checked)
                rating = 5;
            if (radioButton2.Checked)
                rating = 4;
            if (radioButton3.Checked)
                rating = 3;
            if (radioButton4.Checked)
                rating = 2;
            if (radioButton5.Checked)
                rating = 1;



            while (panel1.Controls.Count > 0)
                foreach (Control c in panel1.Controls)
                {
                    //groupBox1.Controls.Remove(c);
                    panel1.Controls.Remove(c);
                }



            productsIndex.Clear();

            Random rand = new Random();

            foreach (Product p in Program.getProducts())
            {
                if (!p.getName().ToLower().Contains(name))
                    continue;

                if (p.getPrice() < min_price ||
                     (max_price != 0 && p.getPrice() > max_price))
                    continue;

                if (p.getScore() < rating)
                    continue;

                if (checkBox1.Checked && p.getQuantity() == 0)
                    continue;

                getNextPos(out int x, out int y);
                PictureBox pb = new PictureBox();
                pb.Load("pictures\\" + p.getPhotoName());
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Size = new Size(200, 100);
                panel1.Controls.Add(pb);
                pb.Location = new Point(x, y);
                pb.Name = p.getName();

                pb.MouseClick += new MouseEventHandler(PageOpener);

                productsIndex.Add(Program.getProducts().IndexOf(p));

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ShowProducts();
        }


        private void PageOpener(object sender, MouseEventArgs e)
        {
            int i = 0;
            if (e.Button != MouseButtons.Left)
                return;

            foreach (Control c in panel1.Controls)
            {
                
                if (c.Equals(sender))
                {
                    Form2 f2 = new Form2(productsIndex.ElementAt(i));
                    f2.Show();
                }
                i++;
            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
            int a = -1;

            Int32.TryParse(textBox1.Text, out a);

            if (a < 0)
                a = 0;

            textBox2.Text = a.ToString();
        }

        public void SetUsername()
        {
            if (Program.getCurrentAccount() == null)
            {
                button3.Hide();
                button2.Show();

                textBox4.Text = "";
                textBox5.Text = "";
                AddPicture.Show();

            }
            else
            {
                button2.Hide();
                button3.Show();

                textBox4.Text = Program.getCurrentAccount().getName();
                textBox5.Text = Program.getCurrentAccount().getMoney().ToString();

                if(Program.getCurrentAccount().getPremium()==true)
                    AddPicture.Hide();
                else
                    AddPicture.Show(); ;

            }
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f3.Show();
            Program.f1.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Program.getCurrentAccount() != null)
            {
                Form5 f5 = new Form5();
                f5.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}