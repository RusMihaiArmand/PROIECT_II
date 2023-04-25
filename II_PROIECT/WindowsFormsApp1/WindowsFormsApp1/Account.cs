using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Account
    {
        private string name;
        private string pass;
        private bool isAdmin;
        private bool hasPremium;
        private int money;

        public Account(string n, string p, bool adm, bool prem, int mone)
        {
            this.name = n;
            this.pass = p;
            this.isAdmin = adm;
            this.hasPremium = (prem || adm);
            this.money = mone;

        }

        public int getMoney()
        {
            return this.money;
        }
        public void setMoney(int n)
        {
            this.money = n;
        }
        public void addMoney(int n)
        {
            this.money = this.money + n;
        }


        public string getName()
        {
            return this.name;
        }
        public void setName(string n)
        {
            this.name = n;
        }


        public string getPass()
        {
            return this.pass;
        }
        public void setPass(string n)
        {
            this.pass = n;
        }

        public bool getPremium()
        {
            return this.hasPremium;
        }
        public void setPremium(bool p)
        {
            this.hasPremium = p;
        }


        public bool getAdmin()
        {
            return this.isAdmin;
        }
        public void setAdmin(bool p)
        {
            this.isAdmin = p;
        }


        override
        public string ToString()
        {
            return this.name + "," + this.pass + "," + this.isAdmin.ToString() + "," +
                this.hasPremium.ToString() + "," + this.money.ToString();

        }


    }
}
