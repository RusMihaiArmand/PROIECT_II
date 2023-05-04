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
        private static Form1 f1;
        private static Form2 f2;
        private static FormLogIn fLogIn;
        private static FormSignUp fSignUp;
        private static FormControls fControls;
        private static FormEventControl fEventControl;

        private static string connectionString = "Data Source=.;Initial Catalog=STUD;Integrated Security=True";

        private static Account current_account = null;

        public static string getConString()
        {
            return connectionString;
        }


        public static void setForm1(Form1 f)
        {
            Program.f1 = f;
        }
        public static Form1 getForm1()
        {
            return Program.f1;
        }

        public static void setForm2(Form2 f)
        {
            Program.f2 = f;
        }
        public static Form2 getForm2()
        {
            return Program.f2;
        }


        public static FormLogIn getLogInForm()
        {
            return Program.fLogIn;
        }


        public static void setSignUpForm(FormSignUp f)
        {
            Program.fSignUp = f;
        }
        public static FormSignUp getSignUpForm()
        {
            return Program.fSignUp;
        }


        public static void setControlForm(FormControls f)
        {
            Program.fControls = f;
        }
        public static FormControls getControlForm()
        {
            return Program.fControls;
        }


        public static void setFormEventControl(FormEventControl f)
        {
            Program.fEventControl = f;
        }
        public static FormEventControl getFormEventControl()
        {
            return Program.fEventControl;
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

        

        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(fLogIn=new FormLogIn());
           

        }
    }
}
