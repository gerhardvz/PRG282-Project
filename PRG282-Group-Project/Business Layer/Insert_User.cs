using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer
{
    class Insert_User
    {  
        public string insert(string username, string password)
        {
            DataHandler dh = new DataHandler();
           // adduser clas in datahandler ? or nah
           //are we adding a student or a user to the txt?
            return "Succesfully added";  
            
        }

        public string validation()
        {
            //validation
            return "success"; 
        }
    }
}
