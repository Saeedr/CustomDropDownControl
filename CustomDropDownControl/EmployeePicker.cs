using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Unity3.Controls;

namespace CustomDropDownControl
{
    public partial class EmployeePicker : DropDownControl
    {
        
        public EmployeePicker()
        {
            InitializeComponent();
            InitializeDropDown(listView1);
        }

        public event EventHandler EmployeeChanged;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.DropState == eDropState.Dropping || this.DropState == eDropState.Closing) return;
            if (listView1.SelectedItems.Count == 0) return;

            this.Text = listView1.SelectedItems[0].Text;
            this.CloseDropDown();
            if (EmployeeChanged != null)
                EmployeeChanged(null, null);
        }

        public string EmployeeName
        {
            get { return listView1.SelectedItems[0].Text; }
        }

        public Image EmployeePhoto
        {
            get { return imageList1.Images[listView1.SelectedItems[0].ImageIndex]; }
        }
    }
}
