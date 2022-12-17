
namespace diplom2VSring
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUDflow = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCalc = new System.Windows.Forms.Label();
            this.radioBflow = new System.Windows.Forms.RadioButton();
            this.radioBradius = new System.Windows.Forms.RadioButton();
            this.radioBdiffpress = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBabspress = new System.Windows.Forms.ComboBox();
            this.numericUDabspress = new System.Windows.Forms.NumericUpDown();
            this.comboBdiffpress = new System.Windows.Forms.ComboBox();
            this.comboBradius = new System.Windows.Forms.ComboBox();
            this.comboBflow = new System.Windows.Forms.ComboBox();
            this.comboBdensity = new System.Windows.Forms.ComboBox();
            this.comboBtubediameter = new System.Windows.Forms.ComboBox();
            this.numericUDdensity = new System.Windows.Forms.NumericUpDown();
            this.numericUDtubediameter = new System.Windows.Forms.NumericUpDown();
            this.numericUDdiffpressure = new System.Windows.Forms.NumericUpDown();
            this.numericUDradius = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelR = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDflow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDabspress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDtubediameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdiffpressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDradius)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Calculate);
            // 
            // numericUDflow
            // 
            this.numericUDflow.DecimalPlaces = 6;
            this.numericUDflow.Location = new System.Drawing.Point(157, 140);
            this.numericUDflow.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUDflow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDflow.Name = "numericUDflow";
            this.numericUDflow.Size = new System.Drawing.Size(120, 20);
            this.numericUDflow.TabIndex = 1;
            this.numericUDflow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDflow.ValueChanged += new System.EventHandler(this.Calculate);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCalc);
            this.groupBox1.Location = new System.Drawing.Point(12, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формула розрахунку витрати";
            // 
            // labelCalc
            // 
            this.labelCalc.AutoSize = true;
            this.labelCalc.Location = new System.Drawing.Point(6, 25);
            this.labelCalc.Name = "labelCalc";
            this.labelCalc.Size = new System.Drawing.Size(21, 13);
            this.labelCalc.TabIndex = 4;
            this.labelCalc.Text = "Q=";
            // 
            // radioBflow
            // 
            this.radioBflow.AutoSize = true;
            this.radioBflow.Checked = true;
            this.radioBflow.Location = new System.Drawing.Point(44, 140);
            this.radioBflow.Name = "radioBflow";
            this.radioBflow.Size = new System.Drawing.Size(69, 17);
            this.radioBflow.TabIndex = 4;
            this.radioBflow.TabStop = true;
            this.radioBflow.Text = "Витрата:";
            this.radioBflow.UseVisualStyleBackColor = true;
            this.radioBflow.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // radioBradius
            // 
            this.radioBradius.AutoSize = true;
            this.radioBradius.Location = new System.Drawing.Point(44, 166);
            this.radioBradius.Name = "radioBradius";
            this.radioBradius.Size = new System.Drawing.Size(95, 17);
            this.radioBradius.TabIndex = 5;
            this.radioBradius.Text = "Радіус кільця:";
            this.radioBradius.UseVisualStyleBackColor = true;
            this.radioBradius.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // radioBdiffpress
            // 
            this.radioBdiffpress.AutoSize = true;
            this.radioBdiffpress.Location = new System.Drawing.Point(44, 192);
            this.radioBdiffpress.Name = "radioBdiffpress";
            this.radioBdiffpress.Size = new System.Drawing.Size(101, 17);
            this.radioBdiffpress.TabIndex = 6;
            this.radioBdiffpress.Text = "Різниця тисків:";
            this.radioBdiffpress.UseVisualStyleBackColor = true;
            this.radioBdiffpress.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Діаметр трубопроводу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Густина середовища:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBabspress);
            this.groupBox2.Controls.Add(this.numericUDabspress);
            this.groupBox2.Controls.Add(this.comboBdiffpress);
            this.groupBox2.Controls.Add(this.comboBradius);
            this.groupBox2.Controls.Add(this.comboBflow);
            this.groupBox2.Controls.Add(this.comboBdensity);
            this.groupBox2.Controls.Add(this.comboBtubediameter);
            this.groupBox2.Controls.Add(this.numericUDdensity);
            this.groupBox2.Controls.Add(this.numericUDtubediameter);
            this.groupBox2.Controls.Add(this.numericUDdiffpressure);
            this.groupBox2.Controls.Add(this.numericUDradius);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUDflow);
            this.groupBox2.Controls.Add(this.radioBflow);
            this.groupBox2.Controls.Add(this.radioBdiffpress);
            this.groupBox2.Controls.Add(this.radioBradius);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 235);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вхідні параметри";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Тиск середовища (абс.):";
            // 
            // comboBabspress
            // 
            this.comboBabspress.FormattingEnabled = true;
            this.comboBabspress.Items.AddRange(new object[] {
            "Па",
            "КПа",
            "МПа"});
            this.comboBabspress.Location = new System.Drawing.Point(284, 81);
            this.comboBabspress.Name = "comboBabspress";
            this.comboBabspress.Size = new System.Drawing.Size(70, 21);
            this.comboBabspress.TabIndex = 20;
            this.comboBabspress.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDabspress
            // 
            this.numericUDabspress.DecimalPlaces = 6;
            this.numericUDabspress.Location = new System.Drawing.Point(157, 82);
            this.numericUDabspress.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUDabspress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDabspress.Name = "numericUDabspress";
            this.numericUDabspress.Size = new System.Drawing.Size(120, 20);
            this.numericUDabspress.TabIndex = 19;
            this.numericUDabspress.Value = new decimal(new int[] {
            101325,
            0,
            0,
            196608});
            this.numericUDabspress.ValueChanged += new System.EventHandler(this.Calculate);
            // 
            // comboBdiffpress
            // 
            this.comboBdiffpress.FormattingEnabled = true;
            this.comboBdiffpress.Items.AddRange(new object[] {
            "Па",
            "КПа",
            "МПа"});
            this.comboBdiffpress.Location = new System.Drawing.Point(284, 191);
            this.comboBdiffpress.Name = "comboBdiffpress";
            this.comboBdiffpress.Size = new System.Drawing.Size(70, 21);
            this.comboBdiffpress.TabIndex = 18;
            this.comboBdiffpress.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // comboBradius
            // 
            this.comboBradius.FormattingEnabled = true;
            this.comboBradius.Items.AddRange(new object[] {
            "м",
            "мм"});
            this.comboBradius.Location = new System.Drawing.Point(284, 165);
            this.comboBradius.Name = "comboBradius";
            this.comboBradius.Size = new System.Drawing.Size(70, 21);
            this.comboBradius.TabIndex = 17;
            this.comboBradius.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // comboBflow
            // 
            this.comboBflow.FormattingEnabled = true;
            this.comboBflow.Items.AddRange(new object[] {
            "кг/с",
            "т/год",
            "м^3/с",
            "м^3/год"});
            this.comboBflow.Location = new System.Drawing.Point(284, 139);
            this.comboBflow.Name = "comboBflow";
            this.comboBflow.Size = new System.Drawing.Size(70, 21);
            this.comboBflow.TabIndex = 16;
            this.comboBflow.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // comboBdensity
            // 
            this.comboBdensity.FormattingEnabled = true;
            this.comboBdensity.Items.AddRange(new object[] {
            "кг/м^3",
            "г/см^3"});
            this.comboBdensity.Location = new System.Drawing.Point(284, 56);
            this.comboBdensity.Name = "comboBdensity";
            this.comboBdensity.Size = new System.Drawing.Size(70, 21);
            this.comboBdensity.TabIndex = 15;
            this.comboBdensity.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // comboBtubediameter
            // 
            this.comboBtubediameter.FormattingEnabled = true;
            this.comboBtubediameter.Items.AddRange(new object[] {
            "м",
            "мм"});
            this.comboBtubediameter.Location = new System.Drawing.Point(284, 30);
            this.comboBtubediameter.Name = "comboBtubediameter";
            this.comboBtubediameter.Size = new System.Drawing.Size(70, 21);
            this.comboBtubediameter.TabIndex = 14;
            this.comboBtubediameter.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDdensity
            // 
            this.numericUDdensity.DecimalPlaces = 6;
            this.numericUDdensity.Location = new System.Drawing.Point(157, 56);
            this.numericUDdensity.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUDdensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDdensity.Name = "numericUDdensity";
            this.numericUDdensity.Size = new System.Drawing.Size(120, 20);
            this.numericUDdensity.TabIndex = 13;
            this.numericUDdensity.Value = new decimal(new int[] {
            997,
            0,
            0,
            0});
            this.numericUDdensity.ValueChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDtubediameter
            // 
            this.numericUDtubediameter.DecimalPlaces = 6;
            this.numericUDtubediameter.Location = new System.Drawing.Point(157, 30);
            this.numericUDtubediameter.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUDtubediameter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDtubediameter.Name = "numericUDtubediameter";
            this.numericUDtubediameter.Size = new System.Drawing.Size(120, 20);
            this.numericUDtubediameter.TabIndex = 12;
            this.numericUDtubediameter.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUDtubediameter.ValueChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDdiffpressure
            // 
            this.numericUDdiffpressure.DecimalPlaces = 6;
            this.numericUDdiffpressure.Location = new System.Drawing.Point(157, 192);
            this.numericUDdiffpressure.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUDdiffpressure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDdiffpressure.Name = "numericUDdiffpressure";
            this.numericUDdiffpressure.Size = new System.Drawing.Size(120, 20);
            this.numericUDdiffpressure.TabIndex = 11;
            this.numericUDdiffpressure.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUDdiffpressure.ValueChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDradius
            // 
            this.numericUDradius.DecimalPlaces = 6;
            this.numericUDradius.Location = new System.Drawing.Point(157, 166);
            this.numericUDradius.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUDradius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDradius.Name = "numericUDradius";
            this.numericUDradius.Size = new System.Drawing.Size(120, 20);
            this.numericUDradius.TabIndex = 10;
            this.numericUDradius.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUDradius.ValueChanged += new System.EventHandler(this.Calculate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вибір вихідного параметру:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 84);
            this.button1.TabIndex = 10;
            this.button1.Text = "Зберегти зображення";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.BackColor = System.Drawing.Color.White;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelR.Location = new System.Drawing.Point(588, 50);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(23, 24);
            this.labelR.TabIndex = 11;
            this.labelR.Text = "R";
            // 
            // labelD
            // 
            this.labelD.BackColor = System.Drawing.Color.White;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelD.Location = new System.Drawing.Point(532, 332);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(60, 24);
            this.labelD.TabIndex = 12;
            this.labelD.Text = "D";
            this.labelD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(700, 480);
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "Form1";
            this.Text = "Автоматизований розрахунок кільцевого витратоміра";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDflow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDabspress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDtubediameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdiffpressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDradius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUDflow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCalc;
        private System.Windows.Forms.RadioButton radioBflow;
        private System.Windows.Forms.RadioButton radioBradius;
        private System.Windows.Forms.RadioButton radioBdiffpress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUDdiffpressure;
        private System.Windows.Forms.NumericUpDown numericUDradius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUDdensity;
        private System.Windows.Forms.NumericUpDown numericUDtubediameter;
        private System.Windows.Forms.ComboBox comboBdiffpress;
        private System.Windows.Forms.ComboBox comboBradius;
        private System.Windows.Forms.ComboBox comboBflow;
        private System.Windows.Forms.ComboBox comboBdensity;
        private System.Windows.Forms.ComboBox comboBtubediameter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBabspress;
        private System.Windows.Forms.NumericUpDown numericUDabspress;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelD;
    }
}

