
namespace PRG282_Group_Project.Presentation_Layer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(75, 78);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(185, 135);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnModules
            // 
            this.btnModules.Location = new System.Drawing.Point(346, 78);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(185, 135);
            this.btnModules.TabIndex = 1;
            this.btnModules.Text = "Modules";
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 292);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.btnStudents);
            this.Name = "frmMain";
            this.Text = "BC Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnModules;
    }
}