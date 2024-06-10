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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnShowPart1_Click(object sender, EventArgs e)
        {
            Form for1=new Form1();
            for1.Show()  ; 
          //  for1.ShowDialog();
        }

        private void btnMessageBoxForm_Click(object sender, EventArgs e)
        {
            Form form1=new Form2();
            form1.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fr1 =new gbSize();
            fr1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm=new frmTextBox();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form from =new pbPicureBox(); 
            from.ShowDialog(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new frmDrawing() ; 
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new frmMaskedTextBox(); 
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new formComboBox1(); 
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form = new formLinkLable();
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form form = new frmDateTimePicker();
            form.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Form form = new frmMonthCalander();
            form.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form frm = new frmTimer();
            frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form frm = new frmNotifiIcon();
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form frm = new frmTreeViewAndImageList();
            frm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form frm = new frmProgressBar();
            frm.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form frm = new frmListView();
            frm.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form frm = new frmErrorProvider();
            frm.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form frm = new frmTrackBar();
            frm.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form frm = new frmNumaricUpDowncs();
            frm.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form frm = new frmTabControl();
            frm.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form frm = new frmPanel();
            frm.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form frm = new frmColorDialog();
            frm.ShowDialog();
        }
    }
}
