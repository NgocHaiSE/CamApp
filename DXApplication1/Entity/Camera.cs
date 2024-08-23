using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Entity
{
    public class Camera
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public string Ip {  get; set; }
        public string Location { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int CompanyId { get; set; }
        public Camera(int id, string name, string link, int type, int status, string ip, string location, string username, string password, int companyId)
        {
            Id = id;
            Name = name;
            Link = link;
            Type = type;
            Status = status;
            Ip = ip;
            Location = location;
            Username = username;
            Password = password;
            CompanyId = companyId;
        }
    }
}
