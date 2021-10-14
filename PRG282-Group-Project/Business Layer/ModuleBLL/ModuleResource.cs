using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Group_Project.Business_Layer
{
    public class ModuleResource
    {
        string _module_code;
        string _name;
        string _url;

        public string Name { get => _name; set => _name = value; }
        public string URL { get => _url; set => _url = value; }
        public string ModuleCode { get => _module_code; set => _module_code = value; }

        public ModuleResource(string moduleCode, string name, string url)
        {
            this._name = name;
            this._url = url;
            this._module_code = moduleCode;
        }
        public ModuleResource()
        {

        }
    }
}
