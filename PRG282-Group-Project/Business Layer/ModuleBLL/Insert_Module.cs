using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer
{
    class Insert_Module
    {
        public string Insert(string Mod)
        {
            DataHandler dh = new DataHandler();
            string ModuleAdded = dh.addModule(Mod);
            return ModuleAdded;
        }

        public string validation()
        {
            throw new NotImplementedException();
        }
    }
}