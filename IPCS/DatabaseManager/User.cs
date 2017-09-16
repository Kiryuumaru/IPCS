using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using IPCS.Data;

namespace IPCS.DatabaseManager
{
    [Serializable]
    public class User
    {

        #region Constructor

        public User(string username, string password, string recoveryKey, Image profilePic, Inventory data)
        {
            _Username = username;
            _Password = password;
            _RecoveryKey = recoveryKey;
            _Data = data;
            ProfilePic = profilePic;
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

        private string _Username;
        public string Username
        {
            get { return _Username; }
        }

        private string _Password;
        public bool CheckPassword(string password)
        {
            if (password.Equals(_Password)) return true;
            return false;
        }

        public string GetPassword(string recoveryKey)
        {
            if (recoveryKey.Equals(_RecoveryKey)) return _Password;
            return null;
        }

        private string _RecoveryKey;
        public string RecoveryKey(string password)
        {
            if (password.Equals(_Password)) return _RecoveryKey;
            return null;
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

        public Image ProfilePic { get; set; }

        public bool Online { get; set; }

        #endregion

    }
}
