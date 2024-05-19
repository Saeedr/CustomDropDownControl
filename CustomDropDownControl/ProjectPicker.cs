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
    public partial class ProjectPicker : DropDownControl
    {
        private bool isUpdating;
        public ProjectPicker()
        {
            isUpdating = true;
            InitializeComponent();
            InitializeDropDown(panel1);
            //treeView1.SelectedNode = treeView1.Nodes[0];
            isUpdating = false;
        }

        public event EventHandler ProjectStageChanged;

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (isUpdating || this.DropState != eDropState.Dropped) return;

            this.CloseDropDown();
            this.Text = this.Stage + " Stage";
            if (ProjectStageChanged != null)
                ProjectStageChanged(null, null);
        }

        public string Stage
        {
            get {return treeView1.SelectedNode.Text;}
        }

    }
}
