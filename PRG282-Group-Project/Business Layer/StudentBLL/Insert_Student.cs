using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer
{
    class Insert_Student
    {
        public string Insert(string s)
        {
            DataHandler dh = new DataHandler();
            string StudentAdded = dh.addStudent(s);

            return StudentAdded;
        }

        public string validation()
        {
            throw new NotImplementedException();
        }
    }
}
