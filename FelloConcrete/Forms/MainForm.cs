using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelloConcrete
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetUp();

        }
        private void SetUp()
        {
            SidePanel.Height = ButtonBending.Height;
            SidePanel.Top = ButtonBending.Top;
            bendingControl1.BringToFront();
        }

        private void ButtonZginanie_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ButtonBending.Height;
            SidePanel.Top = ButtonBending.Top;
            bendingControl1.BringToFront();
        }

        private void ButtonScinanie_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ButtonShear.Height;
            SidePanel.Top = ButtonShear.Top;
            shearControl1.BringToFront();
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        Point lastPoint;

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }
        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
           
        }




        //int _mouseX = 0, _mouseY = 0;
        //bool _mouseDown;

        //private void panel2_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (_mouseDown)
        //    {
        //        _mouseX = MousePosition.X - 420;
        //        _mouseY = MousePosition.Y - 17;
        //        this.SetDesktopLocation(_mouseX, _mouseY);
        //    }
        //}

        //private void panel2_MouseUp(object sender, MouseEventArgs e)
        //{
        //    _mouseDown = false;
        //}

        //private void panel2_MouseDown(object sender, MouseEventArgs e)
        //{
        //    _mouseDown = true;
        //}
    }
}
