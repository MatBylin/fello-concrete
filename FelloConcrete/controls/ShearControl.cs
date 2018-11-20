using System;
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

            double d, pow, powAs, fck, fcd, fyd, fyk, fctm;
            double vRdc, vRds, vRdmax, roStrzemion, roMin, sRozstawFloor;
            //string warning;

            var ctgt = 1; // Cotangens teta od 1 do 2
            d = (h - a);
            pow = b * h / 100;
            powAs = Math.Round((fi * fi * 3.14 / 400), 3);

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
            fyd = Math.Round((fyk / 1.15), 2);

            //obiekty BeamShear
            BeamShearCalculation bsc = new BeamShearCalculation();
            BeamShearResults result = bsc.Calculate(d, b, fck, n, powAs, fyd, pow, aS, v);
            vRdc = result.VRdc;
            vRds = result.VRds;
            vRdmax = result.VRdmax;
            roStrzemion = result.RoStrzemion;
            roMin = result.RoMin;
            sRozstawFloor = result.RozstawFloor;

            labelShearCtgt.Text = ctgt + "";
            labelShearVrdc.Text = vRdc + "";
            labelShearVrds.Text = vRds + "";
            labelShearVrdmax.Text = vRdmax + "";
            labelShearFcd.Text = fcd + "";
            labelShearFyd.Text = fyd + "";
            labelShearRomin.Text = roMin + "";
            labelShearRow.Text = roStrzemion + "";
            if (v < vRdc)
            {
                labelShearWarn.Text = "Ved < Vrdc : strzemiona dobrać konstrukcyjnie";
                labelShearResult.Text = "konstrukcyjne";
            }
            else
            {
                labelShearWarn.Text = "";
                labelShearResult.Text = "Φ" + fi + " co:  " + sRozstawFloor + " cm";
            }
        }

        private void TextBoxShearB_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void TextBoxShearH_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void TextBoxShearA_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void TextBoxShearAs_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void TextBoxShearV_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(sender, e);
        }

        private void OnlyDigit(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != ',')
            {
                e.Handled = true;
            }
        }
    }
}