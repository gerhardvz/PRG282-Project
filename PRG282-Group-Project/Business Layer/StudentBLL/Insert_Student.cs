using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.StudentBLL
{
    static class Insert_Student
    {
        static DataHandler dh = new DataHandler();
        public static string Insert(Student s)
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

        static public string validation()
        {
            throw new NotImplementedException();
        }
    }
}