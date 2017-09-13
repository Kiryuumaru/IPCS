using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPCS.Data;
using System.IO;

namespace IPCS.DatabaseManager
{
    public class TestDatabase
    {
        public TestDatabase()
        {
            FileInfo file = new FileInfo(FILEPATH);
            file.Directory.Create();
        }

        #region Properties

        private const string FILEDIR = "Data\\";
        private const string FILENAME = "IPCSData.txt";
        private const string FILEPATH = FILEDIR + FILENAME;

        #endregion

        public bool CreateUser(User user)
        {
            string serializedString = StringCipher.ObjectToString(user);
            try
            {
                string[] data = new string[4];
                data[0] = ">>STARTUSER";
                data[1] = user.Username;
                data[2] = serializedString;
                data[3] = ">>ENDUSER";
                NewData(data);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public User GetUser(string username, string password)
        {
            User user;
            try
            {
                string data = GetData(username, password);
                user = (User)StringCipher.StringToObject(data);
                user.Online = true;
            }
            catch (Exception)
            {
                user = new User(username, password);
                user.Online = false;
            }
            return user;
        }

        #region FileManager

        private const string STARTLINE = ">>START";
        private const string ENDLINE = ">>END";

        private void NewData(string[] data)
        {
            if (!File.Exists(FILEPATH))
            {
                TextWriter tw = new StreamWriter(FILEPATH);
                tw.WriteLine(STARTLINE + Environment.NewLine + ENDLINE);
                tw.Close();
            }
            if (data.Length == 0) return;
            string[] oldData = File.ReadAllLines(FILEPATH);
            oldData = oldData.Skip(Array.LastIndexOf(oldData, STARTLINE) + 1).Take(Array.IndexOf(oldData, ENDLINE) - 1).ToArray();
            oldData = oldData.Concat(data).ToArray();
            string[] newData = new string[oldData.Length + 2];
            Array.Copy(oldData, 0, newData, 1, oldData.Length);
            newData[0] = STARTLINE;
            newData[newData.Length - 1] = ENDLINE;
            File.WriteAllLines(FILEPATH, newData);
        }

        private string GetData(string username, string password)
        {
            string[] data = File.ReadAllLines(FILEPATH);
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(username)) return data[i + 1];
            }
            return null;
        }

        #endregion
    }
}
