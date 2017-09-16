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
        #region Constructor

        public TestDatabase()
        {
            FileInfo file = new FileInfo(FILEPATH);
            file.Directory.Create();
        }

        #endregion

        #region Properties

        private const string FILEPATH = FILEDIR + FILENAME;

        #endregion

        #region Threads

        public bool CreateUser(User user)
        {
            if (UserExist(user.Username)) return false;
            string serializedString = Extension.ObjectToString(user);
            try
            {
                string[] data = new string[2];
                data[0] = user.Username;
                data[1] = serializedString;
                NewData(data);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool UpdateUser(User user)
        {
            string serializedString = Extension.ObjectToString(user);
            try
            {
                string[] data = new string[2];
                data[0] = user.Username;
                data[1] = serializedString;
                UpdateData(user.Username, data);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public User GetUser(string username, string password)
        {
            if (!UserExist(username)) return null;
            string data = GetData(username);
            User user = (User)Extension.StringToObject(data);
            if (user == null) return null;
            if (!user.CheckPassword(password)) return null;
            return user;
        }

        #endregion

        #region FileManager

        private const string FILEDIR = "Data\\";
        private const string FILENAME = "IPCSData.bin";
        private const string STARTLINE = ">>START";
        private const string ENDLINE = ">>END";
        private const string USERSTARTLINE = ">>STARTUSER";
        private const string USERENDLINE = ">>ENDUSER";

        private void NewData(string[] data)
        {
            CreateSourceFile();
            if (data.Length == 0) return;
            string[] modData = new string[data.Length+2];
            Array.Copy(data, 0, modData, 1, data.Length);
            modData[0] = USERSTARTLINE;
            modData[modData.Length - 1] = USERENDLINE;
            string[] oldData = File.ReadAllLines(FILEPATH);
            oldData = Extension.SubArray(oldData, Array.IndexOf(oldData, STARTLINE)+1, Array.IndexOf(oldData, ENDLINE) - 1);
            oldData = oldData.Concat(modData).ToArray();
            string[] newData = new string[oldData.Length + 2];
            newData[0] = STARTLINE;
            newData[newData.Length - 1] = ENDLINE;
            Array.Copy(oldData, 0, newData, 1, oldData.Length);
            File.WriteAllLines(FILEPATH, newData);
        }

        private void UpdateData(string username, string[] data)
        {
            CreateSourceFile();
            if (data.Length == 0) return;
            string[] modData = new string[data.Length + 2];
            Array.Copy(data, 0, modData, 1, data.Length);
            modData[0] = USERSTARTLINE;
            modData[modData.Length - 1] = USERENDLINE;
            string[] oldData = File.ReadAllLines(FILEPATH);
            oldData = Extension.SubArray(oldData, Array.IndexOf(oldData, STARTLINE) + 1, Array.IndexOf(oldData, ENDLINE) - 1);
            string[] leftData = Extension.SubArray(oldData, 0, Array.IndexOf(oldData, username)-1);
            string[] severedData = Extension.SubArray(oldData, Array.IndexOf(oldData, username)+1);
            string[] rightData = Extension.SubArray(severedData, Array.IndexOf(severedData, USERENDLINE)+1);
            leftData = leftData.Concat(modData).ToArray();
            oldData = rightData.Concat(leftData).ToArray();
            string[] newData = new string[oldData.Length + 2];
            newData[0] = STARTLINE;
            newData[newData.Length - 1] = ENDLINE;
            Array.Copy(oldData, 0, newData, 1, oldData.Length);
            File.WriteAllLines(FILEPATH, newData);
        }

        private bool UserExist(string username)
        {
            CreateSourceFile();
            string[] data = File.ReadAllLines(FILEPATH);
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(username)) return true;
            }
            return false;
        }

        private string GetData(string username)
        {
            CreateSourceFile();
            string[] data = File.ReadAllLines(FILEPATH);
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(username)) return data[i + 1];
            }
            return null;
        }

        private void CreateSourceFile()
        {
            if (!File.Exists(FILEPATH))
            {
                TextWriter tw = new StreamWriter(FILEPATH);
                tw.WriteLine(STARTLINE + Environment.NewLine + ENDLINE);
                tw.Close();
            }
        }

        #endregion
    }
}
