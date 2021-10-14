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
        Module activeModule;
        ModuleResource activeModuleResource;
        public ModuleView()
        {
            InitializeComponent();

        }

        private void Module_Load(object sender, EventArgs e)
        {
            LoadModuleList();
            ClearModuleSelection();
        }

        private void ClearModuleSelection()
        {
            this.lblDescription.Text = "Description";
            this.lblModuleCode.Text = "Module Code and Name";
            
            moduleResourcesList.Items.Clear();
            activeModule = null;
        }

        private void LoadModuleList()
        {
            foreach(Module module in Read_Module.displayModules())
            {
                ListViewItem item = new ListViewItem(module.ToListViewArray());

                moduleListView.Items.Add(item);
            }
            
        }

        private void moduleListView_MouseClick(object sender, MouseEventArgs e)
        {
            activeModule = Read_Module.GetModule(moduleListView.SelectedItems[0].SubItems[0].Text);
            lblModuleCode.Text = $"{activeModule.Code} - {activeModule.Name}";
            lblDescription.Text = activeModule.Description;
           
        }

        private void btnChangeDesc_Click(object sender, EventArgs e)
        {
            //Display popup message asking for description change. save to activeModule
        }

        private void btnResourceAdd_Click(object sender, EventArgs e)
        {
            //add new resource to Module
        }

        private void btnResourceRefresh_Click(object sender, EventArgs e)
        {
            //load resources from module
        }

        private void btnResourceDelete_Click(object sender, EventArgs e)
        {
            //remove selected resource for module
        }

        private void btnModuleAdd_Click(object sender, EventArgs e)
        {
            //add new module
        }

        private void btnModuleRefresh_Click(object sender, EventArgs e)
        {
           
            LoadModuleList();
        }

        private void btnModuleDelete_Click(object sender, EventArgs e)
        {
            //delete selected module
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //search for module by code
           
        }

        private void moduleListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeModule = Read_Module.GetModule(moduleListView.SelectedItems[0].SubItems[0].ToString());
            lblModuleCode.Text = activeModule.Code;
            lblDescription.Text = activeModule.Description;
            //Load ResourceList
            List<ModuleResource> mr = Read_Module.GetModuleResources(activeModule.Code);
            foreach(ModuleResource moduleResource in mr)
            {
                ListViewItem item = new ListViewItem(moduleResource.ToListViewArray());
                moduleResourcesList.Items.Add(item);
            }
                }

        private void moduleResourcesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeModuleResource = Read_Module.GetModuleResource(activeModule.Code,moduleResourcesList.SelectedItems[0].SubItems[1].ToString()) ;
           

        }
    }
}
