using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.StudentBLL
{
    class Read_Student
    {
        public string Read(string st)
        {
            DataHandler dh = new DataHandler();
            string GetStudent = dh.getStudents(st);

            return GetStudent;
        }

        public string validation()
        {
            throw new NotImplementedException();
        }
    }
}