using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DTO
{
    public class CameraDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }

        public CameraDTO(int id, string name, string link, string location, int status)
        {
            Id = id;
            Name = name;
            Link = link;
            Location = location;
            Status = status == 1 ? "Có" : "Không";
        }

        public CameraDTO(DataRow row)
        {
            Id = Convert.ToInt32(row["ID"]);
            Name = row["Tên Camera"].ToString();
            Link = row["Liên kết"].ToString();
            Location = row["Vị trí"].ToString();
            Status = row["Nhận diện"].ToString();
        }
    }
}

