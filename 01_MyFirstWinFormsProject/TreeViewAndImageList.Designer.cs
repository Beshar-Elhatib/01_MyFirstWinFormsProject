﻿namespace _01_MyFirstWinFormsProject
{
    partial class frmTreeViewAndImageList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeViewAndImageList));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Boy1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Boy2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Boy", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Girl1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Girl2");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Girl", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "Boy.png");
            this.imageList1.Images.SetKeyName(1, "Girl.png");
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(212, 33);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Boy1";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Boy2";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Boy";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Node5";
            treeNode4.Text = "Girl1";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "Node6";
            treeNode5.Text = "Girl2";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "Node1";
            treeNode6.Text = "Girl";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(383, 353);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // frmTreeViewAndImageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "frmTreeViewAndImageList";
            this.Text = "TreeViewAndImageList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
    }
}