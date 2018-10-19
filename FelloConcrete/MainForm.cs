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
            SidePanel.Height = buttonBending.Height;
            SidePanel.Top = buttonBending.Top;
            bendingControl1.BringToFront();
        }

        private void buttonZginanie_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonBending.Height;
            SidePanel.Top = buttonBending.Top;
            bendingControl1.BringToFront();
        }

        private void buttonScinanie_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonShear.Height;
            SidePanel.Top = buttonShear.Top;
            shearControl1.BringToFront();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        Point lastPoint;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
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
