using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomDropDownControl
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void quickColor1_ColorChanged(object sender, EventArgs e)
        {
            lblProject.BackColor = quickColor1.Color;
        }

        private void projectStage1_ProjectStageChanged(object sender, EventArgs e)
        {
            lblProject.Text = "We are currently in the: " + projectStage1.Stage + " stage.";
        }

        private void employeePicker1_EmployeeChanged(object sender, EventArgs e)
        {
            pbEmployee.Image = employeePicker1.EmployeePhoto;
            lblName.Text = "Employee Name:\n" + employeePicker1.EmployeeName;
        }
    }
}
