using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Group_Project.Business_Layer
{
    class User
    {
        string UserName;
        string Password;
        string Encrypted;

        public string UserName1 { get => UserName; set => UserName = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Encrypted1 { get => Encrypted; set => Encrypted = value; }

        public User(string userName, string password, string encrypted)
        {
            UserName = userName;
            Password = password;
            Encrypted = encrypted;
        }

        
    }
}
