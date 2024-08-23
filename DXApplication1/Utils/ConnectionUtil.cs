using DevExpress.Office.Crypto;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo.DB.Helpers;
using System.Linq.Expressions;
using DevExpress.XtraPrinting;
using System.Windows.Forms;

namespace DXApplication1.Utils
{
    public class ConnectionUtil
    {
        static readonly string server = "127.0.0.1";
        static readonly string user = "root";
        static readonly string password = "08032003";
        static readonly string database = "face_application";
        private static string connString = "server=" + server + ";user=" + user
            + ";password=" + password + ";database=" + database;

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
                return null;
            }

            return conn;
        }

    }
}
