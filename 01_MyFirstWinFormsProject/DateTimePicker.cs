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
    public partial class frmDateTimePicker : Form
    {
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString()); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text += dateTimePicker1.Text + Environment.NewLine; 
            label1.Text += dateTimePicker1.Value.ToString("dd-MMM-yyyy") + Environment.NewLine; 
            label1.Text += dateTimePicker1.Value.ToString("ddd-MMM-yyyy") + Environment.NewLine; 
            label1.Text += dateTimePicker1.Value.ToString("ddd-MM-yyyy") + Environment.NewLine  ; 
            label1.Text += dateTimePicker1.Value.ToString("dd-MM-yy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd,dd-MMM-yyy");  
        

        }

        private void frmDateTimePicker_Load(object sender, EventArgs e)
        {

        }
    }
}
