using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelloConcrete
{
    public partial class BendingControl : UserControl
    {
        public BendingControl()
        {
            InitializeComponent();
            SetUp();
        }
        private void SetUp()
        {
            comboBoxBendingSteele.SelectedIndex = 1;
            comboBoxBendingConcrete.SelectedIndex = 3;
        }

        private void buttonZginanieObliczenia_Click(object sender, EventArgs e)
        {
            var b = float.Parse(textBoxBendingB.Text);
            var h = float.Parse(textBoxBendingH.Text);
            var a = float.Parse(textBoxBendingA.Text);
            var m = float.Parse(textBoxBendingM.Text);
            string nameConcrete = comboBoxBendingConcrete.Text;
            string nameSteele = comboBoxBendingSteele.Text;

            float d, fcd, fyd, fyk, fctm, A, n, f;
            double asmin;
            d = (h - a);
            var concrete = new Concrete(nameConcrete);
            var steele = new Steele(nameSteele);
            fctm = concrete.fctm;
            fyk = steele.fyk;
            fcd = (float)Math.Round((concrete.fck / 1.4), 2);
            fyd = (float)Math.Round((steele.fyk / 1.15), 2);
            asmin = concrete.AsminBending(fyk, fctm, d, b);
            Console.WriteLine(asmin);


            labelBendingFcd.Text = fcd + "";
            labelBendingFyd.Text = fyd + "";
            labelBendingAmin.Text = asmin + "";



        }
        private void textBoxBendingB_KeyPress(object sender, KeyPressEventArgs e)

        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxBendingH_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxBendingA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxBendingM_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

    }
}
