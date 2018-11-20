using System;
using System.Drawing;
using System.Windows.Forms;

namespace FelloConcrete
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void ButtonBendingResults_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
