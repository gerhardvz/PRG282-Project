using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.StudentBLL
{
    class Delete_Student
    {
        DataHandler dh = new DataHandler();
        public string Delete(Student student)
        {
           
            try
            {
                dh.delStudent(student);
            }
            catch
            {
                return "Could not delete student";
            }

            return "Student deleted";

        }
    }
}
