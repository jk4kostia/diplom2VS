
namespace diplom2VSultrasound
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBdensity = new System.Windows.Forms.ComboBox();
            this.numericUDdensity = new System.Windows.Forms.NumericUpDown();
            this.radioBflow = new System.Windows.Forms.RadioButton();
            this.radioBfreq = new System.Windows.Forms.RadioButton();
            this.radioBphase = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioBdistance = new System.Windows.Forms.RadioButton();
            this.comboBphase = new System.Windows.Forms.ComboBox();
            this.numericUDphase = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBfreqMethod = new System.Windows.Forms.RadioButton();
            this.radioBphaseMethod = new System.Windows.Forms.RadioButton();
            this.comboBfreq = new System.Windows.Forms.ComboBox();
            this.numericUDfreq = new System.Windows.Forms.NumericUpDown();
            this.comboBdistance = new System.Windows.Forms.ComboBox();
            this.numericUDdistance = new System.Windows.Forms.NumericUpDown();
            this.comboBflow = new System.Windows.Forms.ComboBox();
            this.comboBsoundspeed = new System.Windows.Forms.ComboBox();
            this.comboBtubediameter = new System.Windows.Forms.ComboBox();
            this.numericUDsoundspeed = new System.Windows.Forms.NumericUpDown();
            this.numericUDtubediameter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUDflow = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCalc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelL = new System.Windows.Forms.Label();
            this.labelfi = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDphase)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDfreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDsoundspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDtubediameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDflow)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Зберегти зображення";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBdensity);
            this.groupBox2.Controls.Add(this.numericUDdensity);
            this.groupBox2.Controls.Add(this.radioBflow);
            this.groupBox2.Controls.Add(this.radioBfreq);
            this.groupBox2.Controls.Add(this.radioBphase);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.radioBdistance);
            this.groupBox2.Controls.Add(this.comboBphase);
            this.groupBox2.Controls.Add(this.numericUDphase);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.comboBfreq);
            this.groupBox2.Controls.Add(this.numericUDfreq);
            this.groupBox2.Controls.Add(this.comboBdistance);
            this.groupBox2.Controls.Add(this.numericUDdistance);
            this.groupBox2.Controls.Add(this.comboBflow);
            this.groupBox2.Controls.Add(this.comboBsoundspeed);
            this.groupBox2.Controls.Add(this.comboBtubediameter);
            this.groupBox2.Controls.Add(this.numericUDsoundspeed);
            this.groupBox2.Controls.Add(this.numericUDtubediameter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUDflow);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 295);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вхідні параметри";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Густина середовища:";
            // 
            // comboBdensity
            // 
            this.comboBdensity.FormattingEnabled = true;
            this.comboBdensity.Items.AddRange(new object[] {
            "кг/м^3",
            "г/см^3"});
            this.comboBdensity.Location = new System.Drawing.Point(284, 82);
            this.comboBdensity.Name = "comboBdensity";
            this.comboBdensity.Size = new System.Drawing.Size(70, 21);
            this.comboBdensity.TabIndex = 39;
            // 
            // numericUDdensity
            // 
            this.numericUDdensity.DecimalPlaces = 6;
            this.numericUDdensity.Location = new System.Drawing.Point(157, 83);
            this.numericUDdensity.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUDdensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDdensity.Name = "numericUDdensity";
            this.numericUDdensity.Size = new System.Drawing.Size(120, 20);
            this.numericUDdensity.TabIndex = 38;
            this.numericUDdensity.Value = new decimal(new int[] {
            997,
            0,
            0,
            0});
            // 
            // radioBflow
            // 
            this.radioBflow.AutoSize = true;
            this.radioBflow.Checked = true;
            this.radioBflow.Location = new System.Drawing.Point(53, 263);
            this.radioBflow.Name = "radioBflow";
            this.radioBflow.Size = new System.Drawing.Size(69, 17);
            this.radioBflow.TabIndex = 37;
            this.radioBflow.TabStop = true;
            this.radioBflow.Text = "Витрата:";
            this.radioBflow.UseVisualStyleBackColor = true;
            this.radioBflow.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // radioBfreq
            // 
            this.radioBfreq.AutoSize = true;
            this.radioBfreq.Location = new System.Drawing.Point(53, 236);
            this.radioBfreq.Name = "radioBfreq";
            this.radioBfreq.Size = new System.Drawing.Size(70, 17);
            this.radioBfreq.TabIndex = 36;
            this.radioBfreq.Text = "Частота:";
            this.radioBfreq.UseVisualStyleBackColor = true;
            this.radioBfreq.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // radioBphase
            // 
            this.radioBphase.AutoSize = true;
            this.radioBphase.Location = new System.Drawing.Point(53, 208);
            this.radioBphase.Name = "radioBphase";
            this.radioBphase.Size = new System.Drawing.Size(90, 17);
            this.radioBphase.TabIndex = 35;
            this.radioBphase.Text = "Різниця фаз:";
            this.radioBphase.UseVisualStyleBackColor = true;
            this.radioBphase.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Вибір вихідного параметру:";
            // 
            // radioBdistance
            // 
            this.radioBdistance.AutoSize = true;
            this.radioBdistance.Location = new System.Drawing.Point(53, 180);
            this.radioBdistance.Name = "radioBdistance";
            this.radioBdistance.Size = new System.Drawing.Size(72, 17);
            this.radioBdistance.TabIndex = 33;
            this.radioBdistance.Text = "Відстань:";
            this.radioBdistance.UseVisualStyleBackColor = true;
            this.radioBdistance.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // comboBphase
            // 
            this.comboBphase.FormattingEnabled = true;
            this.comboBphase.Items.AddRange(new object[] {
            "°",
            "рад"});
            this.comboBphase.Location = new System.Drawing.Point(284, 207);
            this.comboBphase.Name = "comboBphase";
            this.comboBphase.Size = new System.Drawing.Size(70, 21);
            this.comboBphase.TabIndex = 32;
            this.comboBphase.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDphase
            // 
            this.numericUDphase.DecimalPlaces = 6;
            this.numericUDphase.Location = new System.Drawing.Point(157, 207);
            this.numericUDphase.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUDphase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDphase.Name = "numericUDphase";
            this.numericUDphase.Size = new System.Drawing.Size(120, 20);
            this.numericUDphase.TabIndex = 31;
            this.numericUDphase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDphase.ValueChanged += new System.EventHandler(this.Calculate);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBfreqMethod);
            this.groupBox3.Controls.Add(this.radioBphaseMethod);
            this.groupBox3.Location = new System.Drawing.Point(27, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 45);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Метод вимірювання";
            // 
            // radioBfreqMethod
            // 
            this.radioBfreqMethod.AutoSize = true;
            this.radioBfreqMethod.Location = new System.Drawing.Point(210, 18);
            this.radioBfreqMethod.Name = "radioBfreqMethod";
            this.radioBfreqMethod.Size = new System.Drawing.Size(79, 17);
            this.radioBfreqMethod.TabIndex = 6;
            this.radioBfreqMethod.Text = "Частотний";
            this.radioBfreqMethod.UseVisualStyleBackColor = true;
            this.radioBfreqMethod.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // radioBphaseMethod
            // 
            this.radioBphaseMethod.AutoSize = true;
            this.radioBphaseMethod.Checked = true;
            this.radioBphaseMethod.Location = new System.Drawing.Point(22, 18);
            this.radioBphaseMethod.Name = "radioBphaseMethod";
            this.radioBphaseMethod.Size = new System.Drawing.Size(72, 17);
            this.radioBphaseMethod.TabIndex = 5;
            this.radioBphaseMethod.TabStop = true;
            this.radioBphaseMethod.Text = "Фазовий";
            this.radioBphaseMethod.UseVisualStyleBackColor = true;
            this.radioBphaseMethod.CheckedChanged += new System.EventHandler(this.Calculate);
            // 
            // comboBfreq
            // 
            this.comboBfreq.FormattingEnabled = true;
            this.comboBfreq.Items.AddRange(new object[] {
            "Гц",
            "кГц",
            "МГц"});
            this.comboBfreq.Location = new System.Drawing.Point(284, 235);
            this.comboBfreq.Name = "comboBfreq";
            this.comboBfreq.Size = new System.Drawing.Size(70, 21);
            this.comboBfreq.TabIndex = 28;
            this.comboBfreq.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDfreq
            // 
            this.numericUDfreq.DecimalPlaces = 6;
            this.numericUDfreq.Location = new System.Drawing.Point(157, 235);
            this.numericUDfreq.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUDfreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDfreq.Name = "numericUDfreq";
            this.numericUDfreq.Size = new System.Drawing.Size(120, 20);
            this.numericUDfreq.TabIndex = 27;
            this.numericUDfreq.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUDfreq.ValueChanged += new System.EventHandler(this.Calculate);
            // 
            // comboBdistance
            // 
            this.comboBdistance.FormattingEnabled = true;
            this.comboBdistance.Items.AddRange(new object[] {
            "м",
            "мм"});
            this.comboBdistance.Location = new System.Drawing.Point(284, 179);
            this.comboBdistance.Name = "comboBdistance";
            this.comboBdistance.Size = new System.Drawing.Size(70, 21);
            this.comboBdistance.TabIndex = 25;
            this.comboBdistance.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDdistance
            // 
            this.numericUDdistance.DecimalPlaces = 6;
            this.numericUDdistance.Location = new System.Drawing.Point(157, 179);
            this.numericUDdistance.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUDdistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDdistance.Name = "numericUDdistance";
            this.numericUDdistance.Size = new System.Drawing.Size(120, 20);
            this.numericUDdistance.TabIndex = 24;
            this.numericUDdistance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUDdistance.ValueChanged += new System.EventHandler(this.Calculate);
            // 
            // comboBflow
            // 
            this.comboBflow.FormattingEnabled = true;
            this.comboBflow.Items.AddRange(new object[] {
            "кг/с",
            "т/год",
            "м^3/с",
            "м^3/год"});
            this.comboBflow.Location = new System.Drawing.Point(284, 263);
            this.comboBflow.Name = "comboBflow";
            this.comboBflow.Size = new System.Drawing.Size(70, 21);
            this.comboBflow.TabIndex = 16;
            this.comboBflow.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // comboBsoundspeed
            // 
            this.comboBsoundspeed.FormattingEnabled = true;
            this.comboBsoundspeed.Items.AddRange(new object[] {
            "м/с",
            "км/год"});
            this.comboBsoundspeed.Location = new System.Drawing.Point(284, 56);
            this.comboBsoundspeed.Name = "comboBsoundspeed";
            this.comboBsoundspeed.Size = new System.Drawing.Size(70, 21);
            this.comboBsoundspeed.TabIndex = 15;
            this.comboBsoundspeed.SelectedIndexChanged += new System.EventHandler(this.Calculate);
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
            // numericUDsoundspeed
            // 
            this.numericUDsoundspeed.DecimalPlaces = 6;
            this.numericUDsoundspeed.Location = new System.Drawing.Point(157, 56);
            this.numericUDsoundspeed.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUDsoundspeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDsoundspeed.Name = "numericUDsoundspeed";
            this.numericUDsoundspeed.Size = new System.Drawing.Size(120, 20);
            this.numericUDsoundspeed.TabIndex = 13;
            this.numericUDsoundspeed.Value = new decimal(new int[] {
            343,
            0,
            0,
            0});
            this.numericUDsoundspeed.ValueChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDtubediameter
            // 
            this.numericUDtubediameter.DecimalPlaces = 6;
            this.numericUDtubediameter.Location = new System.Drawing.Point(157, 30);
            this.numericUDtubediameter.Maximum = new decimal(new int[] {
            1215752192,
            23,
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
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Швидкість звуку:";
            // 
            // numericUDflow
            // 
            this.numericUDflow.DecimalPlaces = 6;
            this.numericUDflow.Location = new System.Drawing.Point(157, 264);
            this.numericUDflow.Maximum = new decimal(new int[] {
            1215752192,
            23,
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
            this.groupBox1.Location = new System.Drawing.Point(13, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 72);
            this.groupBox1.TabIndex = 12;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelL
            // 
            this.labelL.BackColor = System.Drawing.Color.White;
            this.labelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.Location = new System.Drawing.Point(508, 89);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(100, 23);
            this.labelL.TabIndex = 15;
            this.labelL.Text = "L";
            this.labelL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelfi
            // 
            this.labelfi.BackColor = System.Drawing.Color.White;
            this.labelfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfi.Location = new System.Drawing.Point(409, 193);
            this.labelfi.Name = "labelfi";
            this.labelfi.Size = new System.Drawing.Size(52, 23);
            this.labelfi.TabIndex = 16;
            this.labelfi.Text = "fi";
            this.labelfi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelD
            // 
            this.labelD.BackColor = System.Drawing.Color.White;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.Location = new System.Drawing.Point(672, 224);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(60, 23);
            this.labelD.TabIndex = 17;
            this.labelD.Text = "D";
            this.labelD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelfi);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Автоматизований розрахунок ультразвукового витратоміру";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDphase)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDfreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDsoundspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDtubediameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDflow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBphase;
        private System.Windows.Forms.NumericUpDown numericUDphase;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBfreqMethod;
        private System.Windows.Forms.RadioButton radioBphaseMethod;
        private System.Windows.Forms.ComboBox comboBfreq;
        private System.Windows.Forms.NumericUpDown numericUDfreq;
        private System.Windows.Forms.ComboBox comboBdistance;
        private System.Windows.Forms.NumericUpDown numericUDdistance;
        private System.Windows.Forms.ComboBox comboBflow;
        private System.Windows.Forms.ComboBox comboBsoundspeed;
        private System.Windows.Forms.ComboBox comboBtubediameter;
        private System.Windows.Forms.NumericUpDown numericUDsoundspeed;
        private System.Windows.Forms.NumericUpDown numericUDtubediameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUDflow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCalc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioBdistance;
        private System.Windows.Forms.RadioButton radioBflow;
        private System.Windows.Forms.RadioButton radioBfreq;
        private System.Windows.Forms.RadioButton radioBphase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelfi;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBdensity;
        private System.Windows.Forms.NumericUpDown numericUDdensity;
    }
}

