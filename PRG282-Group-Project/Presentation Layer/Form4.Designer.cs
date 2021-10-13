
namespace PRG282_Group_Project.Presentation_Layer
{
    partial class frm_Data_Module
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Left1 = new System.Windows.Forms.Button();
            this.btn_Right1 = new System.Windows.Forms.Button();
            this.btn_Data_Student = new System.Windows.Forms.Button();
            this.btn_Home1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Left1
            // 
            this.btn_Left1.Location = new System.Drawing.Point(49, 308);
            this.btn_Left1.Name = "btn_Left1";
            this.btn_Left1.Size = new System.Drawing.Size(75, 23);
            this.btn_Left1.TabIndex = 1;
            this.btn_Left1.Text = "Left";
            this.btn_Left1.UseVisualStyleBackColor = true;
            // 
            // btn_Right1
            // 
            this.btn_Right1.Location = new System.Drawing.Point(170, 308);
            this.btn_Right1.Name = "btn_Right1";
            this.btn_Right1.Size = new System.Drawing.Size(75, 23);
            this.btn_Right1.TabIndex = 2;
            this.btn_Right1.Text = "Right";
            this.btn_Right1.UseVisualStyleBackColor = true;
            // 
            // btn_Data_Student
            // 
            this.btn_Data_Student.Location = new System.Drawing.Point(83, 337);
            this.btn_Data_Student.Name = "btn_Data_Student";
            this.btn_Data_Student.Size = new System.Drawing.Size(131, 23);
            this.btn_Data_Student.TabIndex = 3;
            this.btn_Data_Student.Text = "Data Student";
            this.btn_Data_Student.UseVisualStyleBackColor = true;
            this.btn_Data_Student.Click += new System.EventHandler(this.btn_Data_Student_Click);
            // 
            // btn_Home1
            // 
            this.btn_Home1.Location = new System.Drawing.Point(640, 396);
            this.btn_Home1.Name = "btn_Home1";
            this.btn_Home1.Size = new System.Drawing.Size(131, 23);
            this.btn_Home1.TabIndex = 4;
            this.btn_Home1.Text = "Home";
            this.btn_Home1.UseVisualStyleBackColor = true;
            this.btn_Home1.Click += new System.EventHandler(this.btn_Home1_Click);
            // 
            // frm_Data_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Home1);
            this.Controls.Add(this.btn_Data_Student);
            this.Controls.Add(this.btn_Right1);
            this.Controls.Add(this.btn_Left1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Data_Module";
            this.RightToLeftLayout = true;
            this.Text = "Data Module";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Left1;
        private System.Windows.Forms.Button btn_Right1;
        private System.Windows.Forms.Button btn_Data_Student;
        private System.Windows.Forms.Button btn_Home1;
    }
}