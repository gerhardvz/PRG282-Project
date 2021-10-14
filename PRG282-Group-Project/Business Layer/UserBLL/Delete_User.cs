using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.UserBLL
{
    static class Delete_User
    {
        static FileHandler fh = new FileHandler();
        static public string Delete(User user)
        {
            try
            {
                fh.deleteUser(user);
            }
            catch
            {
                return "Could not delete User";
            }

            return "User Deleted";
        }

        static public string validation()
        {
            throw new NotImplementedException();
        }
    }
}