using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Group_Project.Business_Layer.ModuleBLL;

namespace PRG282_Group_Project.Presentation_Layer
{
    public partial class ModuleView : Form
    {
        Module SelectedModule;
        public ModuleView()
        {
            InitializeComponent();

        }

        private void Module_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadModuleList()
        {
            foreach(Module module in Read_Module.displayModules())
            {
                ListViewItem item = new ListViewItem(module.Code);
                item.SubItems.Add(module.Name);

                moduleListView.Items.Add(item);
            }
            
        }

        private void moduleListView_MouseClick(object sender, MouseEventArgs e)
        {
            SelectedModule = Read_Module.GetModule(moduleListView.SelectedItems[0].SubItems[0].Text);
            lblModuleCode.Text = $"{SelectedModule.Code} - {SelectedModule.Name}";
            lblDescription.Text = SelectedModule.Description;
            moduleResourcesList;
        }
    }
}
