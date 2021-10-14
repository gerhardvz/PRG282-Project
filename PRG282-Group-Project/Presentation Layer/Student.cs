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
    public partial class frmStudent : Form
    {
        Student activeStudent;
        public frmStudent()
        {
            InitializeComponent();
            //Show student list but only display student number, name surname and dob
        }
       

    

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            //Show Form to select Modules to add to Student Module List
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string result;
            //Show NewStudent Form and save 
            frmNewStudent newStudentForm = new frmNewStudent();
            DialogResult dr = newStudentForm.ShowDialog();
            if (newStudentForm.isSaved())
            {
                Student student = newStudentForm.GetNewStudent();
                 result = Insert_Student.Insert(student);
                //Display popup if student Add was successfull or not
            }

            //Display popup student creation canceled


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Save new values to active student

           string result = Update_Student.UpdateStudent(activeStudent);
            //Show Mesagebox if update was successful
        }

        private void btnRemoveModule_Click(object sender, EventArgs e)
        {
            //Remove selected module from student
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search for a student by student id
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //refresh list (get all students again)
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete selected student - active student
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            //logout and move back to login form
        }

        private void studentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //studentListView multiselect is false so user can only select one student
            //Set active student value
            activeStudent = Read_Student.getStudent(studentListView.SelectedItems[0].SubItems[0].Text);
            //Populate all Student values
            lblGender.Text = $"{activeStudent.Gender}";
            lblName.Text = $"{activeStudent.Name} {activeStudent.Surname}";
            lblStudentNumber.Text = $"{activeStudent.StudentNumber}";
        }
    }
}
