using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Group_Project.DataTypes
{

    public class Module
    {
        string code;
        string name;
        string description;

        public string getCode()
        {
            return code;
        }
        public string getName()
        {
            return name;
        }
        public string getDescription()
        {
            return description;
        }

       public Module(string code,string name,string description)
        {
            this.code = code;
            this.name = name;
            this.description = description;
        }
    }
}
