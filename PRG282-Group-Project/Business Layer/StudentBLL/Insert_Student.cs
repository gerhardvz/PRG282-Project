using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.StudentBLL
{
    class Insert_Student
    {
        DataHandler dh = new DataHandler();
        public string Insert(Student s)
        {
            try {
                dh.addStudent(s);
            }
            catch
            {
                return "Could not insert student";
            }
            

            return "Student inserted";
        }

        public string validation()
        {
            throw new NotImplementedException();
        }
    }
}