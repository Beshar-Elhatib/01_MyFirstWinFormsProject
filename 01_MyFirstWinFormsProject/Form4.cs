using _01_MyFirstWinFormsProject.Properties;
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
    public partial class pbPicureBox : Form
    {
        public pbPicureBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.لقطة_شاشة_2024_03_15_064006; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Screenshot_2024_04_25_222417;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ميزة التحميل من القرص أفضل مابتثقل حجم التطبيق 
            // بي Resources بضل اسرع 
            pictureBox1.Image = Image.FromFile(@"C:\Users\Beshar Elhatib\Pictures\Screenshots\Screenshot 2024-05-12 125905.png");
        }
    }
}
