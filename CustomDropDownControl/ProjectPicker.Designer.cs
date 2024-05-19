namespace CustomDropDownControl
{
    partial class ProjectPicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Concept");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Design");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Production");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Sales and Marketing");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Project Stage", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Concept";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Design";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Production";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Sales and Marketing";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Project Stage";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(162, 147);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(15, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 147);
            this.panel1.TabIndex = 0;
            // 
            // ProjectPicker
            // 
            this.AnchorSize = new System.Drawing.Size(177, 21);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ProjectPicker";
            this.Size = new System.Drawing.Size(177, 170);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;

    }
}
