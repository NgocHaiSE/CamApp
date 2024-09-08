using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsManager { get; set; }
        public bool IsActive { get; set; }
        public User() { }
        public User(int id, string username, string password, bool isAdmin, bool isManager, bool isActive)
        {
            Id = id;
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
            IsManager = isManager;
            IsActive = isActive;
        }
    }
}
