
namespace PRG282_Group_Project.Presentation_Layer
{
    partial class ModuleView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResourceAdd = new System.Windows.Forms.Button();
            this.btnResourceRefresh = new System.Windows.Forms.Button();
            this.btnResourceDelete = new System.Windows.Forms.Button();
            this.moduleResourcesList = new System.Windows.Forms.ListView();
            this.btnChangeDesc = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.edtModuleSearch = new System.Windows.Forms.TextBox();
            this.moduleListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModuleAdd = new System.Windows.Forms.Button();
            this.btnModuleRefresh = new System.Windows.Forms.Button();
            this.btnModuleDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.moduleResourcesList);
            this.groupBox1.Controls.Add(this.btnChangeDesc);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblModuleCode);
            this.groupBox1.Location = new System.Drawing.Point(31, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 472);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Modules";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnResourceAdd);
            this.panel2.Controls.Add(this.btnResourceRefresh);
            this.panel2.Controls.Add(this.btnResourceDelete);
            this.panel2.Location = new System.Drawing.Point(52, 409);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 51);
            this.panel2.TabIndex = 19;
            // 
            // btnResourceAdd
            // 
            this.btnResourceAdd.Location = new System.Drawing.Point(12, 11);
            this.btnResourceAdd.Name = "btnResourceAdd";
            this.btnResourceAdd.Size = new System.Drawing.Size(88, 28);
            this.btnResourceAdd.TabIndex = 3;
            this.btnResourceAdd.Text = "Add";
            this.btnResourceAdd.UseVisualStyleBackColor = true;
            this.btnResourceAdd.Click += new System.EventHandler(this.btnResourceAdd_Click);
            // 
            // btnResourceRefresh
            // 
            this.btnResourceRefresh.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnResourceRefresh.Location = new System.Drawing.Point(119, 11);
            this.btnResourceRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnResourceRefresh.Name = "btnResourceRefresh";
            this.btnResourceRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnResourceRefresh.TabIndex = 2;
            this.btnResourceRefresh.Text = "Refresh";
            this.btnResourceRefresh.UseVisualStyleBackColor = true;
            this.btnResourceRefresh.Click += new System.EventHandler(this.btnResourceRefresh_Click);
            // 
            // btnResourceDelete
            // 
            this.btnResourceDelete.Location = new System.Drawing.Point(241, 11);
            this.btnResourceDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnResourceDelete.Name = "btnResourceDelete";
            this.btnResourceDelete.Size = new System.Drawing.Size(100, 28);
            this.btnResourceDelete.TabIndex = 1;
            this.btnResourceDelete.Text = "Delete";
            this.btnResourceDelete.UseVisualStyleBackColor = true;
            this.btnResourceDelete.Click += new System.EventHandler(this.btnResourceDelete_Click);
            // 
            // moduleResourcesList
            // 
            this.moduleResourcesList.HideSelection = false;
            this.moduleResourcesList.Location = new System.Drawing.Point(35, 161);
            this.moduleResourcesList.Name = "moduleResourcesList";
            this.moduleResourcesList.Size = new System.Drawing.Size(394, 234);
            this.moduleResourcesList.TabIndex = 3;
            this.moduleResourcesList.UseCompatibleStateImageBehavior = false;
            this.moduleResourcesList.View = System.Windows.Forms.View.Details;
            // 
            // btnChangeDesc
            // 
            this.btnChangeDesc.Location = new System.Drawing.Point(346, 80);
            this.btnChangeDesc.Name = "btnChangeDesc";
            this.btnChangeDesc.Size = new System.Drawing.Size(75, 23);
            this.btnChangeDesc.TabIndex = 2;
            this.btnChangeDesc.Text = "Change Description";
            this.btnChangeDesc.UseVisualStyleBackColor = true;
            this.btnChangeDesc.Click += new System.EventHandler(this.btnChangeDesc_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(32, 83);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.AutoSize = true;
            this.lblModuleCode.Location = new System.Drawing.Point(32, 36);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(160, 17);
            this.lblModuleCode.TabIndex = 0;
            this.lblModuleCode.Text = "Module Code and Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.moduleListView);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(579, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 471);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Module List";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.edtModuleSearch);
            this.groupBox4.Location = new System.Drawing.Point(429, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 100);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Module Code";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(21, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // edtModuleSearch
            // 
            this.edtModuleSearch.Location = new System.Drawing.Point(9, 38);
            this.edtModuleSearch.Name = "edtModuleSearch";
            this.edtModuleSearch.Size = new System.Drawing.Size(100, 22);
            this.edtModuleSearch.TabIndex = 23;
            // 
            // moduleListView
            // 
            this.moduleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.moduleListView.FullRowSelect = true;
            this.moduleListView.HideSelection = false;
            this.moduleListView.Location = new System.Drawing.Point(40, 37);
            this.moduleListView.MultiSelect = false;
            this.moduleListView.Name = "moduleListView";
            this.moduleListView.Size = new System.Drawing.Size(356, 364);
            this.moduleListView.TabIndex = 22;
            this.moduleListView.UseCompatibleStateImageBehavior = false;
            this.moduleListView.View = System.Windows.Forms.View.Details;
            this.moduleListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.moduleListView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModuleAdd);
            this.panel1.Controls.Add(this.btnModuleRefresh);
            this.panel1.Controls.Add(this.btnModuleDelete);
            this.panel1.Location = new System.Drawing.Point(40, 408);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 51);
            this.panel1.TabIndex = 18;
            // 
            // btnModuleAdd
            // 
            this.btnModuleAdd.Location = new System.Drawing.Point(12, 11);
            this.btnModuleAdd.Name = "btnModuleAdd";
            this.btnModuleAdd.Size = new System.Drawing.Size(88, 28);
            this.btnModuleAdd.TabIndex = 3;
            this.btnModuleAdd.Text = "Add";
            this.btnModuleAdd.UseVisualStyleBackColor = true;
            this.btnModuleAdd.Click += new System.EventHandler(this.btnModuleAdd_Click);
            // 
            // btnModuleRefresh
            // 
            this.btnModuleRefresh.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnModuleRefresh.Location = new System.Drawing.Point(119, 11);
            this.btnModuleRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnModuleRefresh.Name = "btnModuleRefresh";
            this.btnModuleRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnModuleRefresh.TabIndex = 2;
            this.btnModuleRefresh.Text = "Refresh";
            this.btnModuleRefresh.UseVisualStyleBackColor = true;
            this.btnModuleRefresh.Click += new System.EventHandler(this.btnModuleRefresh_Click);
            // 
            // btnModuleDelete
            // 
            this.btnModuleDelete.Location = new System.Drawing.Point(241, 11);
            this.btnModuleDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnModuleDelete.Name = "btnModuleDelete";
            this.btnModuleDelete.Size = new System.Drawing.Size(100, 28);
            this.btnModuleDelete.TabIndex = 1;
            this.btnModuleDelete.Text = "Delete";
            this.btnModuleDelete.UseVisualStyleBackColor = true;
            this.btnModuleDelete.Click += new System.EventHandler(this.btnModuleDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Resources";
            // 
            // ModuleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 508);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModuleView";
            this.Text = "Module";
            this.Load += new System.EventHandler(this.Module_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView moduleResourcesList;
        private System.Windows.Forms.Button btnChangeDesc;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblModuleCode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnResourceAdd;
        private System.Windows.Forms.Button btnResourceRefresh;
        private System.Windows.Forms.Button btnResourceDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox edtModuleSearch;
        private System.Windows.Forms.ListView moduleListView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModuleAdd;
        private System.Windows.Forms.Button btnModuleRefresh;
        private System.Windows.Forms.Button btnModuleDelete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
    }
}