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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is a message! ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is a message! ", "This is a title koko");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure ?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("User Pressd Ok"); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2); 
        }
    }
}
