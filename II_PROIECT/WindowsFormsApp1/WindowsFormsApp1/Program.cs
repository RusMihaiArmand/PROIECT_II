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
        private static FormMainMenu fMainMenu;
        private static FormEventPage fEventPage;
        private static FormLogIn fLogIn;
        private static FormSignUp fSignUp;
        private static FormControls fControls;
        private static FormEventControl fEventControl;
        private static FormAttending fAttend;
        private static FormAdv fAdv;

        // private static string connectionString = "Data Source=.;Initial Catalog=STUD;Integrated Security=True";
        // DESKTOP-A5P03KC

        //private static string connectionString = "Data Source=DESKTOP-A5P03KC;Initial Catalog=STUD;Integrated Security=True";

        //SQLstuff
        private static string connectionString = "Data Source=DESKTOP-A5P03KC;Initial Catalog=STUD;Persist Security Info=True;User ID=SQLstuff; Password=SQLstuff";


        private static Account current_account = null;

        public static string getConString()
        {
            return connectionString;
        }


        public static void setFormMainMenu(FormMainMenu f)
        {
            Program.fMainMenu = f;
        }
        public static FormMainMenu getFormMainMenu()
        {
            return Program.fMainMenu;
        }

        public static void setFormEventPage(FormEventPage f)
        {
            Program.fEventPage = f;
        }
        public static FormEventPage getFormEventPage()
        {
            return Program.fEventPage;
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

        public static void setFormAttend(FormAttending f)
        {
            Program.fAttend = f;
        }
        public static FormAttending getFormAttend()
        {
            return Program.fAttend;
        }


        public static void setFormAdvertisement(FormAdv f)
        {
            Program.fAdv = f;
        }
        public static FormAdv getFormAdvertisement()
        {
            return Program.fAdv;
        }



        public static Account getCurrentAccount()
        {
            return current_account;
        }
        public static void SetCurrentAccount(Account a)
        {
            current_account = a;
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
