using DXApplication1.DTO;
using DXApplication1.Entity;
using DXApplication1.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAO
{
    public class CameraDAO
    {
        private static CameraDAO instance;

        public static CameraDAO Instance 
        {
            get { if (instance == null) instance = new CameraDAO(); return CameraDAO.instance; } 
            private set => CameraDAO.instance = value; 
        }

        private CameraDAO() { }

        #region Method
        public List<CameraDTO> GetAllCameras()
        {
            List<CameraDTO> cameraDTOs = new List<CameraDTO>();
            DataTable data = DataProvider.Instance.ExecuteProcedure("GetCameraInfo");

            foreach(DataRow item in data.Rows)
            {
                CameraDTO cameraDTO = new CameraDTO(item);
                cameraDTOs.Add(cameraDTO);
            }
            return cameraDTOs;
        }

        public DataTable GetCameraList()
        {
            DataTable data = DataProvider.Instance.ExecuteProcedure("GetAllCameras");
            return data;
        }
        public void Insert(Camera camera)
        {
            using (MySqlConnection connection = ConnectionUtil.GetConnection())
            {
                string query = "InsertCamera";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_id", camera.Id);
                    cmd.Parameters.AddWithValue("@p_name", camera.Name);
                    cmd.Parameters.AddWithValue("@p_location", camera.Location);
                    cmd.Parameters.AddWithValue("@p_link", camera.Link);
                    cmd.Parameters.AddWithValue("@p_type", camera.Type);
                    cmd.Parameters.AddWithValue("@p_ip", camera.Ip);
                    cmd.Parameters.AddWithValue("@p_username", camera.Username);
                    cmd.Parameters.AddWithValue("@p_password", camera.Password);
                    cmd.Parameters.AddWithValue("@p_status", camera.Status);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Update(Camera camera)
        {
            using (MySqlConnection connection = ConnectionUtil.GetConnection())
            {
                string query = "UpdateCamera";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_id", camera.Id);
                    cmd.Parameters.AddWithValue("@p_name", camera.Name);
                    cmd.Parameters.AddWithValue("@p_location", camera.Location);
                    cmd.Parameters.AddWithValue("@p_link", camera.Link);
                    cmd.Parameters.AddWithValue("@p_type", camera.Type);
                    cmd.Parameters.AddWithValue("@p_ip", camera.Ip);
                    cmd.Parameters.AddWithValue("@p_username", camera.Username);
                    cmd.Parameters.AddWithValue("@p_password", camera.Password);
                    cmd.Parameters.AddWithValue("@p_status", camera.Status);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int cameraId, int isActivate)
        {
            using (MySqlConnection connection = ConnectionUtil.GetConnection())
            {
                string query = "DeleteCamera";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_id", cameraId);
                    cmd.Parameters.AddWithValue("@p_isActivate", isActivate);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
