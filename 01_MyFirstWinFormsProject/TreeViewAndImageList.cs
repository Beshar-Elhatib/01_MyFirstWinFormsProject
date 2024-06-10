using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_MyFirstWinFormsProject
{
    public partial class frmTreeViewAndImageList : Form
    {
        public frmTreeViewAndImageList()
        {
            InitializeComponent();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeViewNode(e.Node, e.Node.Checked); 
        }
        private void TreeViewNode(TreeNode node, Boolean isChicked) {
            foreach(TreeNode item in node.Nodes)
            {
                item.Checked = isChicked;
                if(item.Nodes.Count > 0)
                {
                    this.TreeViewNode(item, isChicked);
                }
            }
        }
    }
}
