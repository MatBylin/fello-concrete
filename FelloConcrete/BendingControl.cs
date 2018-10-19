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
            float b = float.Parse(textBoxBendingB.Text);
            float h = float.Parse(textBoxBendingH.Text);
            float a = float.Parse(textBoxBendingA.Text);
            float m = float.Parse(textBoxBendingM.Text);

            string nameConcrete = comboBoxBendingConcrete.Text;
            string nameSteele = comboBoxBendingSteele.Text;

        }
        private void Calculate()
        {
             
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
