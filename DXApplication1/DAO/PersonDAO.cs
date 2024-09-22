using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.Utils.About;
using DXApplication1.Entity;
using DXApplication1.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAO
{
    public class PersonDAO
    {
        private static PersonDAO instance;

        public static PersonDAO Instance
        {
            get { if (instance == null) instance = new PersonDAO(); return PersonDAO.instance; }
            private set => PersonDAO.instance = value;
        }

        private PersonDAO() { }

        #region Method
        public DataTable GetAllPersons()
        {
            DataTable data = DataProvider.Instance.ExecuteProcedure("GetAllPersons");
            return data;
        }

        public void AddPerson(Person person)
        {
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@p_code", MySqlDbType.VarChar) { Value = person.Code },
                new MySqlParameter("@p_fullname", MySqlDbType.VarChar) { Value = person.Name },
                new MySqlParameter("@p_information", MySqlDbType.VarChar) { Value = person.Information },
                new MySqlParameter("@p_isrecog", MySqlDbType.Int32) { Value = person.IsRecog },
                new MySqlParameter("@p_gender", MySqlDbType.Bit) { Value = person.Gender },
                new MySqlParameter("@p_birth", MySqlDbType.DateTime) { Value = person.Birth },
                new MySqlParameter("@p_phone", MySqlDbType.VarChar) { Value = person.Phone },
                new MySqlParameter("@p_address", MySqlDbType.VarChar) { Value = person.Address }
            };
            DataProvider.Instance.ExecuteNonQuery("AddPerson", parameters);
        }

        public void AdjustPerson(Person person)
        {
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@p_id", MySqlDbType.Int32) { Value = person.Id },
                new MySqlParameter("@p_code", MySqlDbType.VarChar) { Value = person.Code },
                new MySqlParameter("@p_fullname", MySqlDbType.VarChar) { Value = person.Name },
                new MySqlParameter("@p_information", MySqlDbType.VarChar) { Value = person.Information },
                new MySqlParameter("@p_isrecog", MySqlDbType.Int32) { Value = person.IsRecog },
                new MySqlParameter("@p_gender", MySqlDbType.Bit) { Value = person.Gender },
                new MySqlParameter("@p_birth", MySqlDbType.DateTime) { Value = person.Birth },
                new MySqlParameter("@p_phone", MySqlDbType.VarChar) { Value = person.Phone },
                new MySqlParameter("@p_address", MySqlDbType.VarChar) { Value = person.Address }
            };
            DataProvider.Instance.ExecuteNonQuery("UpdatePerson", parameters);
        }

        public void UpdatePersonInfo(int id, string info)
        {
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@p_id", MySqlDbType.Int32) { Value = id },
                new MySqlParameter("@p_info", MySqlDbType.VarChar) { Value = info }
            };
            DataProvider.Instance.ExecuteNonQuery("UpdatePersonInfo", parameters); 
        }

        public DataTable GetPerson(int id)
        {
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@p_id", MySqlDbType.Int32) { Value = id }
            };
            DataTable data = DataProvider.Instance.ExecuteProcedure("GetPerson", parameters);
            return data;
        }

        public bool DeletePerson(int id)
        {
            try
            {
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@p_id", MySqlDbType.Int32) { Value = id }
                };
                int rowsAffected = DataProvider.Instance.ExecuteNonQuery("DeletePerson", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting person: " + ex.Message);
                return false;
            }
        }


        #endregion
    }
}
