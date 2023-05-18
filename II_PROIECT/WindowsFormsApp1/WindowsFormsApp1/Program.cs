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


        //cS - Mihai
        private static readonly string connectionString = "Data Source=DESKTOP-A5P03KC;Initial Catalog=STUD;Persist Security Info=True;User ID=SQLstuff; Password=SQLstuff";

        //cS - Teo
        //private static readonly string connectionString = "Data Source=DESKTOP-EJKPAGS\\MYSQL;Initial Catalog = STUD; Integrated Security = True";

        //a se selecta/pune connectionString-ul bun inainte de rulare; Semnat, M

        private static Account current_account = null;

        public static string GetConString()
        {
            return connectionString;
        }


        public static void SetFormMainMenu(FormMainMenu f)
        {
            Program.fMainMenu = f;
        }
        public static FormMainMenu GetFormMainMenu()
        {
            return Program.fMainMenu;
        }

        public static void SetFormEventPage(FormEventPage f)
        {
            Program.fEventPage = f;
        }
        public static FormEventPage GetFormEventPage()
        {
            return Program.fEventPage;
        }

        public static FormLogIn GetLogInForm()
        {
            return Program.fLogIn;
        }

        public static void SetSignUpForm(FormSignUp f)
        {
            Program.fSignUp = f;
        }
        public static FormSignUp GetSignUpForm()
        {
            return Program.fSignUp;
        }


        public static void SetControlForm(FormControls f)
        {
            Program.fControls = f;
        }
        public static FormControls GetControlForm()
        {
            return Program.fControls;
        }

        public static void SetFormEventControl(FormEventControl f)
        {
            Program.fEventControl = f;
        }
        public static FormEventControl GetFormEventControl()
        {
            return Program.fEventControl;
        }

        public static void SetFormAttend(FormAttending f)
        {
            Program.fAttend = f;
        }
        public static FormAttending GetFormAttend()
        {
            return Program.fAttend;
        }

        public static void SetFormAdvertisement(FormAdv f)
        {
            Program.fAdv = f;
        }
        public static FormAdv GetFormAdvertisement()
        {
            return Program.fAdv;
        }

        public static Account GetCurrentAccount()
        {
            return current_account;
        }
        public static void SetCurrentAccount(Account a)
        {
            current_account = a;
        }

        public static void UpdaterAll()
        {
            fAdv.Updater();
            fAttend.Updater();
            fControls.Updater();
            fEventControl.Updater();
            fEventPage.Updater();
            fMainMenu.Updater();

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
