using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.UserBLL
{
    static class Insert_User
    {
        static FileHandler fh = new FileHandler();
        static public string Add(User INuser)
        {
            try
            {
                fh.addUser(INuser);
            }
            catch
            {
                return "Could not add new user";
            }
            

            return "New User added";
        }

        static public string validation()
        {
            throw new NotImplementedException();
        }
    }
}