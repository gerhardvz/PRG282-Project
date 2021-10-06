using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PRG282_Group_Project.Models

{
    class User
    {
        string name;
        string password;
        bool isEncrypted;

    }

    class Student
    {
        string name;
        string surname;
        int student_nr;
        Image picture;
        DateTime dob;
        char gender;
        string phone;
        string Address;
        List<Module> modules;

        //Default Student Constructor
        Student()
        {

        }

        //Constructor to be used when creating a new student to add to the database
        Student(string name, string surname,DateTime dob,char gender,string address)
        {
            this.name = name;
            this.surname = surname;
            this.dob = dob;
            this.gender = gender;
            this.Address = address;
            this.modules = new List<Modules>();
        }

        Student(string name, string surname,Image picture, DateTime dob, char gender, string address)
        {
            this.name = name;
            this.surname = surname;
            this.dob = dob;
            this.gender = gender;
            this.Address = address;
            this.modules = new List<Modules>();
        }

        //Constructor to be used when retreiving Student info from DB
        Student(int student_nr,string name, string surname,Image picture, DateTime dob, char gender, string address,List<Module> modules)
        {
            this.student_nr = student_nr;
            this.name = name;
            this.surname = surname;
            this.dob = dob;
            this.gender = gender;
            this.Address = address;
            this.modules = modules;
        }

        Student(int student_nr, string name, string surname, Image picture, DateTime dob, char gender, string address, List<string> moduleCodes)
        {
            this.student_nr = student_nr;
            this.name = name;
            this.surname = surname;
            this.dob = dob;
            this.gender = gender;
            this.Address = address;
            //TODO: Get all Modules for the coresponding module code
            //this.modules = modules;
        }

        int getStudentNumber()
        {
            return student_nr;
        }
        string getStudentName()
        {
            return $"{name} {surname}";
        }

        DateTime getDateOfBirth()
        {
            return dob;
        }

        int getAge()
        {
            DateTime today = DateTime.Now;

            int age = DateTime.Today.Year - dob.Year;

            if (today.Month < dob.Month || (today.Month == dob.Month && today.Day < dob.Day))
                age--;

            return age;
        }

        string getGender()
        {
            if (char.ToLower(gender) == 'm')
            {
                return "Male";
            }
            else if (char.ToLower(gender) == 'f')
            {
                return "Female";
            }
            throw new Exception("Invalid Gender defined.");
        }

        string getPhone()
        {
            return phone;
        }
        List<Module> getModules()
        {
            return modules;
        }

        List<string> getModuleCodes()
        {
            List<string> codes = new List<string>();
            foreach(Module module in modules)
            {
                codes.Add(module.getCode());
            }
            return codes;
        }

        void UpdatePicture(Image picture)
        {
            this.picture = picture;
        }

    }

    class Module
    {

        string code;

        public string getCode()
        {
            return code;
        }
    }
}
