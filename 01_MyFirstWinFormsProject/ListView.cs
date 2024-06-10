using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _01_MyFirstWinFormsProject
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmListView_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(TxtName.Text))
                return; 

        
            ListViewItem item = new ListViewItem(txtID.Text.Trim());
            if(rbMale.Checked)
                item.ImageIndex = 0;
            else 
                item.ImageIndex = 1;

            item.SubItems.Add(TxtName.Text.Trim());
            item.SubItems.Add(TxtName.Text.Trim());
            listView1.Items.Add(item);

            txtID.Clear();
            TxtName.Clear();
            txtID.Focus();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);  
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details; 
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++) 
            {
                ListViewItem item = new ListViewItem(i.ToString());

                if (i % 2 == 0)
                {
                    item.ImageIndex = 0;
                    //   item.SubItems.Add(new ListViewItem(txtID.Text.Trim())); 
                }
                else {
                    item.ImageIndex = 1;
                }
                item.SubItems.Add($"person{i}");
                listView1.Items.Add(item);
            }
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon; 
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View= View.SmallIcon; 
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;

        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;

        }
    }
}
