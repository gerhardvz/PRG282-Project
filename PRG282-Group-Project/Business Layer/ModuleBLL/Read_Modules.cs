using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Data;
using System.Data.Sql;

namespace PRG282_Group_Project.Business_Layer.ModuleBLL
{
   static class Read_Module
    {
        static DataHandler dh = new DataHandler();
      
        public static Module GetModule (string code)
        {
            return dh.GetModule(code);
        }

        public static List<Module> displayModules()
        {
            return dh.getModuleList();
        }

        public static List<ModuleResource> GetModuleResources(string code)
        {
            return dh.getModuleResourcesList(code);
        }
        public static ModuleResource GetModuleResource(string code,string url)
        {
            return dh.getModuleResource(code,url);
        }
        public static string validation()
        {
            throw new NotImplementedException();
        }
    }
}