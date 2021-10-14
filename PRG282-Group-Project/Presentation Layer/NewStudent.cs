using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Group_Project.Business_Layer.StudentBLL;

namespace PRG282_Group_Project.Presentation_Layer
{
    public partial class frmNewStudent : Form
    {
        Student student = new Student();
        bool save = false;
        public frmNewStudent()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void edtSurname_TextChanged(object sender, EventArgs e)
        {
            student.Surname = edtSurname.Text;
        }

        private void edtName_TextChanged(object sender, EventArgs e)
        {
            student.Name = edtName.Text;
        }

        private void dtDOB_ValueChanged(object sender, EventArgs e)
        {
            student.DateOfBirth = dtDOB.Value;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = 'M';
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = 'F';
        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = 'O';
        }

        private void edtPhone_TextChanged(object sender, EventArgs e)
        {
            student.Phone = edtPhone.Text;
        }

        private void edtAddress_TextChanged(object sender, EventArgs e)
        {
            student.Address = edtAddress.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             save = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
             save = false;
            this.Close();
        }
        public bool isSaved()
        {
            return save;
        }
        public Student GetNewStudent()
        {
            return student;
        }
    }
}
