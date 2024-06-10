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
    public partial class frmNotifiIcon : Form
    {
        public frmNotifiIcon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true; 
            // تعيين أيقونة صالحة (مثلاً أيقونة التطبيق)
            notifyIcon1.Icon = SystemIcons.Application;

            // تعيين تفاصيل البالون (BalloonTip)
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle = "هذا هو العنوان";
            notifyIcon1.BalloonTipText = "هذه هي الرسالة";
            // عرض البالون
            notifyIcon1.ShowBalloonTip(10000);

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("biibbbibibibi"); 
        }
    }
}
