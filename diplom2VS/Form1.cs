using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom2VS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<TabPage> tabs = new List<TabPage>();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (TabPage i in tabControl1.TabPages)
            {
                tabs.Add(i);
            }
            ignoreupdate = true;
            //label8.Text = "Ø4";
            //label12.Text = "45°";
            //label11.Text = "5";
            //label13.Text = "Ø100";
            //label9.Text = "R0,01";
            //label14.Text = "Ø60";
            //label10.Text = "2,5";

            comboBflow.SelectedIndex = 0;
            comboBtubediameter.SelectedIndex = 1;
            comboBdeltapressure.SelectedIndex = 0;
            comboBdesteny.SelectedIndex = 0;
            comboBdiameterdevice.SelectedIndex = 1;
            comboBviscousity.SelectedIndex = 0;

            numericUDflowrate.Value = 10;
            numericUDtubeDiameter.Value = 100;
            numericUDdiameterdevice.Value = 75;

            ignoreupdate = false;

            OnGlobalParametersUpdate(sender, e);
        }
        bool ignoreupdate = false;

        bool error = false;
        double eps = 1; //expansion coefficient //

        double C; //discharge coefficient
        double d; //diameter of device [m]
        double beta;//ratio between diameters
        double D;// tube diameter [m]//
        double ro;//desteny of material[kg/m^3] //
        double dP;//delta pressure[Pa]
        double ReD;
        double Qm;//[kg/s]
        double u;//[Pa*s]

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
                        nud.DecimalPlaces = i+2 < 6 ? i + 2 : 6;
                        break;
                    }
                }
            }
            else
                nud.DecimalPlaces = 0;
        }

        void OnGlobalValuesChanged(object sender, EventArgs e)
        {
            hideZerosNUD(numericUDdeltapressure);
            hideZerosNUD(numericUDdestiny);
            hideZerosNUD(numericUDdiameterdevice);
            hideZerosNUD(numericUDflowrate);
            hideZerosNUD(numericUDGeometryValue);
            hideZerosNUD(numericUDtubeDiameter);
            hideZerosNUD(numericUDviscousity);


            if (ignoreupdate) return;
            if (radioBdiameterDevice.Checked)
            {
                numericUDdiameterdevice.ReadOnly = true;
                numericUDflowrate.ReadOnly = false;
                numericUDdeltapressure.ReadOnly = false;
            }
            else if (radioBnormalflowrate.Checked)
            {
                numericUDdiameterdevice.ReadOnly = false;
                numericUDflowrate.ReadOnly = true;
                numericUDdeltapressure.ReadOnly = false;
            }
            else if (radioBpressuredifference.Checked)
            {
                numericUDdiameterdevice.ReadOnly = false;
                numericUDflowrate.ReadOnly = false;
                numericUDdeltapressure.ReadOnly = true;
            }

            error = false;
            //initialisation
            D = (double)numericUDtubeDiameter.Value * (comboBtubediameter.SelectedIndex == 1 ? 0.001 : 1);
            ro = (double)numericUDdestiny.Value * (comboBdesteny.SelectedIndex == 1 ? 0.001 : 1);
            u = (double)numericUDviscousity.Value; if (comboBviscousity.SelectedIndex != 0) throw new NotImplementedException();

            if (radioBdiameterDevice.Checked)
            {
                Qm = (double)numericUDflowrate.Value; if (comboBflow.SelectedIndex != 0) throw new NotImplementedException();
                dP = comboBdeltapressure.SelectedIndex == 0 ? 
                    (double)numericUDdeltapressure.Value : 
                    comboBdeltapressure.SelectedIndex == 1 ?
                    (double)numericUDdeltapressure.Value * 1000 :
                    (double)numericUDdeltapressure.Value * 1000000;
                ReD = (4 * Qm) / (Math.PI * u * D);
                beta = 0.65; //default
                d = D*beta; //default
                C = 0.8; //default
            }
            else if (radioBnormalflowrate.Checked)
            {
                d = (double)numericUDdiameterdevice.Value;
                dP = (double)numericUDdeltapressure.Value; if (comboBdeltapressure.SelectedIndex != 0) throw new NotImplementedException();
                beta = d / D;
                ReD = 500000; //default
                C = 0.8; //default
                Qm = 1000; //default
            }
            else if (radioBpressuredifference.Checked)
            {
                Qm = (double)numericUDflowrate.Value; if (comboBflow.SelectedIndex != 0) throw new NotImplementedException();
                d = (double)numericUDdiameterdevice.Value * (comboBdiameterdevice.SelectedIndex == 1 ? 0.001 : 1);
                beta = d / D;
                ReD = (4 * Qm) / (Math.PI * u * D);
                C = 0.8; //default
                dP = 10000; //default
            }

            if (radioBTypeVenturiTube.Checked)
            {
                if (radioBvtcast.Checked)
                {
                    if (!((0.1 <= D) && (D <= 0.8)
                        && (0.3 <= beta) && (beta <= 0.75)
                        && (200000 <= ReD) && (ReD <= 2000000)))
                    {
                        error = true;
                    }
                    C = 0.984;
                }
                else if (radioBvtmachined.Checked)
                {
                    if (!((0.05 <= D) && (D <= 0.25)
                    && (0.4 <= beta) && (beta <= 0.75)
                    && (200000 <= ReD) && (ReD <= 1000000)))
                    {
                        error = true;
                    }
                    C = 0.995;
                }
                else if (radioBvtwelded.Checked)
                {
                    if (!((0.2 <= D) && (D <= 1.2)
                    && (0.4 <= beta) && (beta <= 0.7)
                    && (200000 <= ReD) && (ReD <= 2000000)))
                    {
                        error = true;
                    }
                    C = 0.985;
                }
                VTR3 = 10 * d * 1000;
            }
            else if (radioBTypeDiafragma.Checked)
            {
                if (!(d <= 0.125 
                        && ReD >= (beta > 0.56 ? 16000*beta*beta : 5000)
                        && (0.05 <= D) && (D <= 1)
                        && (0.1 <= beta) && (beta <= 0.75)))
                {
                    error = true;
                }

                C = 0.5961 + 0.0261 * Math.Pow(beta, 2) - 0.216 * Math.Pow(beta, 8) + 0.000521 *
                    Math.Pow((Math.Pow(10, 6) * beta) / ReD, 0.7) + (0.0188 + 0.0063 * Math.Pow((19000 * beta) / ReD, 0.8)) *
                    Math.Pow(beta, 3.5) * Math.Pow(Math.Pow(10, 6) / ReD, 0.3) + (0.043 + 0.08 - 0.123) *
                    (1 - 0.11 * Math.Pow((19000 * beta) / ReD, 0.8)) * (Math.Pow(beta, 4) / (1 - Math.Pow(beta, 4)));
                if (D < 71.12) C += 0.011 * (0.75 - beta) * (2.8 - D / 25.4);

                DSe = 0.01 * (D * 1000);
                DE = 0.02 * (D * 1000);
                DG = 0.0004 * (d * 1000);
            }
            else if (radioBTypeNozzle.Checked)
            {
                if (!(ReD >= 10000000)
                    && ((beta >= 0.44 ? 20000 : 70000) >= ReD)
                        && (0.05 <= D) && (D <= 0.5)
                        && (0.3 <= beta) && (beta <= 0.8))
                {
                    error = true;
                }

                C = 0.99 - 0.2262 * Math.Pow(beta, 4.1) - (0.00175 * Math.Pow(beta, 2) - 0.0033 * Math.Pow(beta, 4.15)) * Math.Pow(1000000 / ReD, 1.15);

                if (radioBNozzleISA.Checked)
                    NE = 0.1 * (D * 1000); //is max
                else if (radioBNozzleIEllipse.Checked)
                    NE = 0.15 * (D * 1000);// min - 3mm max - 0.15D
               
                if (d <= 2.0*D/3.0)
                    Nod = 0.6041 * (d * 1000);
                else //B type
                    Nod = (0.4041 + Math.Sqrt((0.75 / beta) - (0.25 / Math.Pow(beta, 2)) - 0.5225)) * (d * 1000);

                NR2 = (d*1000)/3;
                Ndn = 5* (d * 1000) / 6;
                NR1 = 0.2 * (d*1000);
                Nen = 0.75*(d*1000);
                Nfn = 0.2*(d*1000);
                Nan = 0.3041 * (d*1000);
                Nbn = 0.3 * (d * 1000);
                Ncn = 1.06 * (d * 1000);
                Ngn = 0.03 * (d * 1000);

                Nae = (D/2 * 1000);
                Nbe = 0.6*(d*1000);
                Nde = ((D-d)*1000/2);
                Nfe = 3;//min
                Nhe = d + (2*a*2+a)*2;
                Nge = (D / 2 * 1000);
            }

            Cc = 0.2 * (D * 1000);

            Cf = a * 2;
            Ch = a;
            Cg = Cf;

            if (beta > 1)
            {
                error = true;
                return;
            }
            if (radioBdiameterDevice.Checked)
            {
                d = (Math.Pow(2,0.75)*D*Math.Sqrt(Qm)) / (Math.Pow((eps*eps*Math.PI*Math.PI*C*C*D*D*D*D*dP*ro+8*Math.Sqrt(Qm)),0.25));
                if (d > D) error = true;
                radioBdiameterDevice.ForeColor = error ? Color.Red : Color.Black;
                radioBnormalflowrate.ForeColor = Color.Black;
                radioBpressuredifference.ForeColor = Color.Black;

                numericUDdiameterdevice.Value = (decimal)d * (comboBdiameterdevice.SelectedIndex == 1 ? 1000 : 1);
            }
            else if (radioBnormalflowrate.Checked)
            {
                radioBnormalflowrate.ForeColor = error ? Color.Red : Color.Black;
                radioBpressuredifference.ForeColor = Color.Black;
                radioBdiameterDevice.ForeColor = Color.Black;

                Qm = (C / Math.Sqrt(1 - Math.Pow(beta, 4))) * eps * (Math.PI / 4) * Math.Pow(d, 2) * Math.Sqrt(2 * dP * ro);
                numericUDflowrate.Value = (decimal)Qm; if (comboBflow.SelectedIndex != 0) throw new NotImplementedException();
            }
            else if (radioBpressuredifference.Checked)
            {
                radioBpressuredifference.ForeColor = error ? Color.Red : Color.Black;
                radioBnormalflowrate.ForeColor = Color.Black;
                radioBdiameterDevice.ForeColor = Color.Black;

                dP = Math.Pow((Qm*Math.Sqrt(1-Math.Pow(beta,4)))/(C*eps*Math.Pow(d,2)*Math.PI/4),2) / (2 * ro);
                
                numericUDdeltapressure.Value = comboBdeltapressure.SelectedIndex == 0 ?
                    (decimal)dP :
                    comboBdeltapressure.SelectedIndex == 1 ?
                    (decimal)dP / 1000 :
                    (decimal)dP / 1000000;
            }
            
            labelFormula.Text = $"Q = {Math.Round((C / Math.Sqrt(1 - Math.Pow(beta, 4)))*(Math.PI / 4) * Math.Pow(d, 2),5)}*√({Math.Round(2 * ro,5)}*Δp)\nQ - {(comboBflow.SelectedItem.ToString().Contains("кг") ? "масова" : "об'ємна")} витрата [{comboBflow.SelectedItem}]\nΔp - різниця тисків [{comboBdeltapressure.SelectedItem}]";
            OnGlobalParametersUpdate(sender, e);
        }

        double VTfi2 = 10;
        double VTR3;
        double DSalpha = 45;
        double DSe;
        double DE;
        double DG;

        double Cc;
        double Cf;
        double Ch;
        double Cj = 4;
        double Cg;
        double a = 4;

        double NE;
        double Nod;
        double NR1;
        double NR2;
        double Nan;
        double Nbn;
        double Ncn;
        double Ndn;
        double Nen;
        double Nfn;
        double Ngn;

        double Nae;
        double Nbe;
        double Nde;
        double Nfe;
        double Nge;
        double Nhe;

        Label selectedGeometryLabel;

        void OnGeometrySelectEdit(object sender, EventArgs e)
        {
            selectedGeometryLabel = (Label)sender;
            groupBCorrectParameter.Enabled = true;
            double valueBuf;

            switch (selectedGeometryLabel.Name)
            {
                case "labelVTfi2":
                    labelMaxDim.Text = $"Максимум: {15}°";
                    labelMinDim.Text = $"Мінімум: {7}°";
                    valueBuf = VTfi2;
                    numericUDGeometryValue.Maximum = 15;
                    numericUDGeometryValue.Minimum = 7;
                    numericUDGeometryValue.Value = (decimal)valueBuf;
                    break;
                case "labelVTR3":
                    labelMaxDim.Text = $"Максимум: R{Math.Round(15 *(d * 1000), 2)}";
                    labelMinDim.Text = $"Мінімум: R{Math.Round(5 *(d * 1000), 2)}";
                    valueBuf = VTR3;
                    numericUDGeometryValue.Maximum = (decimal)(15 * (d*1000));
                    numericUDGeometryValue.Minimum = (decimal)(5 * (d * 1000));
                    numericUDGeometryValue.Value = (decimal)valueBuf;
                    break;
                case "labelDSCalpha":
                case "labelDSTalpha":
                    labelMaxDim.Text = $"Максимум: {60}°";
                    labelMinDim.Text = $"Мінімум: {30}°";
                    valueBuf = DSalpha;
                    numericUDGeometryValue.Maximum = (decimal)(60);
                    numericUDGeometryValue.Minimum = (decimal)(30);
                    numericUDGeometryValue.Value = (decimal)valueBuf;
                    break;
                case "labelDSCE":
                case "labelDSTE":
                case "labelDDCE":
                case "labelDDTE":
                    labelMaxDim.Text = $"Максимум: {Math.Round(0.05 * (D * 1000), 2)}";
                    labelMinDim.Text = $"Мінімум: {Math.Round(DSe, 2)}";
                    valueBuf = DE;
                    numericUDGeometryValue.Maximum = (decimal)(0.05 * (D*1000));
                    numericUDGeometryValue.Minimum = (decimal)(DSe);
                    numericUDGeometryValue.Value = (decimal)valueBuf;
                    break;
                case "labelDSCee":
                case "labelDSTee":
                    labelMaxDim.Text = $"Максимум: {Math.Round(0.02 * (D * 1000), 2)}";
                    labelMinDim.Text = $"Мінімум: {Math.Round(0.005 * (D * 1000), 2)}";
                    valueBuf = DSe;
                    numericUDGeometryValue.Maximum = (decimal)(0.02 * (D * 1000));
                    numericUDGeometryValue.Minimum = (decimal)(0.005 * (D * 1000));
                    numericUDGeometryValue.Value = (decimal)valueBuf;
                    break;
                case "labelDSCG":
                case "labelDSTG":
                case "labelDDCG":
                case "labelDDTG":
                    labelMaxDim.Text = $"Максимум: R{Math.Round(0.0004 * (d * 1000), 2)}";
                    labelMinDim.Text = $"Мінімум: R{0}";
                    valueBuf = DG;
                    numericUDGeometryValue.Maximum = (decimal)(0.0004 * (d * 1000));
                    numericUDGeometryValue.Minimum = (decimal)(0);
                    numericUDGeometryValue.Value = (decimal)valueBuf;
                    break;
                case "labelDSCa":
                case "labelDSTa":
                case "labelDDCa":
                case "labelDDTa":
                    labelMaxDim.Text = $"Максимум: {10}";
                    labelMinDim.Text = $"Мінімум: {1}";
                    valueBuf = a;
                    numericUDGeometryValue.Maximum = (decimal)(10);
                    numericUDGeometryValue.Minimum = (decimal)(1);
                    numericUDGeometryValue.Value = (decimal)valueBuf;
                    break;
                case "labelDSCgg":
                case "labelDDCgg":
                    labelMaxDim.Text = $"Максимум: {Math.Round(Cc - Cf, 2)}";
                    labelMinDim.Text = $"Мінімум: {Math.Round((Cf * a) / (2 * Ch), 2)}";
                    valueBuf = Cg;
                    numericUDGeometryValue.Maximum = (decimal)(Cc-Cf);
                    numericUDGeometryValue.Minimum = (decimal)((Cf * a) / (2 * Ch));
                    numericUDGeometryValue.Value = (decimal)valueBuf;
                    break;
                case "labelDSCj":
                case "labelDDCj":
                    labelMaxDim.Text = $"Максимум: {10}";
                    labelMinDim.Text = $"Мінімум: {4}";
                    valueBuf = Cj;
                    numericUDGeometryValue.Maximum = (decimal)(10);
                    numericUDGeometryValue.Minimum = (decimal)(4);
                    numericUDGeometryValue.Value = (decimal)valueBuf;
                    break;
                case "labelDSCh":
                case "labelDDCh":
                    labelMaxDim.Text = $"Максимум: {Math.Round(Cc-2*Cf, 2)}";
                    labelMinDim.Text = $"Мінімум: {Math.Round((Cf*a)/(2*Cg), 2)}";
                    valueBuf = Ch;
                    numericUDGeometryValue.Maximum = (decimal)(Cc - 2 * Cf);
                    numericUDGeometryValue.Minimum = (decimal)((Cf * a) / (2 * Cg));
                    numericUDGeometryValue.Value = (decimal)valueBuf;
                    break;
                case "labelDSCf":
                case "labelDDCf":
                    labelMaxDim.Text = $"Максимум: {Math.Round((Cc-Ch)/2, 2)}";
                    labelMinDim.Text = $"Мінімум: {Math.Round(a * 2, 2)}";
                    valueBuf = Cf;
                    numericUDGeometryValue.Maximum = (decimal)((Cc - Ch) / 2);
                    numericUDGeometryValue.Minimum = (decimal)(a * 2);
                    numericUDGeometryValue.Value = (decimal)valueBuf;
                    break;
                case "labelDSCc":
                case "labelDDCc":
                    labelMaxDim.Text = $"Максимум: {Math.Round(0.5 * (D * 1000), 2)}";
                    labelMinDim.Text = $"Мінімум: {Math.Round(Cg + Cf, 2)}";
                    valueBuf = Cc;
                    numericUDGeometryValue.Maximum = (decimal)(0.5 * (D * 1000));
                    numericUDGeometryValue.Minimum = (decimal)(Cg + Cf);
                    numericUDGeometryValue.Value = (decimal)valueBuf;
                    break;
                default:
                    labelMaxDim.Text = "Максимум:";
                    labelMinDim.Text = "Мінімум:";
                    numericUDGeometryValue.Maximum = 0;
                    numericUDGeometryValue.Minimum = 0;
                    numericUDGeometryValue.Value = 0;
                    break;
            }
        }

        void OnGeometryValueEdit(object sender, EventArgs e)
        {
            if (selectedGeometryLabel == null) return;
            switch (selectedGeometryLabel.Name)
            {
                case "labelVTfi2":
                    selectedGeometryLabel.Text = $"{Math.Round(numericUDGeometryValue.Value,2)}°*";
                    VTfi2 = (double)numericUDGeometryValue.Value;
                    break;
                case "labelVTR3":
                    selectedGeometryLabel.Text = $"R{Math.Round(numericUDGeometryValue.Value, 2)}*";
                    VTR3 = (double)numericUDGeometryValue.Value;
                    break;
                case "labelDSCalpha":
                case "labelDSTalpha":
                    selectedGeometryLabel.Text = $"{Math.Round(numericUDGeometryValue.Value, 2)}°*";
                    DSalpha = (double)numericUDGeometryValue.Value;
                    break;
                case "labelDSCE":
                case "labelDSTE":
                case "labelDDCE":
                case "labelDDTE":
                    selectedGeometryLabel.Text = $"{Math.Round(numericUDGeometryValue.Value, 2)}*";
                    DE = (double)numericUDGeometryValue.Value;
                    break;
                case "labelDSCee":
                case "labelDSTee":
                    selectedGeometryLabel.Text = $"{Math.Round(numericUDGeometryValue.Value, 2)}*";
                    DSe = (double)numericUDGeometryValue.Value;
                    break;
                case "labelDSCG":
                case "labelDSTG":
                case "labelDDCG":
                case "labelDDTG":
                    selectedGeometryLabel.Text = $"R{Math.Round(numericUDGeometryValue.Value, 2)}*";
                    DG = (double)numericUDGeometryValue.Value;
                    break;
                case "labelDSCa":
                case "labelDSTa":
                case "labelDDCa":
                case "labelDDTa":
                    selectedGeometryLabel.Text = $"{Math.Round(numericUDGeometryValue.Value, 2)}*";
                    a = (double)numericUDGeometryValue.Value;
                    break;
                case "labelDSCgg":
                case "labelDDCgg":
                    selectedGeometryLabel.Text = $"{Math.Round(numericUDGeometryValue.Value, 2)}*";
                     Cg = (double)numericUDGeometryValue.Value;
                    break;
                case "labelDSCj":
                case "labelDDCj":
                    selectedGeometryLabel.Text = $"{Math.Round(numericUDGeometryValue.Value, 2)}*";
                    Cj = (double)numericUDGeometryValue.Value;
                    break;
                case "labelDSCh":
                case "labelDDCh":
                    selectedGeometryLabel.Text = $"{Math.Round(numericUDGeometryValue.Value, 2)}*";
                    Ch = (double)numericUDGeometryValue.Value;
                    break;
                case "labelDSCf":
                case "labelDDCf":
                    selectedGeometryLabel.Text = $"{Math.Round(numericUDGeometryValue.Value, 2)}*";
                    Cf = (double)numericUDGeometryValue.Value;
                    break;
                case "labelDSCc":
                case "labelDDCc":
                    selectedGeometryLabel.Text = $"{Math.Round(numericUDGeometryValue.Value, 2)}*";
                    Cc = (double)numericUDGeometryValue.Value;
                    break;
                default:
                    break;
            }
        }

        private void OnGlobalParametersUpdate(object sender, EventArgs e)
        {
            if (radioBTypeDiafragma.Checked)
            {
                groupBDiafragmaOptions.Enabled = true;
                groupBNozzleType.Enabled = false;
                groupBVenturiNozzleOptions.Enabled = false;
                groupBFlangeSelect.Enabled = true;
                groupBventuritubeoptions.Enabled = false;

                if (radioBFlangeTube.Checked)
                {
                    if (checkBIsDiafragmDoubleSided.Checked)
                    {
                        selectTab("tabPDiafragma2sTube");

                        labelDDTD.Text = $"Ø{Math.Round(D * 1000, 2)}";
                        labelDDTdd.Text = $"Ø{Math.Round(d * 1000, 2)}";

                        labelDDTE.Text = $"{DE}*";
                        labelDDTG.Text = $"R{DG}*";

                        labelDDTa.Text = $"{a}*";
                    }
                    else
                    {
                        selectTab("tabPDiafragma1sTube");

                        labelDSTD.Text = $"Ø{Math.Round(D * 1000, 2)}";
                        labelDSTdd.Text = $"Ø{Math.Round(d * 1000, 2)}";

                        labelDSTee.Text = $"{DSe}*";
                        labelDSTE.Text = $"{DE}*";
                        labelDSTalpha.Text = $"{DSalpha}°*";
                        labelDSTG.Text = $"R{DG}*";

                        labelDSTa.Text = $"{a}*";
                    }
                }
                else if (radioBFlangeCamera.Checked)
                {
                    if (checkBIsDiafragmDoubleSided.Checked)
                    {
                        selectTab("tabPDiafragma2sCamera");

                        labelDDCD.Text = $"Ø{Math.Round(D * 1000, 2)}";
                        labelDDCdd.Text = $"Ø{Math.Round(d * 1000, 2)}";

                        labelDDCE.Text = $"{DE}*";
                        labelDDCG.Text = $"R{DG}*";

                        labelDDCa.Text = $"{a}*";
                        labelDDCgg.Text = $"{Cg}*";
                        labelDDCj.Text = $"Ø{Cj}*";
                        labelDDCh.Text = $"{Ch}*";
                        labelDDCf.Text = $"{Cf}*";
                        labelDDCc.Text = $"{Cc}*";
                    }
                    else
                    {
                        selectTab("tabPDiafragma1sCamera");

                        labelDSCD.Text = $"Ø{Math.Round(D * 1000, 2)}";
                        labelDSCdd.Text = $"Ø{Math.Round(d * 1000, 2)}";

                        labelDSCee.Text = $"{DSe}*";
                        labelDSCE.Text = $"{DE}*";
                        labelDSCalpha.Text = $"{DSalpha}°*";
                        labelDSCG.Text = $"R{DG}*";

                        labelDSCa.Text = $"{a}*";
                        labelDSCgg.Text = $"{Cg}*";
                        labelDSCj.Text = $"Ø{Cj}*";
                        labelDSCh.Text = $"{Ch}*";
                        labelDSCf.Text = $"{Cf}*";
                        labelDSCc.Text = $"{Cc}*";
                    }
                }
            }
            else if (radioBTypeNozzle.Checked)
            {
                groupBDiafragmaOptions.Enabled = false;
                groupBNozzleType.Enabled = true;
                groupBFlangeSelect.Enabled = true;
                groupBventuritubeoptions.Enabled = false;

                if (radioBNozzleISA.Checked)
                {
                    groupBVenturiNozzleOptions.Enabled = false;

                    if (radioBFlangeTube.Checked)
                    {
                        if (d <= 2.0 * D / 3.0) //type A
                        {
                            selectTab(tabPNozzleATube.Name);

                            labelNIATD.Text = $"Ø{Math.Round(D * 1000, 2)}";
                            labelNIATdd.Text = $"Ø{Math.Round(d * 1000, 2)}";

                            labelNIATE.Text = $"{Math.Round(NE, 2)}*";
                            labelNIATod.Text = $"{Math.Round(Nod, 2)}";
                            labelNIATR2.Text = $"R{Math.Round(NR2, 2)}";
                            labelNIATdn.Text = $"{Math.Round(Ndn, 2)}";
                            labelNIATR1.Text = $"R{Math.Round(NR1, 2)}";
                            labelNIATen.Text = $"{Math.Round(Nen, 2)}";
                            labelNIATfn.Text = $"{Math.Round(Nfn, 2)}";
                            labelNIATan.Text = $"{Math.Round(Nan, 2)}";
                            labelNIATbn.Text = $"{Math.Round(Nbn, 2)}";
                            labelNIATcn.Text = $"{Math.Round(Ncn, 2)}";
                            labelNIATgn.Text = $"{Math.Round(Ngn, 2)}";

                            labelNIATa.Text = $"{a}*";
                        }
                        else //type B
                        {
                            selectTab(tabPNozzleBTube.Name);

                            labelNIBTD.Text = $"Ø{Math.Round(D * 1000, 2)}";
                            labelNIBTdd.Text = $"Ø{Math.Round(d * 1000, 2)}";

                            labelNIBTE.Text = $"{Math.Round(NE, 2)}*";
                            labelNIBTod.Text = $"{Math.Round(Nod, 2)}";
                            labelNIBTR2.Text = $"R{Math.Round(NR2, 2)}";
                            labelNIBTdn.Text = $"{Math.Round(Ndn, 2)}";
                            labelNIBTR1.Text = $"R{Math.Round(NR1, 2)}";
                            labelNIBTen.Text = $"{Math.Round(Nen, 2)}";
                            labelNIBTfn.Text = $"{Math.Round(Nfn, 2)}";
                            labelNIBTan.Text = $"{Math.Round(Nan, 2)}";
                            labelNIBTbn.Text = $"{Math.Round(Nbn, 2)}";
                            labelNIBTcn.Text = $"{Math.Round(Ncn, 2)}";
                            labelNIBTgn.Text = $"{Math.Round(Ngn, 2)}";

                            labelNIBTa.Text = $"{a}*";
                        }
                    }
                    else if (radioBFlangeCamera.Checked)
                    {
                        if (d <= 2.0 * D / 3.0) //type A
                        {
                            selectTab(tabPNozzleACamera.Name);
                            
                            labelNIACD.Text = $"Ø{Math.Round(D * 1000, 2)}";
                            labelNIACdd.Text = $"Ø{Math.Round(d * 1000, 2)}";
                            
                            labelNIACE.Text = $"{Math.Round(NE, 2)}*";
                            labelNIACod.Text = $"{Math.Round(Nod, 2)}";
                            labelNIACR2.Text = $"R{Math.Round(NR2, 2)}";
                            labelNIACdn.Text = $"{Math.Round(Ndn, 2)}";
                            labelNIACR1.Text = $"R{Math.Round(NR1, 2)}";
                            labelNIACen.Text = $"{Math.Round(Nen, 2)}";
                            labelNIACfn.Text = $"{Math.Round(Nfn, 2)}";
                            labelNIACan.Text = $"{Math.Round(Nan, 2)}";
                            labelNIACbn.Text = $"{Math.Round(Nbn, 2)}";
                            labelNIACcn.Text = $"Ø{Math.Round(Ncn, 2)}";
                            labelNIACgn.Text = $"{Math.Round(Ngn, 2)}";

                            labelNIACa.Text = $"{a}*";
                            labelNIACgg.Text = $"{Cg}*";
                            labelNIACj.Text = $"Ø{Cj}*";
                            labelNIACh.Text = $"{Ch}*";
                            labelNIACf.Text = $"{Cf}*";
                            labelNIACc.Text = $"{Cc}*";
                        }
                        else //type B
                        {
                            selectTab(tabPNozzleBCamera.Name);

                            labelNIBCD.Text = $"Ø{Math.Round(D * 1000, 2)}";
                            labelNIBCdd.Text = $"Ø{Math.Round(d * 1000, 2)}";

                            labelNIBCE.Text = $"{Math.Round(NE, 2)}*";
                            labelNIBCod.Text = $"{Math.Round(Nod, 2)}";
                            labelNIBCR2.Text = $"R{Math.Round(NR2, 2)}";
                            labelNIBCdn.Text = $"{Math.Round(Ndn, 2)}";
                            labelNIBCR1.Text = $"R{Math.Round(NR1, 2)}";
                            labelNIBCen.Text = $"{Math.Round(Nen, 2)}";
                            labelNIBCfn.Text = $"{Math.Round(Nfn, 2)}";
                            labelNIBCan.Text = $"{Math.Round(Nan, 2)}";
                            labelNIBCbn.Text = $"{Math.Round(Nbn, 2)}";
                            labelNIBCcn.Text = $"Ø{Math.Round(Ncn, 2)}";
                            labelNIBCgn.Text = $"{Math.Round(Ngn, 2)}";

                            labelNIBCa.Text = $"{Math.Round(a, 2)}*";
                            labelNIBCgg.Text = $"{Math.Round(Cg, 2)}*";
                            labelNIBCj.Text = $"Ø{Math.Round(Cj, 2)}*";
                            labelNIBCh.Text = $"{Math.Round(Ch, 2)}*";
                            labelNIBCf.Text = $"{Math.Round(Cf, 2)}*";
                            labelNIBCc.Text = $"{Math.Round(Cc, 2)}*";
                        }
                    }
                }
                if (radioBNozzleIEllipse.Checked)
                {
                    groupBVenturiNozzleOptions.Enabled = false;

                    if (radioBFlangeTube.Checked)
                    {
                        selectTab(tabPNozzleEATube.Name);

                        labelNEATD.Text = $"Ø{Math.Round(D * 1000, 2)}";
                        labelNEATdd.Text = $"Ø{Math.Round(d * 1000, 2)}";

                        labelNEATE.Text = $"{Math.Round(NE, 2)}";
                        labelNEATde.Text = $"{Math.Round(Nde, 2)}";
                        labelNEATge.Text = $"{Math.Round(Nge, 2)}";
                        labelNEATae.Text = $"{Math.Round(Nae, 2)}";
                        labelNEATbe.Text = $"{Math.Round(Nbe, 2)}";
                        labelNEATfe.Text = $"{Math.Round(Nfe, 2)}";
                        labelNEAThe.Text = $"{Math.Round(Nhe, 2)}";

                        labelNEATa.Text = $"{Math.Round(a, 2)}";
                    }
                    else if (radioBFlangeCamera.Checked)
                    {
                        selectTab(tabPNozzleEACamera.Name);

                        labelNEACD.Text = $"Ø{Math.Round(D * 1000, 2)}";
                        labelNEACdd.Text = $"Ø{Math.Round(d * 1000, 2)}";

                        labelNEACE.Text = $"{Math.Round(NE, 2)}";
                        labelNEACde.Text = $"{Math.Round(Nde, 2)}";
                        labelNEACge.Text = $"{Math.Round(Nge, 2)}";
                        labelNEACae.Text = $"{Math.Round(Nae, 2)}";
                        labelNEACbe.Text = $"{Math.Round(Nbe, 2)}";
                        labelNEACfe.Text = $"{Math.Round(Nfe, 2)}";
                        labelNEAChe.Text = $"{Math.Round(Nhe, 2)}";

                        labelNEACa.Text = $"{Math.Round(a, 2)}";
                        labelNEACc.Text = $"{Math.Round(Cc, 2)}";
                        labelNEACf.Text = $"{Math.Round(Cf, 2)}";
                        labelNEACh.Text = $"{Math.Round(Ch, 2)}";
                        labelNEACj.Text = $"Ø{Math.Round(Cj, 2)}";
                        labelNEACgg.Text = $"{Math.Round(Cg, 2)}";
                    }
                }
                if (radioBNozzleVenturi.Checked)
                {
                    groupBVenturiNozzleOptions.Enabled = true;

                    if (checkBisVenturiNozzleShort.Checked)
                    {
                        if (radioBFlangeTube.Checked)
                        {
                            selectTab("tabPNozzleVATube");
                            /*
                            labelNVATD.Text = $"Ø{Math.Round(D * 1000, 2)}";
                            labelNVATdd.Text = $"Ø{Math.Round(d * 1000, 2)}";

                            labelNVATE.Text = $"{Math.Round(NE, 2)}";
                            labelNVATde.Text = $"{Math.Round(Nde, 2)}";
                            labelNVATge.Text = $"{Math.Round(Nge, 2)}";
                            labelNVATae.Text = $"{Math.Round(Nae, 2)}";
                            labelNVATbe.Text = $"{Math.Round(Nbe, 2)}";
                            labelNVATfe.Text = $"{Math.Round(Nfe, 2)}";
                            labelNVAThe.Text = $"{Math.Round(Nhe, 2)}";

                            labelNVATa.Text = $"{Math.Round(a, 2)}";
                            labelNVATc.Text = $"{Math.Round(Cc, 2)}";
                            labelNVATf.Text = $"{Math.Round(Cf, 2)}";
                            labelNVATh.Text = $"{Math.Round(Ch, 2)}";
                            labelNVATj.Text = $"Ø{Math.Round(Cj, 2)}";
                            labelNVATgg.Text = $"{Math.Round(Cg, 2)}";*/
                        }
                        else if (radioBFlangeCamera.Checked)
                        {
                            selectTab("tabPNozzleVACamera");
                        }
                    }
                    else
                    {
                        if (radioBFlangeTube.Checked)
                        {
                            selectTab("tabPNozzleVBTube");
                        }
                        else if (radioBFlangeCamera.Checked)
                        {
                            selectTab("tabPNozzleVBCamera");
                        }
                    }
                }

            }
            else if (radioBTypeVenturiTube.Checked)
            {
                groupBDiafragmaOptions.Enabled = false;
                groupBNozzleType.Enabled = false;
                groupBVenturiNozzleOptions.Enabled = false;
                groupBFlangeSelect.Enabled = false;
                groupBventuritubeoptions.Enabled = true;

                selectTab("tabPVenturi");

                labelVTD.Text = $"Ø{Math.Round(D*1000, 2)}";
                labelVTdd.Text = $"Ø{Math.Round(d * 1000,2)}";
                labelVTa.Text = $"{Math.Round(d * 1000, 2)}";
                labelVTfi2.Text = $"{VTfi2}°*";
                labelVTfi1.Text = $"{21}°";
                labelVTdt.Text = $"{Math.Round((d * 1000 )/ 2, 2)}";
                labelVTc.Text = $"{Math.Round((D * 1000) /2, 2)}";
                labelVTR1.Text = $"R{Math.Round(1.375*D * 1000,2)}";
                labelVTR2.Text = $"R{Math.Round(3.625*d * 1000,2)}";
                labelVTR3.Text = $"R{Math.Round(VTR3, 2)}*";
            }
        }
        
        void selectTab(string tabName)
        {
            tabControl1.TabPages.Clear();
            var tb = (from TabPage tab in tabs
                      where tab.Name == tabName
                      select tab).First();
            tabControl1.TabPages.Add(tb);
        }
    }
}