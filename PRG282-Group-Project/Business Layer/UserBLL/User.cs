using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace PRG282_Group_Project.Business_Layer
{
    public class User
    {
        string _userName;
        string _password;
        bool _encrypted;

        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = EncodePassword(value);  }
        public bool Encrypted { get => _encrypted; set => _encrypted = changeEncoded(value); }

        public User(string userName, string password, bool encrypted)
        {
            _userName = userName;
            _password = password;
            _encrypted = encrypted;
        }

        public bool TestPassword(string password)
        {
            if (_encrypted)
            {
                string ePassword = EncodePassword(password);
                return (_password.Equals(ePassword));
            }
            return _password.Equals(password);
        }

        private string SavePassword(string password)
        {
            if (_encrypted)
            {
                return EncodePassword(password);
            }
            return password;
        }

        private bool changeEncoded(bool encoded)
        {
            if (encoded)
            {
                _password= EncodePassword(_password);
                return encoded;
            }
            _password = _password;
            return encoded;
        }

        private static string EncodePassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }


    }
}
