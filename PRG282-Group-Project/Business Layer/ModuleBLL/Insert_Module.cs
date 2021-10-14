using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;

namespace PRG282_Group_Project.Business_Layer.ModuleBLL
{
    static class Insert_Module
    {
        static DataHandler dh = new DataHandler();
        public static string Insert(string code,string name,string description)
        {
            Module module = new Module(code, name, description);
            try { dh.addModule(module); }
            catch
            {
                return "Could not Insert Module";
            }
            return "Module Inserted";
        }

        public static string Insert(Module module)
        {
            try { dh.addModule(module); }
            catch
            {
                return "Could not Insert Module";
            }
            return "Module Inserted";
        }

        public static string validation()
        {
            throw new NotImplementedException();
        }
    }
}