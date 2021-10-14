using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.StudentBLL
{
    static class Update_Student
    {
        static DataHandler dh = new DataHandler();

        static public string UpdateStudent(Student student)
        {
            try
            {
                dh.updateStudentImage(student);
                dh.updateStudentAddress(student);
                dh.updateStudentPhone(student);
            }
            catch
            {
                return "Could not update Student";
            }
            return "Student  updated";

        }

        static public string UpdateStudentImage(Student student)
        {
            try
            {
                dh.updateStudentImage(student);
            }
            catch{
                return "Could not update Student Image";
            }
            return "Student image updated";
            
        }
        static public string UpdateAdress(Student student)
        {
            try
            {
                dh.updateStudentAddress(student);
            }
            catch
            {
                return "Could not update Student Address";
            }
            return "Student address updated";

            
        }

        static public string validation()
        {
            throw new NotImplementedException();
        }

        static public string UpdatePhone(Student student)
        {
            try
            {
                dh.updateStudentPhone(student);
            }
            catch
            {
                return "Could not update Student Phone number";
            }
            return "Student phone number updated";

            

        }
            
    }
}