using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Group_Project.Business_Layer
{
    public class Module
    {
        string _code;
        string _name;
        string _description;

        List<ModuleResource> _resource;

        //resources
        public Module(string code, string name, string description)
        {
            this._code = code;
            this._name = name;
            this._description = description;

            this._resource = new List<ModuleResource>();

        }

        public Module()
        {
          

        }

        //Gerhard van Zyl:
        //My prefered method of getters and setters
        //public string getCode()
        //{
        //    return _code;
        //}
        //public string getName()
        //{
        //    return _name;
        //}
        //public string getDescription()
        //{
        //    return _description;
        //}

        public string Code { get => _code; set => _code= value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }

        public List<ModuleResource> Resources { get => _resource; set => _resource = value; }

        public void addResource(string name, string url)
        {
            _resource.Add(new ModuleResource(_code,name, url));
        }

        //resources

        
    }
}
