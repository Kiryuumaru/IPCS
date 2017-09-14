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
            StyleManager = new MetroFramework.Components.MetroStyleManager();
        }

        public User(string username, string password, Inventory data)
        {
            _Username = username;
            _Password = password;
            _Data = data;
            StyleManager = new MetroFramework.Components.MetroStyleManager();
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
        public bool CheckPassword(string password)
        {
            if (password.Equals(_Password)) return true;
            return false;
        }

        private string _Username;
        public string Username
        {
            get { return _Username; }
        }

        public string _StyleManager;
        public MetroFramework.Components.MetroStyleManager StyleManager
        {
            get
            {
                return StyleMethods.ToManager(_StyleManager);
            }
            set
            {
                _StyleManager = StyleMethods.ToString(value);
            }
        }

        public bool Online { get; set; }

        #endregion
    }
}
