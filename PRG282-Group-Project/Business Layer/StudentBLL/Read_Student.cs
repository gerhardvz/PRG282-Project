using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.StudentBLL
{
    static class Read_Student
    {
        static DataHandler dh = new DataHandler();
        static public string getStudent(Student st)
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
        static public List<Student> getStudents()
        {
            List<Student> student = dh.getStudentList();
            return student;
        }

        static  public Student getStudent(string studentNr)
        {
            Student student = new Student();
            student.StudentNumber = student.StudentNumber;
            try
            {
                student = dh.getStudent(student);
                student.addModules(getStudentModules(student.StudentNumber));
                return student;
            }
            catch
            {
                return new Student();
            }
        }

        static public List<string> getStudentModules(int studentNr)
        {
            Student student = new Student();
            student.StudentNumber = studentNr;
            return dh.getStudentModuleList(student);
        }
        static public List<string> addStudentModules(int studentNr,string moduleCode)
        {
            //Returns List of current Modules after adding
            Student student = new Student();
            student.StudentNumber = studentNr;
             dh.addStudentModule(student,moduleCode);
            return getStudentModules(studentNr);
        }

        static public List<string> delStudentModules(int studentNr, string moduleCode)
        {
            //Returns List of current Modules after deleting
            Student student = new Student();
            student.StudentNumber = studentNr;
             dh.delStudentModule(student,moduleCode);
            return getStudentModules(studentNr);
        }


        static public string validation()
        {
            throw new NotImplementedException();
        }
    }
}