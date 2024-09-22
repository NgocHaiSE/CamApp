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
        public string Type { get; set; }
        public int? Status { get; set; }
        public string Ip { get; set; }
        public string Location { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? IsActivate { get; set; }

        public Camera(int id, string name, string link, string type, int? status, string ip, string location, string username, string password)
        {
            Id = id;
            Name = string.IsNullOrEmpty(name) ? null : name;
            Link = string.IsNullOrEmpty(link) ? null : link;
            Type = string.IsNullOrEmpty(type) ? null : type;
            Status = status;
            Ip = string.IsNullOrEmpty(ip) ? null : ip;
            Location = string.IsNullOrEmpty(location) ? null : location;
            Username = string.IsNullOrEmpty(username) ? null : username;
            Password = string.IsNullOrEmpty(password) ? null : password;
        }
    }
}

