using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer
{
    class Update_Student
    {
        public string UpdateAdress(string studentA)
        {
            DataHandler dh = new DataHandler();
            string UpdateSt = dh.updateStudentAddress(studentA);

            return UpdateSt;
        }

        public string validation()
        {
            throw new NotImplementedException();
        }
        public string UpdatePhone(string studentP)
        {
            DataHandler dh = new DataHandler();
            string UpdateP = dh.updateStudentPhone(studentP);

            return UpdateP;
        }
    }
}
