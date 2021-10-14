using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.UserBLL
{
    static class Update_User
    {
        static FileHandler fh = new FileHandler();
        static public string Add(User user)
        {
            try
            {
                fh.updateUser(user);
            }
            catch
            {
                return "Could not update user";
            }


            return "User updated";
        }

        static public string validation()
        {
            throw new NotImplementedException();
        }
    }
}