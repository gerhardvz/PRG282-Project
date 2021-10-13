using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Group_Project
{
    public partial class frm_Existing_Account : Form
    {
        public frm_Existing_Account()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGet_Data_Click(object sender, EventArgs e)
        {
            Form frm_Data_Student = new Form();
            frm_Data_Student.ShowDialog();
        }

        private void btn_Log_Out1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
