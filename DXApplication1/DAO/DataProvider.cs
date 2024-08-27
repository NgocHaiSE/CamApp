using DevExpress.Xpo.DB.Helpers;
using DXApplication1.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance 
        { 
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; } 
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            DataTable data = new DataTable();

            using (MySqlConnection connection = ConnectionUtil.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }

        public DataTable ExecuteProcedure(string procedure, MySqlParameter[] parameters = null)
        {
            DataTable data = new DataTable();

            using (MySqlConnection connection = ConnectionUtil.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(procedure, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }

        public int ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            int data = 0;
            using (MySqlConnection connection = ConnectionUtil.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    data = cmd.ExecuteNonQuery();
                }
            }
            return data;
        }

        public object ExecuteScalar (string query, MySqlParameter[] parameters = null)
        {
            object data = 0;
            using (MySqlConnection connection = ConnectionUtil.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    data = cmd.ExecuteScalar();
                }
            }
            return data;
        }
    }
}
