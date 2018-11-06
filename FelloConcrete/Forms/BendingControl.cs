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
            ComboBoxBendingSteele.SelectedIndex = 1;
            ComboBoxBendingConcrete.SelectedIndex = 3;
        }

        private void ButtonZginanieObliczenia_Click(object sender, EventArgs e)
        {
            //otrzymanie wartości z pól
            var b = double.Parse(TextBoxBendingB.Text);
            var h = double.Parse(TextBoxBendingH.Text);
            var a = double.Parse(TextBoxBendingA.Text);
            var m = Math.Abs(double.Parse(TextBoxBendingM.Text));
            string nameConcrete = ComboBoxBendingConcrete.Text;
            string nameSteele = ComboBoxBendingSteele.Text;

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
        private void TextBoxBendingB_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void TextBoxBendingH_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void TextBoxBendingA_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void TextBoxBendingM_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void OnlyDigit(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 &&ch != ',')
            {
                e.Handled = true;
            }
        }

    }
}
