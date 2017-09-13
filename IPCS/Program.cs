using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using IPCS.Forms;
using IPCS.DatabaseManager;

namespace IPCS
{
    public static class Program
    {
        #region Main Entury

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        #endregion

        #region Fields

        public static MetroFramework.Components.MetroStyleManager StyleManager {
            get { return StyleManager; }
            set
            {
                value.Owner = null;
                StyleManager = value;
            }
        }

        public static TestDatabase Database { get; set; }
        
        public static User User { get; set; }

        #endregion

        public static void InitializeServer()
        {
            StyleManager = new MetroFramework.Components.MetroStyleManager();
            Database = new TestDatabase();
        }

        public static bool Signup(string username, string password)
        {
            Data.Product prod = new Data.Product(0, "testName", 100, 99, 10);
            Data.Inventory inv = new Data.Inventory();
            inv.NewProduct(prod);
            User user = new User(username, password, inv);
            Database.CreateUser(user);
            return true;
        }

        public static bool Login(string username, string password)
        {
            User = Database.GetUser(username, password);
            return User.Online;
        }

        public static bool Logout()
        {
            User = null;
            return true;
        }

        public static void PrintDebug(string[] data)
        {
            string temp = "";
            for (int i = 0; data.Length > i; i++)
            {
                temp += data[i] + Environment.NewLine;
            }
            MessageBox.Show(temp);
        }

        public static void PrintDebug(string data)
        {
            MessageBox.Show(data);
        }
    }
}
