using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.UserBLL
{
    class Insert_User
    {
        public string Add(string INuser)
        {
            FileHandler fh = new FileHandler();
            string StudentAdded = fh.addUser(INuser);

            return StudentAdded;
        }

        public string validation()
        {
            throw new NotImplementedException();
        }
    }
}