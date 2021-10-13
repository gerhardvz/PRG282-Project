
namespace PRG282_Group_Project.Presentation_Layer
{
    partial class frm_Data_Student
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
            System.Windows.Forms.Button btn_Data_Module;
            this.btn_Home2 = new System.Windows.Forms.Button();
            this.btn_Right2 = new System.Windows.Forms.Button();
            this.btn_Left2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            btn_Data_Module = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Home2
            // 
            this.btn_Home2.Location = new System.Drawing.Point(655, 412);
            this.btn_Home2.Name = "btn_Home2";
            this.btn_Home2.Size = new System.Drawing.Size(131, 23);
            this.btn_Home2.TabIndex = 9;
            this.btn_Home2.Text = "Home";
            this.btn_Home2.UseVisualStyleBackColor = true;
            this.btn_Home2.Click += new System.EventHandler(this.btn_Home2_Click);
            // 
            // btn_Data_Module
            // 
            btn_Data_Module.Location = new System.Drawing.Point(102, 353);
            btn_Data_Module.Name = "btn_Data_Module";
            btn_Data_Module.Size = new System.Drawing.Size(131, 23);
            btn_Data_Module.TabIndex = 8;
            btn_Data_Module.Text = "Data Module";
            btn_Data_Module.UseVisualStyleBackColor = true;
            btn_Data_Module.Click += new System.EventHandler(this.btn_Data_Module_Click);
            // 
            // btn_Right2
            // 
            this.btn_Right2.Location = new System.Drawing.Point(185, 324);
            this.btn_Right2.Name = "btn_Right2";
            this.btn_Right2.Size = new System.Drawing.Size(75, 23);
            this.btn_Right2.TabIndex = 7;
            this.btn_Right2.Text = "Right";
            this.btn_Right2.UseVisualStyleBackColor = true;
            // 
            // btn_Left2
            // 
            this.btn_Left2.Location = new System.Drawing.Point(64, 324);
            this.btn_Left2.Name = "btn_Left2";
            this.btn_Left2.Size = new System.Drawing.Size(75, 23);
            this.btn_Left2.TabIndex = 6;
            this.btn_Left2.Text = "Left";
            this.btn_Left2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 302);
            this.dataGridView1.TabIndex = 5;
            // 
            // frm_Data_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Home2);
            this.Controls.Add(btn_Data_Module);
            this.Controls.Add(this.btn_Right2);
            this.Controls.Add(this.btn_Left2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Data_Student";
            this.Text = "Data Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Home2;
        private System.Windows.Forms.Button btn_Right2;
        private System.Windows.Forms.Button btn_Left2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}