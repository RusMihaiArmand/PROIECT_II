using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    static class Program
    {
        public static Form1 f1;
        public static Form3 f3;
        public static Form4 f4;

        private static List<Product> products = new List<Product>();
        private static List<Account> accounts = new List<Account>();
        private static Account current_account = null;

        public static List<Product> getProducts()
        {
            return products;
        }
        public static List<Account> getAccounts()
        {
            return accounts;
        }
        public static Account getCurrentAccount()
        {
            return current_account;
        }
        public static void SetCurrentAccount(Account a)
        {
            current_account = a;

            f1.SetUsername();
        }


        private static void LoadProducts()
        {
            products.Clear();
            StreamReader str = new StreamReader("PRODUCTS.txt");
            string info;

            while (str.Peek() != -1)
            {
                info = str.ReadLine();
                string[] data = info.Split(',');

                if (data.Length != 7)
                    continue;

                int code;
                Int32.TryParse(data[0], out code);

                bool ok = true ;
                if (code <= 0)
                    continue;

                foreach (Product pr in products)
                    if (pr.getCode() == code)
                        ok = false;

                if (!ok)
                    continue;

                Product p = new Product();
                p.setCode(code);

                Int32.TryParse(data[1], out code);
                if (code <= 0)
                    continue;
                p.setPrice(code);
                p.setName(data[2]);
                p.setPhotoName(data[3]);

                Int32.TryParse(data[4], out code);
                if (code < 0)
                    continue;
                p.setQuantity(code);

                double score;
                Double.TryParse(data[5], out score);
                if (score < 0 || score>5)
                    continue;
                p.setScore(score);


                p.setDescription(data[6]);

                products.Add(p);

            }

            str.Close();


            WriteProducts();

        }

        private static void LoadAccounts()
        {
            accounts.Clear();
            StreamReader str = new StreamReader("ACCOUNTS.txt");
            string info;

            while (str.Peek() != -1)
            {
                info = str.ReadLine();
                string[] data = info.Split(',');

                if (data.Length != 5)
                    continue;



                bool ok = true;
                foreach (Account ac in accounts)
                    if (ac.getName().Equals(data[0]))
                        ok = false;

                if (!ok)
                    continue;

                bool a, p;

                if (data[2].Equals("True"))
                    a = true;
                else
                    a = false;

                if (data[3].Equals("True"))
                    p = true;
                else
                    p = false;

                int m;

                Int32.TryParse(data[4], out m);

                if (m < 0)
                    continue;


                Account acc = new Account(data[0], data[1], a, p, m);

                accounts.Add(acc);

            }

            str.Close();

        }

        public static void WriteProducts()
        {
            StreamWriter str = new StreamWriter("PRODUCTS.txt");

            foreach (Product p in products)
                str.WriteLine(p.ToString());

            str.Close();

        }

        public static void WriteAccounts()
        {
            StreamWriter str = new StreamWriter("ACCOUNTS.txt");

            foreach (Account a in accounts)
                str.WriteLine(a.ToString());

            str.Close();

        }

        public static void NewAccount(Account a)
        {
            accounts.Add(a);
        }

        [STAThread]
        static void Main()
        {
            LoadProducts();
            WriteProducts();

            LoadAccounts();
            WriteAccounts();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(f3=new Form3());

            


        }
    }
}
