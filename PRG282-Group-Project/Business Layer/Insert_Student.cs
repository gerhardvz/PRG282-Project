using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer
{
    class Insert_Student : IAddStudent
    {
        public string insert(string name,string surname, DateTime dob, char gender)
        {
            DataHandler dh = new DataHandler();
            String StudentString =  dh.addStudent();

            return "Succesfully added";

        }

        public string validation()
        {
            //validation
            return "success";
        }
    }
}
