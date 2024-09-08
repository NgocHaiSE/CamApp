using DevExpress.Xpo.Helpers;
using DXApplication1.Entity;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DXApplication1.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return UserDAO.instance; }
            private set => UserDAO.instance = value;
        }
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string query = "CALL GetAllUsers()";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string username = row["Tài khoản"].ToString();
                string password = row["Mật khẩu"].ToString();
                bool isAdmin = Convert.ToBoolean(row["Admin"]);
                bool isManager = Convert.ToBoolean(row["Quản lý"]);
                bool isActive = Convert.ToBoolean(row["Kích hoạt"]);

                users.Add(new User(id, username, password, isAdmin, isManager, isActive));
            }

            return users;
        }
        public static bool Authenticate(string username, string password)
        {
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@p_username", MySqlDbType.VarChar) { Value = username },
                new MySqlParameter("@p_password", MySqlDbType.VarChar) { Value = password }
            };
            DataTable data = DataProvider.Instance.ExecuteProcedure("Authentication", parameters);
            if (data != null)
            {
                return true;
            }
            return false;
        }
        public bool AssignRoleToUser(int userId, string role)
        {
            int roleId = GetRoleIdByName(role);
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@p_userid", MySqlDbType.Int32) { Value = userId },
                new MySqlParameter("@p_roleid", MySqlDbType.Int32) { Value = roleId }
            };
            int result = DataProvider.Instance.ExecuteNonQuery("AssignRoleToUser", parameters);
            return result > 0;
        }
        public bool RemoveRoleFromUser(int userId, string role)
        {
            int roleId = GetRoleIdByName(role);
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@p_userid", MySqlDbType.Int32) { Value = userId },
                new MySqlParameter("@p_roleid", MySqlDbType.Int32) { Value = roleId }
            };
            int result = DataProvider.Instance.ExecuteNonQuery("RemoveRoleFromUser", parameters);
            return result > 0;
        }
        private int GetRoleIdByName(string roleName)
        {
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@p_rolename", MySqlDbType.VarChar) { Value = roleName }
            };
            DataTable data = DataProvider.Instance.ExecuteProcedure("GetRoleIdByName", parameters);
            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["id"]);
            }
            return -1; 
        }
        public bool AddUser(string username, string password, string info, bool isAdmin, bool isManaegr)
        {
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@p_username", MySqlDbType.VarChar) { Value = username },
                new MySqlParameter("@p_password", MySqlDbType.VarChar) { Value = password },
                new MySqlParameter("@p_information", MySqlDbType.VarChar) { Value = info },
                new MySqlParameter("@p_isAdmin", MySqlDbType.Bit) { Value = isAdmin },
                new MySqlParameter("@p_isManager", MySqlDbType.Bit) { Value = isManaegr }
            };
            int result = DataProvider.Instance.ExecuteNonQuery("AddUser", parameters);
            return result > 0;
        }
    }
}
