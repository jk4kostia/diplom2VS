using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom2VSring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double flow;    //kg/s
        double D;       //m
        double R;       //m
        double dp;      //pa
        double ro;      //kg/m3
        double ap;      //pa

        bool skipcalc = false;

        double ToStandartData(NumericUpDown nud, ComboBox cb)
        {
            double result = (double)nud.Value;

            switch (cb.SelectedItem)
            {
                case "м":
                case "Па":
                case "кг/м^3":
                case "м^3/с":
                    return result * 1;
                case "г/см^3":
                case "мм":
                    return result * 0.001;
                case "КПа":
                    return result * 1000;
                case "МПа":
                    return result * 1000000;
                case "т/год":
                    return result * ro / 3.6;
                case "кг/с":
                    return result * ro;
                case "м^3/год":
                    return result / 3600;
                default:
                    throw new NotImplementedException();
            }
        }

        decimal ToDisplayedData(double value, ComboBox cb)
        {
            decimal result = (decimal)value;

            switch (cb.SelectedItem)
            {
                case "м":
                case "Па":
                case "кг/м^3":
                case "м^3/с":
                    return result * 1;
                case "г/см^3":
                case "мм":
                    return result / (decimal)0.001;
                case "КПа":
                    return result / 1000;
                case "МПа":
                    return result / 1000000;
                case "т/год":
                    return result * (decimal)3.6 / (decimal)ro;
                case "кг/с":
                    return result / (decimal)ro;
                case "м^3/год":
                    return result * (decimal)3600;
                default:
                    throw new NotImplementedException();
            }
        }

        void hideZerosNUD(NumericUpDown nud)
        {
            var str = nud.Value.ToString().Replace(',', '.');
            if (str.Length == 0) return;
            else if (str.Contains("."))
            {
                var decstr = str.Split('.')[1];
                for (int i = 0; i < decstr.Length; i++)
                {
                    if (decstr[i] != '0')
                    {
                        nud.DecimalPlaces = i + 2 < 6 ? i + 2 : 6;
                        break;
                    }
                }
            }
            else
                nud.DecimalPlaces = 0;
        }

        private void Calculate(object sender, EventArgs e)
        {
            if (skipcalc) return;

            ro = ToStandartData(numericUDdensity, comboBdensity);
            flow = ToStandartData(numericUDflow, comboBflow);
            D = ToStandartData(numericUDtubediameter, comboBtubediameter);
            R = ToStandartData(numericUDradius, comboBradius);
            dp = ToStandartData(numericUDdiffpressure, comboBdiffpress);
            ap = ToStandartData(numericUDabspress, comboBabspress);

            if (radioBdiffpress.Checked)
            {
                numericUDdiffpressure.Enabled = false;
                numericUDflow.Enabled = true;
                numericUDradius.Enabled = true;

                dp = (8*ro*Math.Pow(flow, 2))/(Math.Pow(D, 3)*R);

                skipcalc = true;
                numericUDdiffpressure.Value = ToDisplayedData(dp, comboBdiffpress);
            }
            else if (radioBflow.Checked)
            {
                numericUDdiffpressure.Enabled = true;
                numericUDflow.Enabled = false;
                numericUDradius.Enabled = true;

                flow = Math.Pow(D / 2.0, 2) * Math.Sqrt(Math.Log((ap + dp) / ap)) * Math.Sqrt((R * dp) / (D * ro / 2));

                skipcalc = true;
                numericUDflow.Value = ToDisplayedData(flow, comboBflow);
            }
            else if (radioBradius.Checked)
            {
                numericUDdiffpressure.Enabled = true;
                numericUDflow.Enabled = true;
                numericUDradius.Enabled = false;

                R = (8*ro*Math.Pow(flow,2)) / (dp*Math.Pow(D,3)*Math.Log((ap + dp) / ap));

                skipcalc = true;
                numericUDradius.Value = ToDisplayedData(R, comboBradius);
            }

            hideZerosNUD(numericUDdensity);
            hideZerosNUD(numericUDflow);
            hideZerosNUD(numericUDtubediameter);
            hideZerosNUD(numericUDradius);
            hideZerosNUD(numericUDdiffpressure);
            hideZerosNUD(numericUDabspress);

            labelD.Text = $"Ø{Math.Round(D * 1000, 2)}";
            labelR.Text = $"R{Math.Round(R * 1000, 2)}";
            labelCalc.Text = $"Q = {Math.Round(Math.Pow(D / 2.0, 2) * Math.Sqrt(Math.Log((ap + dp) / ap)),5)}*√({Math.Round(Math.Sqrt(R / (D * ro / 2)), 5)}*Δp)\nQ - {(comboBflow.SelectedItem.ToString().Contains("кг") ? "масова" : "об'ємна")} витрата [{comboBflow.SelectedItem}]\nΔp - різниця тисків [{comboBdiffpress.SelectedItem}]";

            skipcalc = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skipcalc = true;
            comboBdensity.SelectedIndex = 0;
            comboBflow.SelectedIndex = 2;
            comboBtubediameter.SelectedIndex = 1;
            comboBradius.SelectedIndex = 1;
            comboBdiffpress.SelectedIndex = 0;
            comboBabspress.SelectedIndex = 1;

            hideZerosNUD(numericUDdensity);
            hideZerosNUD(numericUDflow);
            hideZerosNUD(numericUDtubediameter);
            hideZerosNUD(numericUDradius);
            hideZerosNUD(numericUDdiffpressure);
            hideZerosNUD(numericUDabspress);
            skipcalc = false;
            Calculate(sender, e);
        }
    }
}
