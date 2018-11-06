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
            var b = double.Parse(textBoxBendingB.Text);
            var h = double.Parse(textBoxBendingH.Text);
            var a = double.Parse(textBoxBendingA.Text);
            var m = Math.Abs(double.Parse(textBoxBendingM.Text));
            string nameConcrete = comboBoxBendingConcrete.Text;
            string nameSteele = comboBoxBendingSteele.Text;

            double d, fck, fcd, fyd, fyk, fctm, pow, ni, f, asmax, asmin;
            double as1, as2;
            string warning;

            d = (h - a);
            pow = b * h / 100;

            //Obiekty betonu i stali oraz parametry
            var concrete = new ConcreteProps(nameConcrete);
            var steele = new SteeleProps(nameSteele);

            //wytrzymalosci dla betonu betonu
            var concretePropResult = concrete.ConcretePropResult();
            fctm = concretePropResult.Fctm;
            fck = concretePropResult.Fck;

            //wytrzymalosci dla stali
            var steelePropResult = steele.StleelePropResult();
            fyk = steelePropResult.Fyk;

            fcd = Math.Round((fck / 1.4), 2);
            fyd = Math.Round((fyk/ 1.15), 2);

            //obiekty BeamBend
            BeamBendCalculation bbc = new BeamBendCalculation();
            BeamBendResults result = bbc.Calculate(m, b, d, a, 1, fcd, fyd);
            as1 = result.As1;
            as2 = result.As2;
            ni = result.ni;
            f = result.zasiegStrefySciskanej;
            warning = result.Warning;
            asmin = bbc.CalculationAsmin(b, d, fctm, fyk);
            asmax = bbc.CalculationAsmax(b, d);


            labelBendingFcd.Text = fcd + "";
            labelBendingFyd.Text = fyd + "";
            labelBendingAmin.Text = asmin + "";
            labelBendingAmax.Text = asmax + "";
            labelBendingD.Text = d + "";
            labelBendingA.Text = pow + "";
            labelBendingN.Text = ni + "";
            labelBendingF.Text = f + "";
            labelBendingAs1.Text = as1 + "";
            labelBendingAs2.Text = as2 + "";
            labelBendingWarning.Text = warning;

        }
        private void textBoxBendingB_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void textBoxBendingH_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void textBoxBendingA_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void textBoxBendingM_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void OnlyDigit(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

    }
}
