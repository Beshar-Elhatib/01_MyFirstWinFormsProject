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
    public partial class formComboBox1 : Form
    {
        public formComboBox1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbComboBox1.Items.Add("beshar"); 
        }

        private void cbComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbComboBox1.Text); 
        }
    }
}
