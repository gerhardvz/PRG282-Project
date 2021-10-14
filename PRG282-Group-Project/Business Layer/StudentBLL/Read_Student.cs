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
        DataHandler dh = new DataHandler();
        public string getStudent(Student st)
        {
            try
            {
               return dh.getStudent(st).ToString();
            }
            catch
            {
                return "Could not read Student";
            }
           
        }

        public Student getStudent(string studentNr)
        {
            Student student = new Student();
            student.StudentNumber = student.StudentNumber;
            try
            {
                return dh.getStudent(student);
            }
            catch
            {
                return new Student();
            }
        }
    
        public string validation()
        {
            throw new NotImplementedException();
        }
    }
}