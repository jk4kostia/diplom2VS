using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom2VSrotameter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skipcalc = true;
            comboBdensity.SelectedIndex = 0;
            comboBdenspoplavok.SelectedIndex = 0;
            comboBdpoplavok.SelectedIndex = 1;
            comboBflow.SelectedIndex = 3;
            comboBtubediameter.SelectedIndex = 1;
            comboBsqaredist.SelectedIndex = 0;
            skipcalc = false;
            Calculate(sender, e);
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

        double ToStandartData(NumericUpDown nud, ComboBox cb)
        {
            double result = (double)nud.Value;

            switch (cb.SelectedItem)
            {
                case "м":
                case "м^2":
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
                case "мм^2":
                    return result / 1000000;
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
                case "м^2":
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
                case "мм^2":
                    return result * 1000000;
                case "м^3/год":
                    return result * (decimal)3600;
                default:
                    throw new NotImplementedException();
            }
        }

        double flow;    //kg/s
        double Dpoplavok;       //m
        double ropoplavok;     //kg/m3
        double ro;      //kg/m3
        double V;       //m3
        double fpoplavok;       //m2
        double fkzazor;      //m2

        bool skipcalc = false;

        private void Calculate(object sender, EventArgs e)
        {
            if (skipcalc) return;

            ropoplavok = ToStandartData(numericUDdenspoplavok, comboBdenspoplavok);
            ro = ToStandartData(numericUDdensity, comboBdensity);

            Dpoplavok = ToStandartData(numericUDdpoplavok, comboBdpoplavok);
            fkzazor = ToStandartData(numericUDsqaredist, comboBsqaredist);
            flow = ToStandartData(numericUDflow, comboBflow);

            V = (Math.Pow((Dpoplavok / 4), 2) * Math.PI * Dpoplavok + (Math.PI * Dpoplavok / 4 * Math.Pow(Dpoplavok / 4, 2) + Dpoplavok / 4 + Dpoplavok / 2 + Math.Pow(Dpoplavok / 2, 2)) / 3 - (Math.Pow(Dpoplavok / 4,2) * Math.PI) * Dpoplavok / 4);

            fpoplavok = Math.Pow(Dpoplavok / 2, 2) * Math.PI;

            if (radioBsqaredist.Checked)
            {
                numericUDdpoplavok.Enabled = true;
                numericUDflow.Enabled = true;
                numericUDsqaredist.Enabled = false;

                fkzazor = (2*Math.Sqrt(3*Math.PI)*flow) / (0.75*Math.Sqrt(-((5*Math.PI*Math.Pow(Dpoplavok, 2)+8*Dpoplavok+24)*9.81*(ro-ropoplavok))/(Dpoplavok*ro)));

                skipcalc = true;
                numericUDsqaredist.Value = ToDisplayedData(fkzazor, comboBsqaredist);
            }
            else if (radioBflow.Checked)
            {
                numericUDdpoplavok.Enabled = true;
                numericUDflow.Enabled = false;
                numericUDsqaredist.Enabled = true;

                flow = 0.75 * fkzazor * Math.Sqrt((2*9.81*V*(ropoplavok-ro)) / (ro*fpoplavok));

                skipcalc = true;
                numericUDflow.Value = ToDisplayedData(flow, comboBflow);
            }
            else if (radioBdpoplavok.Checked)
            {
                numericUDdpoplavok.Enabled = false;
                numericUDflow.Enabled = true;
                numericUDsqaredist.Enabled = true;

                Dpoplavok = (-Math.Sqrt(Math.Pow((-(12 * Math.PI * ro * flow * flow) / (0.5625 * Math.Pow(fkzazor, 2)) - 8 * 9.81 * ro + 8 * 9.81 * ropoplavok), 2) + 4 * Math.PI * 96.2361 * (24 * ro - 24 * ropoplavok) * (5 * ropoplavok - 5 * ro)) + (12 * Math.PI * ro * flow * flow) / (0.5625 * Math.Pow(fkzazor, 2)) + 8 * 9.81 * ro - 8 * 9.81 * ropoplavok) / (10 * Math.PI * (9.81 * ropoplavok - 9.81 * ro));
                
                skipcalc = true;
                numericUDdpoplavok.Value = ToDisplayedData(Dpoplavok, comboBdpoplavok);
            }

            labelA.Text = $"{Math.Round(Dpoplavok * 1000, 2)}";
            labelB.Text = $"{Math.Round(Dpoplavok/2 * 1000, 2)}";
            labelD.Text = $"{Math.Round(Dpoplavok * 1000, 2)}";
            labeldd.Text = $"{Math.Round(Dpoplavok/2 * 1000, 2)}";

            hideZerosNUD(numericUDdensity);
            hideZerosNUD(numericUDdenspoplavok);
            hideZerosNUD(numericUDdpoplavok);
            hideZerosNUD(numericUDflow);
            hideZerosNUD(numericUDsqaredist);
            hideZerosNUD(numericUDtubediameter);
            
            skipcalc = false;
            labelflowtext.Text = $"Q = {Math.Round(0.75 * Math.Sqrt((2 * 9.81 * V * (ropoplavok - ro)) / (ro * fpoplavok)), 5)}*fk\nQ - {(comboBflow.SelectedItem.ToString().Contains("кг") ? "масова" : "об'ємна")} витрата [{comboBflow.SelectedItem}]\nfk - площа зазору [{comboBsqaredist.SelectedItem}]"; ;
        }
    }
}
