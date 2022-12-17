
namespace diplom2VSrotameter
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
            this.label4 = new System.Windows.Forms.Label();
            this.radioBdpoplavok = new System.Windows.Forms.RadioButton();
            this.radioBsqaredist = new System.Windows.Forms.RadioButton();
            this.radioBflow = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBsqaredist = new System.Windows.Forms.ComboBox();
            this.numericUDtubediameter = new System.Windows.Forms.NumericUpDown();
            this.numericUDsqaredist = new System.Windows.Forms.NumericUpDown();
            this.comboBtubediameter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBdenspoplavok = new System.Windows.Forms.ComboBox();
            this.numericUDdenspoplavok = new System.Windows.Forms.NumericUpDown();
            this.comboBflow = new System.Windows.Forms.ComboBox();
            this.comboBdpoplavok = new System.Windows.Forms.ComboBox();
            this.numericUDdpoplavok = new System.Windows.Forms.NumericUpDown();
            this.comboBdensity = new System.Windows.Forms.ComboBox();
            this.numericUDdensity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUDflow = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelflowtext = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeldd = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDtubediameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDsqaredist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdenspoplavok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdpoplavok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDflow)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 57);
            this.button1.TabIndex = 14;
            this.button1.Text = "Зберегти зображення";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.radioBdpoplavok);
            this.groupBox2.Controls.Add(this.radioBsqaredist);
            this.groupBox2.Controls.Add(this.radioBflow);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBsqaredist);
            this.groupBox2.Controls.Add(this.numericUDtubediameter);
            this.groupBox2.Controls.Add(this.numericUDsqaredist);
            this.groupBox2.Controls.Add(this.comboBtubediameter);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBdenspoplavok);
            this.groupBox2.Controls.Add(this.numericUDdenspoplavok);
            this.groupBox2.Controls.Add(this.comboBflow);
            this.groupBox2.Controls.Add(this.comboBdpoplavok);
            this.groupBox2.Controls.Add(this.numericUDdpoplavok);
            this.groupBox2.Controls.Add(this.comboBdensity);
            this.groupBox2.Controls.Add(this.numericUDdensity);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUDflow);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 250);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вхідні параметри";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Вибір вихідного параметру:";
            // 
            // radioBdpoplavok
            // 
            this.radioBdpoplavok.AutoSize = true;
            this.radioBdpoplavok.Location = new System.Drawing.Point(36, 149);
            this.radioBdpoplavok.Name = "radioBdpoplavok";
            this.radioBdpoplavok.Size = new System.Drawing.Size(121, 17);
            this.radioBdpoplavok.TabIndex = 29;
            this.radioBdpoplavok.Text = "Діаметр поплавка:";
            this.radioBdpoplavok.UseVisualStyleBackColor = true;
            this.radioBdpoplavok.Click += new System.EventHandler(this.Calculate);
            // 
            // radioBsqaredist
            // 
            this.radioBsqaredist.AutoSize = true;
            this.radioBsqaredist.Checked = true;
            this.radioBsqaredist.Location = new System.Drawing.Point(36, 208);
            this.radioBsqaredist.Name = "radioBsqaredist";
            this.radioBsqaredist.Size = new System.Drawing.Size(101, 17);
            this.radioBsqaredist.TabIndex = 31;
            this.radioBsqaredist.TabStop = true;
            this.radioBsqaredist.Text = "Площа зазору:";
            this.radioBsqaredist.UseVisualStyleBackColor = true;
            this.radioBsqaredist.Click += new System.EventHandler(this.Calculate);
            // 
            // radioBflow
            // 
            this.radioBflow.AutoSize = true;
            this.radioBflow.Location = new System.Drawing.Point(36, 178);
            this.radioBflow.Name = "radioBflow";
            this.radioBflow.Size = new System.Drawing.Size(69, 17);
            this.radioBflow.TabIndex = 30;
            this.radioBflow.Text = "Витрата:";
            this.radioBflow.UseVisualStyleBackColor = true;
            this.radioBflow.Click += new System.EventHandler(this.Calculate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Діаметр трубопроводу:";
            // 
            // comboBsqaredist
            // 
            this.comboBsqaredist.FormattingEnabled = true;
            this.comboBsqaredist.Items.AddRange(new object[] {
            "мм^2",
            "м^2"});
            this.comboBsqaredist.Location = new System.Drawing.Point(285, 206);
            this.comboBsqaredist.Name = "comboBsqaredist";
            this.comboBsqaredist.Size = new System.Drawing.Size(70, 21);
            this.comboBsqaredist.TabIndex = 28;
            this.comboBsqaredist.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDtubediameter
            // 
            this.numericUDtubediameter.DecimalPlaces = 6;
            this.numericUDtubediameter.Location = new System.Drawing.Point(158, 80);
            this.numericUDtubediameter.Maximum = new decimal(new int[] {
            100000000,
            0,
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
            this.numericUDtubediameter.Click += new System.EventHandler(this.Calculate);
            // 
            // numericUDsqaredist
            // 
            this.numericUDsqaredist.DecimalPlaces = 6;
            this.numericUDsqaredist.Enabled = false;
            this.numericUDsqaredist.Location = new System.Drawing.Point(158, 207);
            this.numericUDsqaredist.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUDsqaredist.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDsqaredist.Name = "numericUDsqaredist";
            this.numericUDsqaredist.Size = new System.Drawing.Size(120, 20);
            this.numericUDsqaredist.TabIndex = 27;
            this.numericUDsqaredist.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDsqaredist.Click += new System.EventHandler(this.Calculate);
            // 
            // comboBtubediameter
            // 
            this.comboBtubediameter.FormattingEnabled = true;
            this.comboBtubediameter.Items.AddRange(new object[] {
            "м",
            "мм"});
            this.comboBtubediameter.Location = new System.Drawing.Point(285, 80);
            this.comboBtubediameter.Name = "comboBtubediameter";
            this.comboBtubediameter.Size = new System.Drawing.Size(70, 21);
            this.comboBtubediameter.TabIndex = 14;
            this.comboBtubediameter.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Густина поплавка:";
            // 
            // comboBdenspoplavok
            // 
            this.comboBdenspoplavok.FormattingEnabled = true;
            this.comboBdenspoplavok.Items.AddRange(new object[] {
            "кг/м^3",
            "г/см^3"});
            this.comboBdenspoplavok.Location = new System.Drawing.Point(285, 51);
            this.comboBdenspoplavok.Name = "comboBdenspoplavok";
            this.comboBdenspoplavok.Size = new System.Drawing.Size(70, 21);
            this.comboBdenspoplavok.TabIndex = 20;
            this.comboBdenspoplavok.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDdenspoplavok
            // 
            this.numericUDdenspoplavok.DecimalPlaces = 6;
            this.numericUDdenspoplavok.Location = new System.Drawing.Point(158, 52);
            this.numericUDdenspoplavok.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUDdenspoplavok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDdenspoplavok.Name = "numericUDdenspoplavok";
            this.numericUDdenspoplavok.Size = new System.Drawing.Size(120, 20);
            this.numericUDdenspoplavok.TabIndex = 19;
            this.numericUDdenspoplavok.Value = new decimal(new int[] {
            7800,
            0,
            0,
            0});
            this.numericUDdenspoplavok.Click += new System.EventHandler(this.Calculate);
            // 
            // comboBflow
            // 
            this.comboBflow.FormattingEnabled = true;
            this.comboBflow.Items.AddRange(new object[] {
            "кг/с",
            "т/год",
            "м^3/с",
            "м^3/год"});
            this.comboBflow.Location = new System.Drawing.Point(285, 177);
            this.comboBflow.Name = "comboBflow";
            this.comboBflow.Size = new System.Drawing.Size(70, 21);
            this.comboBflow.TabIndex = 16;
            this.comboBflow.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // comboBdpoplavok
            // 
            this.comboBdpoplavok.FormattingEnabled = true;
            this.comboBdpoplavok.Items.AddRange(new object[] {
            "м",
            "мм"});
            this.comboBdpoplavok.Location = new System.Drawing.Point(285, 147);
            this.comboBdpoplavok.Name = "comboBdpoplavok";
            this.comboBdpoplavok.Size = new System.Drawing.Size(70, 21);
            this.comboBdpoplavok.TabIndex = 17;
            this.comboBdpoplavok.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDdpoplavok
            // 
            this.numericUDdpoplavok.DecimalPlaces = 6;
            this.numericUDdpoplavok.Location = new System.Drawing.Point(158, 148);
            this.numericUDdpoplavok.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUDdpoplavok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            655360});
            this.numericUDdpoplavok.Name = "numericUDdpoplavok";
            this.numericUDdpoplavok.Size = new System.Drawing.Size(120, 20);
            this.numericUDdpoplavok.TabIndex = 10;
            this.numericUDdpoplavok.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUDdpoplavok.Click += new System.EventHandler(this.Calculate);
            // 
            // comboBdensity
            // 
            this.comboBdensity.FormattingEnabled = true;
            this.comboBdensity.Items.AddRange(new object[] {
            "кг/м^3",
            "г/см^3"});
            this.comboBdensity.Location = new System.Drawing.Point(285, 23);
            this.comboBdensity.Name = "comboBdensity";
            this.comboBdensity.Size = new System.Drawing.Size(70, 21);
            this.comboBdensity.TabIndex = 15;
            this.comboBdensity.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // numericUDdensity
            // 
            this.numericUDdensity.DecimalPlaces = 6;
            this.numericUDdensity.Location = new System.Drawing.Point(158, 23);
            this.numericUDdensity.Maximum = new decimal(new int[] {
            100000000,
            0,
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
            this.numericUDdensity.Click += new System.EventHandler(this.Calculate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Густина середовища:";
            // 
            // numericUDflow
            // 
            this.numericUDflow.DecimalPlaces = 6;
            this.numericUDflow.Location = new System.Drawing.Point(158, 178);
            this.numericUDflow.Maximum = new decimal(new int[] {
            100000000,
            0,
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
            this.numericUDflow.Click += new System.EventHandler(this.Calculate);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelflowtext);
            this.groupBox1.Location = new System.Drawing.Point(12, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 98);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формула розрахунку витрати";
            // 
            // labelflowtext
            // 
            this.labelflowtext.AutoSize = true;
            this.labelflowtext.Location = new System.Drawing.Point(6, 25);
            this.labelflowtext.Name = "labelflowtext";
            this.labelflowtext.Size = new System.Drawing.Size(21, 13);
            this.labelflowtext.TabIndex = 4;
            this.labelflowtext.Text = "Q=";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(384, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labeldd
            // 
            this.labeldd.BackColor = System.Drawing.Color.White;
            this.labeldd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldd.Location = new System.Drawing.Point(676, 76);
            this.labeldd.Name = "labeldd";
            this.labeldd.Size = new System.Drawing.Size(48, 23);
            this.labeldd.TabIndex = 16;
            this.labeldd.Text = "d";
            this.labeldd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(639, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "45°";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelD
            // 
            this.labelD.BackColor = System.Drawing.Color.White;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.Location = new System.Drawing.Point(592, 343);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(92, 23);
            this.labelD.TabIndex = 18;
            this.labelD.Text = "D";
            this.labelD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelB
            // 
            this.labelB.BackColor = System.Drawing.Color.White;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(445, 176);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(48, 23);
            this.labelB.TabIndex = 19;
            this.labelB.Text = "B";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelA
            // 
            this.labelA.BackColor = System.Drawing.Color.White;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(387, 212);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(48, 23);
            this.labelA.TabIndex = 20;
            this.labelA.Text = "A";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labeldd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(800, 480);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Form1";
            this.Text = "Автоматизований розрахунок ротаметру";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDtubediameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDsqaredist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdenspoplavok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdpoplavok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDdensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDflow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBdenspoplavok;
        private System.Windows.Forms.NumericUpDown numericUDdenspoplavok;
        private System.Windows.Forms.ComboBox comboBdpoplavok;
        private System.Windows.Forms.ComboBox comboBflow;
        private System.Windows.Forms.ComboBox comboBdensity;
        private System.Windows.Forms.ComboBox comboBtubediameter;
        private System.Windows.Forms.NumericUpDown numericUDdensity;
        private System.Windows.Forms.NumericUpDown numericUDtubediameter;
        private System.Windows.Forms.NumericUpDown numericUDdpoplavok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUDflow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelflowtext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeldd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.NumericUpDown numericUDsqaredist;
        private System.Windows.Forms.ComboBox comboBsqaredist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioBdpoplavok;
        private System.Windows.Forms.RadioButton radioBsqaredist;
        private System.Windows.Forms.RadioButton radioBflow;
    }
}

