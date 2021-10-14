using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PRG282_Group_Project.Business_Layer.StudentBLL
{
    public class Student
    {
        int _number;
        string _name;
        string _surname;
        Image _image; //what data type for images ?
        DateTime _dob;
        char _gender; //M = male , F = female, O = other
        string _phone;
        string _address;
        List<string> _modulecodes;
        
        public int StudentNumber { get => _number; set => _number = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public Image Image { get => _image; set => _image = value; }
        public DateTime DateOfBirth { get => _dob; set => _dob = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }
        public List<string> ModuleCodes { get => _modulecodes; set => _modulecodes = value; }

        //Used when searching for users
        public Student()
        {
         

        }

        //Gerhard van Zyl : Bare Minimum constructor for Student
        public Student(string name, string surname, DateTime dob, char gender)
        {
            this._name = name;
            this._surname = surname;
            this._dob = dob;
            this._gender = gender;
            this._modulecodes = new List<string>();

        }

        //Gerhard van Zyl : Constructor used when creating student from DB object
        public Student(int student_nr, string name, string surname, Image picture, DateTime dob, char gender, string phone, string address, List<string> moduleCodes)
        {
            this._number = student_nr;
            this._name = name;
            this._surname = surname;
            this._dob = dob;
            this._gender = gender;
            this._image = picture;
            this._address = address;
            this._phone = phone;
            this._modulecodes = moduleCodes;

        }


        public void addModules(List<string> moduleList)
        {
            this._modulecodes.AddRange(moduleList);
        }
        public void addModule(string moduleCode)
        {
            this._modulecodes.Add(moduleCode);
        }
       

       

        override
      public string ToString()
        {
            //TODO
            return "";
        }

    }
}
