using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.ModuleBLL
{
    class Read_Module
    {
        public string Read(string ModL)
        {
            DataHandler dh = new DataHandler();
            string ModuleL = dh.getModules(ModL);
            return ModuleL;
        }

        public string validation()
        {
            throw new NotImplementedException();
        }
    }
}