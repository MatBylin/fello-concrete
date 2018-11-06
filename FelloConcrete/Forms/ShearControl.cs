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
    public partial class ShearControl : UserControl
    {
        public ShearControl()
        {
            InitializeComponent();
            SetUp();
        }

        private void SetUp()
        {
            ComboBoxShearSteele.SelectedIndex = 1;
            ComboBoxShearConcrete.SelectedIndex = 3;
            ComboBoxShearN.SelectedIndex = 0;
            ComboBoxShearFi.SelectedIndex = 1;
        }

        private void ButtonScinanieObliczenia_Click(object sender, EventArgs e)
        {
            //otrzymanie wartości z pól
            var b = double.Parse(TextBoxShearB.Text);
            var h = double.Parse(TextBoxShearH.Text);
            var a = double.Parse(TextBoxShearA.Text);
            var aS = double.Parse(TextBoxShearAs.Text);
            var v = Math.Abs(double.Parse(TextBoxShearV.Text));
            var n = double.Parse(ComboBoxShearN.Text);
            var fi = double.Parse(ComboBoxShearFi.Text);

            string nameConcrete = ComboBoxShearConcrete.Text;
            string nameSteele = ComboBoxShearSteele.Text;

            double d, pow, powAs;

            d = (h - a);
            pow = b * h / 100;
            powAs = Math.Round((fi * fi * 3.14 / 400) , 3);

            labelBendingD.Text = powAs + "";
        }
    }
}
