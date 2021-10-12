using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Group_Project.Business_Layer
{
    class Module
    {
        string Code;
        string Name;
        string Description;
        //resources
        public Module(string code, string name, string description)
        {
            Code1 = code;
            Name1 = name;
            Description1 = description;
        }

        public string Code1 { get => Code; set => Code = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Description1 { get => Description; set => Description = value; }
        //resources
    }
}
