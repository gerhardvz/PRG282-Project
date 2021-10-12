using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PRG282_Group_Project.DataTypes;

namespace PRG282_Group_Project.DataTypes
{
   public class Student
    {
        string name;
        string surname;
        int student_nr;
        Image picture;
        DateTime dob;
        char gender;
        string phone;
        string Address;
        List<string> modules;

        //Default Student Constructor
        public Student()
        {

        }

        //Constructor to be used when creating a new student to add to the database
        public Student(string name, string surname, DateTime dob, char gender, string address)
        {
            this.name = name;
            this.surname = surname;
            this.dob = dob;
            this.gender = gender;
            this.Address = address;
            this.modules = new List<string>();
        }

        public Student(string name, string surname, Image picture, DateTime dob, char gender, string address)
        {
            this.name = name;
            this.surname = surname;
            this.dob = dob;
            this.gender = gender;
            this.Address = address;
            this.modules = new List<string>();
        }

        //Constructor to be used when retreiving Student info from DB
        public Student(int student_nr, string name, string surname, Image picture, DateTime dob, char gender, string phone, string address, List<string> moduleCodes)
        {
            this.student_nr = student_nr;
            this.name = name;
            this.surname = surname;
            this.dob = dob;
            this.gender = gender;
            this.Address = address;
         
            this.modules = moduleCodes;

        }

        //Constructor to be used when retreiving Student info from DB
        public Student(int student_nr, string name, string surname, Image picture, DateTime dob, char gender, string address, List<Module> modules)
        {
            this.student_nr = student_nr;
            this.name = name;
            this.surname = surname;
            this.dob = dob;
            this.gender = gender;
            this.Address = address;
            this.modules = new List<string>();
            foreach (Module module in modules)
            {
                this.modules.Add(module.getCode());
            }

        }

        public Student(int student_nr, string name, string surname, Image picture, DateTime dob, char gender, string address, List<string> moduleCodes)
        {
            this.student_nr = student_nr;
            this.name = name;
            this.surname = surname;
            this.dob = dob;
            this.gender = gender;
            this.Address = address;
            this.modules = moduleCodes;
        }

        public int getStudentNumber()
        {
            return student_nr;
        }
        public string getFullName()
        {
            return $"{name} {surname}";
        }
        public string getName()
        {
            return name;
        }
        public string getSurname()
        {
            return surname;
        }

        public DateTime getDateOfBirth()
        {
            return dob;
        }

        public int getAge()
        {
            DateTime today = DateTime.Now;

            int age = DateTime.Today.Year - dob.Year;

            if (today.Month < dob.Month || (today.Month == dob.Month && today.Day < dob.Day))
                age--;

            return age;
        }

        public string getGender()
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

        public string getPhone()
        {
            return phone;
        }

        public string getAddress()
        {
            return Address;
        }

        public List<string> getModuleCodes()
        {
            return modules;
        }

        public void UpdatePicture(Image picture)
        {
            this.picture = picture;
        }

        public Image GetImage()
        {
            return this.picture;
        }

        override
        public string ToString()
        {
            //TODO
            return "";
        }

        public void addModules(List<string> moduleList)
        {
            this.modules.AddRange(moduleList);
        }
        public void addModule(string moduleCode)
        {
            this.modules.Add(moduleCode);
        }

        public void setModules(List<string> moduleList)
        {
            this.modules = moduleList;
        }
    }

}
