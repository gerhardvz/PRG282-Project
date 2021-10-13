using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Group_Project.Presentation_Layer
{
    public partial class frm_Data_Student : Form
    {
        public frm_Data_Student()
        {
            InitializeComponent();
        }

        private void btn_Home2_Click(object sender, EventArgs e)
        {
            Form frm_Login = new Form();
            frm_Login.ShowDialog();
        }

        private void btn_Data_Module_Click(object sender, EventArgs e)
        {
            Form frm_Data_Module = new Form();
            frm_Data_Module.ShowDialog();
        }
    }
}
