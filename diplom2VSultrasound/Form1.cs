using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom2VSultrasound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ToStandartData(NumericUpDown nud, ComboBox cb)
        {
            double result = (double)nud.Value;

            switch (cb.SelectedItem)
            {
                case "рад":
                case "м":
                case "м^2":
                case "Па":
                case "кг/м^3":
                case "м^3/с":
                case "м/с":
                case "Гц":
                    return result * 1;
                case "км/год":
                    return 1000*result/ 3600;
                case "г/см^3":
                case "мм":
                    return result * 0.001;
                case "кПа":
                case "кГц":
                    return result * 1000;
                case "МПа":
                case "МГц":
                    return result * 1000000;
                case "мм^2":
                    return result / 1000000;
                case "т/год":
                    return result * ro / 3.6;
                case "кг/с":
                    return result * ro;
                case "м^3/год":
                    return result / 3600;
                case "°":
                    return result * 180 / Math.PI;
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
                case "м^2":
                case "м/с":
                case "Гц":
                    return result * 1;
                case "км/год":
                    return result * 3600/ 1000;
                case "г/см^3":
                case "мм":
                    return result / (decimal)0.001;
                case "кПа":
                case "кГц":
                    return result / 1000;
                case "МПа":
                case "МГц":
                    return result / 1000000;
                case "т/год":
                    return result * (decimal)3.6 / (decimal)ro;
                case "кг/с":
                    return result / (decimal)ro;
                case "мм^2":
                    return result * 1000000;
                case "м^3/год":
                    return result * (decimal)3600;
                case "°":
                    return result * (decimal)Math.PI / 180;
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

        void Calculate(Object sender, EventArgs e)
        {
            if (skipcalc) return;

            ro = ToStandartData(numericUDdensity, comboBdensity);
            flow = ToStandartData(numericUDflow, comboBflow);
            D = ToStandartData(numericUDtubediameter, comboBtubediameter);
            L = ToStandartData(numericUDdistance, comboBdistance);
            r = Math.Sqrt(Math.Pow(L, 2) * Math.Pow(D, 2));

            theta = Math.Atan(D / L);
            freq = ToStandartData(numericUDfreq, comboBfreq);
            phase = ToStandartData(numericUDphase, comboBphase);
            c = ToStandartData(numericUDsoundspeed, comboBsoundspeed);

            if (radioBphaseMethod.Checked) //phase
            {
                radioBphase.Enabled = true;
                comboBphase.Enabled = true;
                numericUDphase.Enabled = true;
                radioBfreq.Text = "Частота:";

                if (radioBdistance.Checked)
                {
                    numericUDflow.Enabled = true;
                    numericUDfreq.Enabled = true;
                    numericUDphase.Enabled = true;
                    numericUDdistance.Enabled = false;

                    L = Math.Sqrt( Math.Pow((Math.PI*c*c*D*D*phase*ro)/(8*freq*flow), 2) - Math.Pow(D, 2));
                    skipcalc = true;
                    numericUDdistance.Value = ToDisplayedData(L, comboBdistance);
                }
                else if (radioBflow.Checked)
                {
                    numericUDflow.Enabled = false;
                    numericUDfreq.Enabled = true;
                    numericUDphase.Enabled = true;
                    numericUDdistance.Enabled = true;

                    flow = ro*Math.PI*Math.Pow(D/2, 2)*((phase) * Math.Pow(c, 2)) / (2 * freq * r);
                    skipcalc = true;
                    numericUDflow.Value = ToDisplayedData(flow, comboBflow);
                }
                else if (radioBphase.Checked)
                {
                    numericUDflow.Enabled = true;
                    numericUDfreq.Enabled = true;
                    numericUDphase.Enabled = false;
                    numericUDdistance.Enabled = true;

                    phase = (8*freq*r*flow) / (Math.PI*c*c*D*D*ro);
                    skipcalc = true;
                    numericUDphase.Value = ToDisplayedData(phase, comboBphase);
                }
                else if (radioBfreq.Checked)
                {
                    numericUDflow.Enabled = true;
                    numericUDfreq.Enabled = false;
                    numericUDphase.Enabled = true;
                    numericUDdistance.Enabled = true;

                    freq = (Math.PI*c*c*D*D*phase*ro) / (8*r*flow);
                    skipcalc = true;
                    numericUDfreq.Value = ToDisplayedData(freq, comboBfreq);
                }

                labelCalc.Text = $"Q = {Math.Round(ro * Math.PI * Math.Pow(D / 2, 2) * (Math.Pow(c, 2)) / (2 * freq * r), 5)}*Δφ\nQ - {(comboBflow.SelectedItem.ToString().Contains("кг") ? "масова" : "об'ємна")} витрата [{comboBflow.SelectedItem}]\nΔφ - різниця фаз [{comboBphase.SelectedItem}]"; ;
            }
            else if (radioBfreqMethod.Checked) //freq
            {
                radioBphase.Enabled = false;
                comboBphase.Enabled = false;
                numericUDphase.Enabled = false;
                radioBfreq.Text = "Різниця частот:";

                if (radioBphase.Checked) radioBfreq.Checked = true;
                
                if (radioBdistance.Checked)
                {
                    numericUDflow.Enabled = true;
                    numericUDfreq.Enabled = true;
                    numericUDdistance.Enabled = false;

                    L = Math.Sqrt( Math.Pow((4 * flow * Math.Cos(theta)) / (Math.PI * D * D * freq * ro), 2) - Math.Pow(D, 2));
                    skipcalc = true;
                    numericUDdistance.Value = ToDisplayedData(L, comboBdistance);
                }
                else if (radioBflow.Checked)
                {
                    numericUDflow.Enabled = false;
                    numericUDfreq.Enabled = true;
                    numericUDdistance.Enabled = true;

                    flow = ro * Math.PI * Math.Pow(D / 2, 2) * ((freq * r) / Math.Cos(theta));
                    skipcalc = true;
                    numericUDflow.Value = ToDisplayedData(flow, comboBflow);
                }
                else if (radioBfreq.Checked)
                {
                    numericUDflow.Enabled = true;
                    numericUDfreq.Enabled = false;
                    numericUDdistance.Enabled = true;

                    freq = (4*flow*Math.Cos(theta)) / (Math.PI*D*D*r*ro);
                    skipcalc = true;
                    numericUDfreq.Value = ToDisplayedData(freq, comboBfreq);
                }

                labelCalc.Text = $"Q = {Math.Round(ro * Math.PI * Math.Pow(D / 2, 2) * (r / Math.Cos(theta)), 5)}*Δω\nQ - {(comboBflow.SelectedItem.ToString().Contains("кг") ? "масова" : "об'ємна")} витрата [{comboBflow.SelectedItem}]\nΔω - різниця частот [{comboBfreq.SelectedItem}]"; ;
            }

            hideZerosNUD(numericUDdensity);
            hideZerosNUD(numericUDdistance);
            hideZerosNUD(numericUDflow);
            hideZerosNUD(numericUDfreq);
            hideZerosNUD(numericUDphase);
            hideZerosNUD(numericUDsoundspeed);
            hideZerosNUD(numericUDtubediameter);

            labelD.Text = $"⌀{Math.Round(D * 1000, 2)}";
            labelL.Text = $"{Math.Round(L * 1000, 2)}";
            labelfi.Text = $"{Math.Round(theta * 180/Math.PI, 2)}°";

            skipcalc = false;            
        }

        double flow;    //kg/s
        double L;       //m
        double freq;     //Hz
        double phase;      //rad
        double D;       //m
        double c;       //m/s
        double ro;       //kg/m^3
        double theta;   //rad
        double r;   //m

        bool skipcalc = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            skipcalc = true;
            comboBdistance.SelectedIndex = 1;
            comboBflow.SelectedIndex = 0;
            comboBfreq.SelectedIndex = 1;
            comboBphase.SelectedIndex = 0;
            comboBsoundspeed.SelectedIndex = 0;
            comboBtubediameter.SelectedIndex = 1;
            comboBdensity.SelectedIndex = 0;
            skipcalc = false;
            Calculate(sender, e);
        }
    }
}
