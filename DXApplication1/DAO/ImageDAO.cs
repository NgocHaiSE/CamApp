using DevExpress.Utils;
using DXApplication1.Entity;
using DXApplication1.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DXApplication1.DAO
{
    public class ImageDAO
    {
        private static ImageDAO instance;
        public static ImageDAO Instance
        {
            get { if (instance == null) instance = new ImageDAO(); return ImageDAO.instance; }
            private set => ImageDAO.instance = value;
        }
        private ImageDAO() { }

        #region Method
        public List<string> GetPersonImages(string personcode)
        {
            List<string> images = new List<string>();
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@p_personcode", MySqlDbType.VarChar) { Value = personcode }
            };
            DataTable data = DataProvider.Instance.ExecuteProcedure("GetPersonImages", parameters);

            foreach (DataRow row in data.Rows)
            {
                images.Add(row["link"].ToString());
            }
            return images;
        }

        public void AddImages(string personcode, List<ImageEntity> images)
        {
            try
            {
                foreach (ImageEntity image in images)
                {
                    MySqlParameter[] parameters = new MySqlParameter[]
                    {
                        new MySqlParameter("@p_personcode", MySqlDbType.VarChar) { Value = personcode },
                        new MySqlParameter("@p_link", MySqlDbType.VarChar) { Value = image.Link },
                        new MySqlParameter("@p_indexmilvus", MySqlDbType.Int64) { Value = image.IndexMilvus }
                    };
                    DataProvider.Instance.ExecuteNonQuery("AddImages", parameters);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding images: " + ex.Message);
            }
        }

        #endregion

    }
}
