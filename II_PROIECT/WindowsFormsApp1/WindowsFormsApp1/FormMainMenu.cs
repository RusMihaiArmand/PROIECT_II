using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class FormMainMenu : Form
    {
        private List<int> productsIndex = new List<int>();
        public FormMainMenu()
        {
            InitializeComponent();
            panel1.Controls.Clear();
            ShowProducts();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            //while (panel1.Controls.Count > 0)
            //    foreach (Control c in panel1.Controls)
            //    {
            //        //groupBox1.Controls.Remove(c);
            //        panel1.Controls.Remove(c);
            //    }


            //foreach (Product p in Program.getProducts())
            //{

            //    getNextPos(out int x, out int y);
            //    PictureBox pb = new PictureBox();
            //    pb.Load( "pictures\\" +   p.getPhotoName());
            //    pb.SizeMode = PictureBoxSizeMode.StretchImage;
            //    pb.Size = new Size(200, 100);
            //        panel1.Controls.Add(pb);
            //    pb.Location = new Point(x, y);
            //    pb.Name = p.getName();

            //    pb.MouseClick += new MouseEventHandler(PageOpener);

            //    //productsIndex.Add(Program.getProducts().IndexOf(p));

            //}


            Random rand = new Random();
            int pictureCount = Directory.GetFiles("ads").Length;
            int numbr = rand.Next(0, pictureCount);
            AddPicture.Load("ads\\ad" + numbr + ".jpg");


            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(TimeUp);
            myTimer.Interval = 10000; // change every 10s
            myTimer.Start();

        }

        public void TimeUp(object source, ElapsedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.getConString());
                con.Open();
                SqlCommand com1 = new SqlCommand("select top 1 img from Advertisements order by newid()", con);

                SqlDataReader reader1 = com1.ExecuteReader();

                if (reader1.Read())
                {
                    byte[] img;
                    img = (byte[])(reader1["img"]);

                    MemoryStream ms = new MemoryStream(img);
                    AddPicture.Image = Image.FromStream(ms);

                }


                    con.Close();

            }
            catch(Exception esc)
            { }
            //Random rand = new Random();
            //int pictureCount = Directory.GetFiles("ads").Length;
            //int nr = rand.Next(0, pictureCount);
            //AddPicture.Load("ads\\ad" + nr + ".jpg");
        }

        private void getNextPos(out int x, out int y)
        {
            int c = panel1.Controls.Count;
            c = c/2;

            int cc = c % 3;
            c = c / 3;

            x =  cc * 210;
            y =  c * 180;
           // y = c * 100;
        }

        public void ShowProducts()
        {
            panel1.Controls.Clear();
            productsIndex.Clear();

            SqlConnection con = new SqlConnection(Program.getConString());


            string command = "select id,evName, img,  nrMaxPeople from SportEvents where evName like '%";
            command += textBoxName.Text + "%' and locat like '%";
            command += textBoxLocation.Text + "%' and price>= ";

            double min_price, max_price;
            Double.TryParse(textBoxPriceMin.Text, out min_price);
            Double.TryParse(textBoxPriceMax.Text, out max_price);

            if (min_price < 0)
                min_price = 0;
            textBoxPriceMin.Text = min_price.ToString();

            if (max_price < min_price)
                max_price = 0;

            if (max_price == 0)
                textBoxPriceMax.Text = "";
            else
                textBoxPriceMax.Text = max_price.ToString();

            command += min_price.ToString();

            if(max_price > 0)
            {
                command += " and price <= " + max_price.ToString();

            }


            if(!checkBoxDate.Checked)
            {
                DateTime dt = DateTime.Parse(dateTimePicker1.Text);

                command += "  and dateStart <= '" + dateTimePicker1.Text + "'";
                command += "  and dateEnd >= '" + dateTimePicker1.Text + "'";
            }


            int requestedPlaces;
            Int32.TryParse(textBoxPlaces.Text, out requestedPlaces);

            if (requestedPlaces < 0)
                requestedPlaces = 0;
            textBoxPlaces.Text = requestedPlaces.ToString();


            con.Open();
            SqlCommand com1 = new SqlCommand(command, con);
            SqlDataReader reader1 = com1.ExecuteReader();


            List<SportEvent> se = new List<SportEvent>();



            while (reader1.Read())
            {
                int id, total;
                Int32.TryParse(reader1[0].ToString(), out id);
                Int32.TryParse(reader1[3].ToString(), out total);

                byte[] img;
                if (reader1[2] == DBNull.Value)
                    img = null;
                else
                    img = (byte[])(reader1[2]);

                SportEvent even = new SportEvent(id, reader1[1].ToString(), img, total);
                se.Add(even);
            }

            con.Close();

            foreach(SportEvent evt in se)
            {
                con.Open();

                com1 = new SqlCommand("select count(*) from Attending where idEvent=@ide", con);
                com1.Parameters.AddWithValue("ide", evt.getId());

                reader1 = com1.ExecuteReader();

                int takenPlaces=0;

                if(reader1.Read())
                    Int32.TryParse(reader1[0].ToString(), out takenPlaces);

                con.Close();

                if(evt.getPlaces()-takenPlaces>= requestedPlaces  || evt.getPlaces()==0)
                {

                    getNextPos(out int x, out int y);
                    PictureBox pb = new PictureBox();

                    if (evt.getImg() == null)
                    {
                        pb.Image = null;
                        pb.Load("logo.png");
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream( evt.getImg() );
                        pb.Image = Image.FromStream(ms);
                    }

                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Size = new Size(200, 100);
                    panel1.Controls.Add(pb);
                    pb.Location = new Point(x, y);

                    pb.MouseClick += new MouseEventHandler((s, e1) => OpenEventPage(s, e1, evt.getId()));


                    Label lb = new Label();
                    lb.Size = new Size(200, 70);
                    panel1.Controls.Add(lb);
                    lb.Text = evt.getName();
                    lb.Location = new Point(x, y + 110);


                }

            }

        }

        private void OpenEventPage(object sender, MouseEventArgs e, int id)
        {
            SqlConnection con = new SqlConnection(Program.getConString());
            con.Open();
            SqlCommand com1;

            int taken = 0;
            com1 = new SqlCommand("select count(*) from Attending where idEvent=@ide", con);
            com1.Parameters.AddWithValue("ide", id);

            SqlDataReader reader2 = com1.ExecuteReader();

            if (reader2.Read())
                Int32.TryParse(reader2[0].ToString(), out taken);


            con.Close();
            con.Open();


            com1 = new SqlCommand("select * from SportEvents where id=@id", con);
            com1.Parameters.AddWithValue("id", id);

            SqlDataReader reader1 = com1.ExecuteReader();

            if(reader1.Read())
            {
                byte[] img;
                if (reader1["img"] == DBNull.Value)
                    img = null;
                else
                    img = (byte[])(reader1["img"]);

                double price;
                Double.TryParse(reader1["price"].ToString(), out price);

                int nrMax;
                Int32.TryParse(reader1["nrMaxPeople"].ToString(), out nrMax);

                Program.getFormEventPage().Display( id, reader1["evName"].ToString(), reader1["descript"].ToString(),
                    price, reader1["dateStart"].ToString(), reader1["dateEnd"].ToString(),
                    reader1["locat"].ToString(), nrMax, taken, img, reader1["creator"].ToString());

                Program.getFormEventPage().Show();
                Program.getFormMainMenu().Hide();
            }
            else
            {
                MessageBox.Show("Error; event no longer available", "Message");

            }

            con.Close();

        }

        public void Clear()
        {
            textBoxName.Text = "";
            textBoxLocation.Text = "";
            textBoxPriceMin.Text = "";
            textBoxPriceMax.Text = "";

        }

        public void Updater()
        {
            if(Program.getCurrentAccount() == null)
            {
                textBoxUsername.Text = "";
                textBoxMoney.Text = "";
            }
            else
            {
                textBoxUsername.Text = Program.getCurrentAccount().getName();
                textBoxMoney.Text = Program.getCurrentAccount().getMoney().ToString();
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
                    Program.getFormEventPage().Show();
                }
                i++;
            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
            int a = -1;

            Int32.TryParse(textBoxPriceMin.Text, out a);

            if (a < 0)
                a = 0;

            textBoxPriceMax.Text = a.ToString();
        }


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.getLogInForm().Show();
            Program.getFormMainMenu().Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (Program.getCurrentAccount() != null)
            {
                Program.getControlForm().Show();
                Program.getFormMainMenu().Hide();
            }
        }

        public void PremiumCheck()
        {
            if (Program.getCurrentAccount().getPremium() || Program.getCurrentAccount().getAdmin())
                AddPicture.Hide();
            else
                AddPicture.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkBoxDate.Checked)
                dateTimePicker1.Show();
            else
                dateTimePicker1.Hide();
        }
    }
}
