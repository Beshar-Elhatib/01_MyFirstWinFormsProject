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
    public partial class frmDrawing : Form
    {
        public frmDrawing()
        {
            InitializeComponent();
        }

        private void Cizimler(object sender, PaintEventArgs e)
        {
            Color green = Color.Green; 
            Pen pen =new Pen(green);
            pen.Width = 20; 
            pen.StartCap=System.Drawing.Drawing2D.LineCap.Round;/* حددت بداية الخط دائرة */
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round; /* حددت نهاية  الخط دائرة */

            e.Graphics.DrawLine(pen,15, 150, 150, 150); 
            e.Graphics.DrawRectangle(pen, 100, 100, 100, 100); 
            e.Graphics.DrawEllipse(pen,50,50,50,50); 
     
        }

        private void frmDrawing_Load(object sender, EventArgs e)
        {

        }
    }
}
