using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.UserBLL
{
    static class Read_User
    {
        static FileHandler fh = new FileHandler();
        static private User getUser(string user)
        {
            User rUser;
            
            
              rUser = fh.getUser(user);

            return rUser;
        }

        static public bool VerifyUser(User user)
        {
            User savedUser = getUser(user.UserName);
            
            return savedUser.TestPassword(user.Password);
        }
        static public string validation()
        {
            throw new NotImplementedException();
        }
    }
}