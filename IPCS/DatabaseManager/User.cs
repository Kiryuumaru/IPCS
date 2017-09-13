using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPCS.Data;

namespace IPCS.DatabaseManager 
{
    [Serializable]
    public class User
    {
        #region Constructor

        public User(string username, string password)
        {
            _Username = username;
            _Password = password;
            _Data = new Inventory();
            StyleManager = Program.StyleManager;
        }

        public User(string username, string password, Inventory data)
        {
            _Username = username;
            _Password = password;
            _Data = data;
        }

        #endregion

        #region Properties

        private Inventory _Data;
        public Inventory Data
        {
            get
            {
                return _Data;
            }
        }

        private string _Password;
        private string _Username;
        public string Username
        {
            get { return _Username; }
        }
        
        public bool Online { get; set; }

        public MetroFramework.Components.MetroStyleManager StyleManager { get; set; }

        #endregion
    }
}
