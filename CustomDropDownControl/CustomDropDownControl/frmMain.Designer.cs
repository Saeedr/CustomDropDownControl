namespace CustomDropDownControl
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
            this.lblProject = new System.Windows.Forms.Label();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.employeePicker1 = new CustomDropDownControl.EmployeePicker();
            this.projectStage1 = new CustomDropDownControl.ProjectPicker();
            this.quickColor1 = new Unity3.Controls.QuickColor();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProject
            // 
            this.lblProject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProject.Location = new System.Drawing.Point(301, 22);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(119, 93);
            this.lblProject.TabIndex = 1;
            this.lblProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEmployee
            // 
            this.pbEmployee.Location = new System.Drawing.Point(318, 130);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(80, 80);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployee.TabIndex = 4;
            this.pbEmployee.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(315, 213);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 44);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Employee Name: ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // employeePicker1
            // 
            this.employeePicker1.AnchorSize = new System.Drawing.Size(185, 21);
            this.employeePicker1.BackColor = System.Drawing.Color.White;
            this.employeePicker1.DockSide = Unity3.Controls.DropDownControl.eDockSide.Left;
            this.employeePicker1.Location = new System.Drawing.Point(21, 105);
            this.employeePicker1.Name = "employeePicker1";
            this.employeePicker1.Size = new System.Drawing.Size(185, 21);
            this.employeePicker1.TabIndex = 3;
            this.employeePicker1.EmployeeChanged += new System.EventHandler(this.employeePicker1_EmployeeChanged);
            // 
            // projectStage1
            // 
            this.projectStage1.AnchorSize = new System.Drawing.Size(185, 21);
            this.projectStage1.BackColor = System.Drawing.Color.White;
            this.projectStage1.DockSide = Unity3.Controls.DropDownControl.eDockSide.Left;
            this.projectStage1.ForeColor = System.Drawing.Color.Black;
            this.projectStage1.Location = new System.Drawing.Point(21, 62);
            this.projectStage1.Name = "projectStage1";
            this.projectStage1.Size = new System.Drawing.Size(185, 21);
            this.projectStage1.TabIndex = 2;
            this.projectStage1.ProjectStageChanged += new System.EventHandler(this.projectStage1_ProjectStageChanged);
            // 
            // quickColor1
            // 
            this.quickColor1.AnchorSize = new System.Drawing.Size(185, 21);
            this.quickColor1.BackColor = System.Drawing.Color.White;
            this.quickColor1.Color = System.Drawing.Color.White;
            this.quickColor1.DockSide = Unity3.Controls.DropDownControl.eDockSide.Right;
            this.quickColor1.Location = new System.Drawing.Point(21, 22);
            this.quickColor1.Name = "quickColor1";
            this.quickColor1.Size = new System.Drawing.Size(185, 21);
            this.quickColor1.TabIndex = 0;
            this.quickColor1.ColorChanged += new System.EventHandler(this.quickColor1_ColorChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 266);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.employeePicker1);
            this.Controls.Add(this.projectStage1);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.quickColor1);
            this.Name = "frmMain";
            this.Text = "Drop Down Control Demo - Unity3 Software";
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Unity3.Controls.QuickColor quickColor1;
        private System.Windows.Forms.Label lblProject;
        private ProjectPicker projectStage1;
        private EmployeePicker employeePicker1;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label lblName;
    }
}

