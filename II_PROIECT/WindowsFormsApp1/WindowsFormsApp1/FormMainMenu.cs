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

          

            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Elapsed += new ElapsedEventHandler(ChangeAd);
            myTimer.Interval = 10000; // change every 10s
            myTimer.Start();

        }

        public void ChangeAd(object source, ElapsedEventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.GetConString());
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
            else
            {
                AddPicture.Load("adYou.jpg");
            }
            con.Close();

        }

        private void GetNextPos(out int x, out int y)
        {
            int c = panel1.Controls.Count;
            c = c/2;

            int cc = c % 3;
            c = c / 3;

            x =  cc * 300;
            y =  c * 280;

            y = y + 100;
        }

        public void ShowProducts()
        {
            panel1.Controls.Clear();
            productsIndex.Clear();

            SqlConnection con = new SqlConnection(Program.GetConString());

            string command = "select id,evName, img,  nrMaxPeople from SportEvents where evName like '%";
            command += textBoxName.Text + "%' and locat like '%";
            command += textBoxLocation.Text + "%' and price>= ";

            Double.TryParse(textBoxPriceMin.Text, out double min_price);
            Double.TryParse(textBoxPriceMax.Text, out double max_price);

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
                command += " and price <= " + max_price.ToString();

            

            if(!checkBoxDate.Checked)
            {
                DateTime dt = DateTime.Parse(dateTimePicker1.Text);
                command += "  and dateStart <= '" + dateTimePicker1.Text + "'";
                command += "  and dateEnd >= '" + dateTimePicker1.Text + "'";
            }


            Int32.TryParse(textBoxPlaces.Text, out int requestedPlaces);

            if (requestedPlaces < 0)
                requestedPlaces = 0;
            textBoxPlaces.Text = requestedPlaces.ToString();


            con.Open();
            SqlCommand com1 = new SqlCommand(command, con);
            SqlDataReader reader1 = com1.ExecuteReader();

            List<SportEvent> se = new List<SportEvent>();


            while (reader1.Read())
            {
                Int32.TryParse(reader1[0].ToString(), out int id);
                Int32.TryParse(reader1[3].ToString(), out int total);

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

                    GetNextPos(out int x, out int y);
                    PictureBox pb = new PictureBox() {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(280, 180),
                        Location = new Point(x + 20, y)

                    };

                    if (evt.getImg() == null)
                    {
                        pb.Image = null;
                        pb.Load("def.png");
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream( evt.getImg() );
                        pb.Image = Image.FromStream(ms);
                    }
                    panel1.Controls.Add(pb);

                    pb.MouseClick += new MouseEventHandler((s, e1) => OpenEventPage(s, e1, evt.getId()));


                    Label lb = new Label
                    {
                        Size = new Size(280, 70),
                        Text = evt.getName(),
                        Location = new Point(x+20, y + 200)
                    };
                    panel1.Controls.Add(lb);
                }
            }


            Label lb2 = new Label
            {
                Size = new Size(480, 70),
                Text = "AVAILABLE EVENTS",
                Location = new Point(280, 10),
                Font = new Font("Times New Roman", 32, FontStyle.Bold)
            };
            panel1.Controls.Add(lb2);

        }

        private void OpenEventPage(object sender, MouseEventArgs e, int id)
        {
            SqlConnection con = new SqlConnection(Program.GetConString());
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

                Double.TryParse(reader1["price"].ToString(), out double price);

                Int32.TryParse(reader1["nrMaxPeople"].ToString(), out int nrMax);

                Program.GetFormEventPage().Display( id, reader1["evName"].ToString(), reader1["descript"].ToString(),
                    price, reader1["dateStart"].ToString(), reader1["dateEnd"].ToString(),
                    reader1["locat"].ToString(), nrMax, taken, img, reader1["creator"].ToString());

                Program.GetFormEventPage().Show();
                Program.GetFormMainMenu().Hide();
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

            textBoxPlaces.Text = "";
            checkBoxDate.Checked = true;
            dateTimePicker1.Hide();
        }

        public void Updater()
        {
            if(Program.GetCurrentAccount() == null)
            {
                textBoxUsername.Text = "";
                textBoxMoney.Text = "";
            }
            else
            {
                textBoxUsername.Text = Program.GetCurrentAccount().GetName();
                textBoxMoney.Text = Program.GetCurrentAccount().GetMoney().ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
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
                    Program.GetFormEventPage().Show();
                }
                i++;
            }

        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            if (Program.GetCurrentAccount() != null)
            {
                Program.GetControlForm().Show();
                Program.GetFormMainMenu().Hide();
            }
        }

        public void PremiumCheck()
        {
            if (Program.GetCurrentAccount().GetPremium() || Program.GetCurrentAccount().GetAdmin())
                AddPicture.Hide();
            else
                AddPicture.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkBoxDate.Checked)
                dateTimePicker1.Show();
            else
                dateTimePicker1.Hide();
        }


    }
}
