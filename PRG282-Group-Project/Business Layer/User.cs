using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Group_Project.Business_Layer
{
    public class User
    {
        string _userName;
        string _password;
        string _encrypted;

        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Encrypted { get => _encrypted; set => _encrypted = value; }

        public User(string userName, string password, string encrypted)
        {
            _userName = userName;
            _password = password;
            _encrypted = encrypted;
        }

        
    }
}
