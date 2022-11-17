
namespace TeruletKeruletTerfogat
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
            this.button12 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alakzatPictureBox = new System.Windows.Forms.PictureBox();
            this.dOldalMertekegyseg = new System.Windows.Forms.ComboBox();
            this.dOldalTextBox = new System.Windows.Forms.TextBox();
            this.dOldal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fOldalMertekegyseg = new System.Windows.Forms.ComboBox();
            this.fOldalTextBox = new System.Windows.Forms.TextBox();
            this.fOldal = new System.Windows.Forms.Label();
            this.eOldalMertekegyseg = new System.Windows.Forms.ComboBox();
            this.eOldalTextBox = new System.Windows.Forms.TextBox();
            this.eOldal = new System.Windows.Forms.Label();
            this.rSugarMertekegyseg = new System.Windows.Forms.ComboBox();
            this.rSugarTextBox = new System.Windows.Forms.TextBox();
            this.sugar = new System.Windows.Forms.Label();
            this.aOldalMagassagMertekegyseg = new System.Windows.Forms.ComboBox();
            this.aOldalMagassagTextBox = new System.Windows.Forms.TextBox();
            this.aOldalMagassag = new System.Windows.Forms.Label();
            this.cOldalMertekegyseg = new System.Windows.Forms.ComboBox();
            this.cOldalTextBox = new System.Windows.Forms.TextBox();
            this.cOldal = new System.Windows.Forms.Label();
            this.bOldalMertekegyseg = new System.Windows.Forms.ComboBox();
            this.aOldalMertekegyseg = new System.Windows.Forms.ComboBox();
            this.bOldalTextBox = new System.Windows.Forms.TextBox();
            this.bOldal = new System.Windows.Forms.Label();
            this.aOldalTextBox = new System.Windows.Forms.TextBox();
            this.aOldal = new System.Windows.Forms.Label();
            this.gulaGomb = new System.Windows.Forms.Button();
            this.hengerGomb = new System.Windows.Forms.Button();
            this.teglalapGomb = new System.Windows.Forms.Button();
            this.paralelogrammaGomb = new System.Windows.Forms.Button();
            this.trapezGomb = new System.Windows.Forms.Button();
            this.haromszogGomb = new System.Windows.Forms.Button();
            this.gombGomb = new System.Windows.Forms.Button();
            this.korGomb = new System.Windows.Forms.Button();
            this.negyzetGomb = new System.Windows.Forms.Button();
            this.rombuszGomb = new System.Windows.Forms.Button();
            this.deltoidGomb = new System.Windows.Forms.Button();
            this.mOldalMertekegyseg = new System.Windows.Forms.ComboBox();
            this.mOldalTextBox = new System.Windows.Forms.TextBox();
            this.mOldal = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alakzatPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(379, 397);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(147, 41);
            this.button12.TabIndex = 27;
            this.button12.Text = "Számold ki!";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(248, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "T=?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(50, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "K=?";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.alakzatPictureBox);
            this.panel2.Location = new System.Drawing.Point(377, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 306);
            this.panel2.TabIndex = 26;
            // 
            // alakzatPictureBox
            // 
            this.alakzatPictureBox.Location = new System.Drawing.Point(27, 20);
            this.alakzatPictureBox.Name = "alakzatPictureBox";
            this.alakzatPictureBox.Size = new System.Drawing.Size(360, 200);
            this.alakzatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alakzatPictureBox.TabIndex = 14;
            this.alakzatPictureBox.TabStop = false;
            // 
            // dOldalMertekegyseg
            // 
            this.dOldalMertekegyseg.FormattingEnabled = true;
            this.dOldalMertekegyseg.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km"});
            this.dOldalMertekegyseg.Location = new System.Drawing.Point(192, 463);
            this.dOldalMertekegyseg.Name = "dOldalMertekegyseg";
            this.dOldalMertekegyseg.Size = new System.Drawing.Size(54, 21);
            this.dOldalMertekegyseg.TabIndex = 14;
            this.dOldalMertekegyseg.Text = "mm";
            this.dOldalMertekegyseg.Visible = false;
            // 
            // dOldalTextBox
            // 
            this.dOldalTextBox.Location = new System.Drawing.Point(84, 464);
            this.dOldalTextBox.Name = "dOldalTextBox";
            this.dOldalTextBox.Size = new System.Drawing.Size(90, 20);
            this.dOldalTextBox.TabIndex = 13;
            this.dOldalTextBox.Visible = false;
            // 
            // dOldal
            // 
            this.dOldal.AutoSize = true;
            this.dOldal.Location = new System.Drawing.Point(8, 466);
            this.dOldal.Name = "dOldal";
            this.dOldal.Size = new System.Drawing.Size(41, 13);
            this.dOldal.TabIndex = 12;
            this.dOldal.Text = "d oldal:";
            this.dOldal.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mOldalMertekegyseg);
            this.panel1.Controls.Add(this.aOldalMertekegyseg);
            this.panel1.Controls.Add(this.cOldal);
            this.panel1.Controls.Add(this.mOldalTextBox);
            this.panel1.Controls.Add(this.bOldalMertekegyseg);
            this.panel1.Controls.Add(this.cOldalTextBox);
            this.panel1.Controls.Add(this.mOldal);
            this.panel1.Controls.Add(this.bOldalTextBox);
            this.panel1.Controls.Add(this.cOldalMertekegyseg);
            this.panel1.Controls.Add(this.fOldalMertekegyseg);
            this.panel1.Controls.Add(this.bOldal);
            this.panel1.Controls.Add(this.aOldalMagassag);
            this.panel1.Controls.Add(this.fOldalTextBox);
            this.panel1.Controls.Add(this.aOldalTextBox);
            this.panel1.Controls.Add(this.aOldalMagassagTextBox);
            this.panel1.Controls.Add(this.fOldal);
            this.panel1.Controls.Add(this.aOldal);
            this.panel1.Controls.Add(this.aOldalMagassagMertekegyseg);
            this.panel1.Controls.Add(this.eOldalMertekegyseg);
            this.panel1.Controls.Add(this.dOldal);
            this.panel1.Controls.Add(this.dOldalTextBox);
            this.panel1.Controls.Add(this.eOldalTextBox);
            this.panel1.Controls.Add(this.dOldalMertekegyseg);
            this.panel1.Controls.Add(this.sugar);
            this.panel1.Controls.Add(this.eOldal);
            this.panel1.Controls.Add(this.rSugarTextBox);
            this.panel1.Controls.Add(this.rSugarMertekegyseg);
            this.panel1.Location = new System.Drawing.Point(122, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 371);
            this.panel1.TabIndex = 25;
            // 
            // fOldalMertekegyseg
            // 
            this.fOldalMertekegyseg.FormattingEnabled = true;
            this.fOldalMertekegyseg.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km"});
            this.fOldalMertekegyseg.Location = new System.Drawing.Point(192, 592);
            this.fOldalMertekegyseg.Name = "fOldalMertekegyseg";
            this.fOldalMertekegyseg.Size = new System.Drawing.Size(54, 21);
            this.fOldalMertekegyseg.TabIndex = 23;
            this.fOldalMertekegyseg.Text = "mm";
            this.fOldalMertekegyseg.Visible = false;
            // 
            // fOldalTextBox
            // 
            this.fOldalTextBox.Location = new System.Drawing.Point(84, 593);
            this.fOldalTextBox.Name = "fOldalTextBox";
            this.fOldalTextBox.Size = new System.Drawing.Size(90, 20);
            this.fOldalTextBox.TabIndex = 22;
            this.fOldalTextBox.Visible = false;
            // 
            // fOldal
            // 
            this.fOldal.AutoSize = true;
            this.fOldal.Location = new System.Drawing.Point(8, 595);
            this.fOldal.Name = "fOldal";
            this.fOldal.Size = new System.Drawing.Size(38, 13);
            this.fOldal.TabIndex = 21;
            this.fOldal.Text = "f oldal:";
            this.fOldal.Visible = false;
            // 
            // eOldalMertekegyseg
            // 
            this.eOldalMertekegyseg.FormattingEnabled = true;
            this.eOldalMertekegyseg.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km"});
            this.eOldalMertekegyseg.Location = new System.Drawing.Point(192, 566);
            this.eOldalMertekegyseg.Name = "eOldalMertekegyseg";
            this.eOldalMertekegyseg.Size = new System.Drawing.Size(54, 21);
            this.eOldalMertekegyseg.TabIndex = 20;
            this.eOldalMertekegyseg.Text = "mm";
            this.eOldalMertekegyseg.Visible = false;
            // 
            // eOldalTextBox
            // 
            this.eOldalTextBox.Location = new System.Drawing.Point(84, 567);
            this.eOldalTextBox.Name = "eOldalTextBox";
            this.eOldalTextBox.Size = new System.Drawing.Size(90, 20);
            this.eOldalTextBox.TabIndex = 19;
            this.eOldalTextBox.Visible = false;
            // 
            // eOldal
            // 
            this.eOldal.AutoSize = true;
            this.eOldal.Location = new System.Drawing.Point(8, 569);
            this.eOldal.Name = "eOldal";
            this.eOldal.Size = new System.Drawing.Size(41, 13);
            this.eOldal.TabIndex = 18;
            this.eOldal.Text = "e oldal:";
            this.eOldal.Visible = false;
            // 
            // rSugarMertekegyseg
            // 
            this.rSugarMertekegyseg.FormattingEnabled = true;
            this.rSugarMertekegyseg.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km"});
            this.rSugarMertekegyseg.Location = new System.Drawing.Point(192, 539);
            this.rSugarMertekegyseg.Name = "rSugarMertekegyseg";
            this.rSugarMertekegyseg.Size = new System.Drawing.Size(54, 21);
            this.rSugarMertekegyseg.TabIndex = 17;
            this.rSugarMertekegyseg.Text = "mm";
            this.rSugarMertekegyseg.Visible = false;
            // 
            // rSugarTextBox
            // 
            this.rSugarTextBox.Location = new System.Drawing.Point(84, 540);
            this.rSugarTextBox.Name = "rSugarTextBox";
            this.rSugarTextBox.Size = new System.Drawing.Size(90, 20);
            this.rSugarTextBox.TabIndex = 16;
            this.rSugarTextBox.Visible = false;
            // 
            // sugar
            // 
            this.sugar.AutoSize = true;
            this.sugar.Location = new System.Drawing.Point(8, 542);
            this.sugar.Name = "sugar";
            this.sugar.Size = new System.Drawing.Size(42, 13);
            this.sugar.TabIndex = 15;
            this.sugar.Text = "r sugár:";
            this.sugar.Visible = false;
            // 
            // aOldalMagassagMertekegyseg
            // 
            this.aOldalMagassagMertekegyseg.FormattingEnabled = true;
            this.aOldalMagassagMertekegyseg.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km"});
            this.aOldalMagassagMertekegyseg.Location = new System.Drawing.Point(192, 501);
            this.aOldalMagassagMertekegyseg.Name = "aOldalMagassagMertekegyseg";
            this.aOldalMagassagMertekegyseg.Size = new System.Drawing.Size(54, 21);
            this.aOldalMagassagMertekegyseg.TabIndex = 11;
            this.aOldalMagassagMertekegyseg.Text = "mm";
            // 
            // aOldalMagassagTextBox
            // 
            this.aOldalMagassagTextBox.Location = new System.Drawing.Point(84, 502);
            this.aOldalMagassagTextBox.Name = "aOldalMagassagTextBox";
            this.aOldalMagassagTextBox.Size = new System.Drawing.Size(90, 20);
            this.aOldalMagassagTextBox.TabIndex = 10;
            // 
            // aOldalMagassag
            // 
            this.aOldalMagassag.AutoSize = true;
            this.aOldalMagassag.Location = new System.Drawing.Point(8, 496);
            this.aOldalMagassag.Name = "aOldalMagassag";
            this.aOldalMagassag.Size = new System.Drawing.Size(58, 26);
            this.aOldalMagassag.TabIndex = 9;
            this.aOldalMagassag.Text = "a oldal\r\nmagasság:";
            // 
            // cOldalMertekegyseg
            // 
            this.cOldalMertekegyseg.FormattingEnabled = true;
            this.cOldalMertekegyseg.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km"});
            this.cOldalMertekegyseg.Location = new System.Drawing.Point(192, 425);
            this.cOldalMertekegyseg.Name = "cOldalMertekegyseg";
            this.cOldalMertekegyseg.Size = new System.Drawing.Size(54, 21);
            this.cOldalMertekegyseg.TabIndex = 8;
            this.cOldalMertekegyseg.Text = "mm";
            this.cOldalMertekegyseg.Visible = false;
            // 
            // cOldalTextBox
            // 
            this.cOldalTextBox.Location = new System.Drawing.Point(84, 426);
            this.cOldalTextBox.Name = "cOldalTextBox";
            this.cOldalTextBox.Size = new System.Drawing.Size(90, 20);
            this.cOldalTextBox.TabIndex = 7;
            this.cOldalTextBox.Visible = false;
            // 
            // cOldal
            // 
            this.cOldal.AutoSize = true;
            this.cOldal.Location = new System.Drawing.Point(8, 428);
            this.cOldal.Name = "cOldal";
            this.cOldal.Size = new System.Drawing.Size(41, 13);
            this.cOldal.TabIndex = 6;
            this.cOldal.Text = "c oldal:";
            this.cOldal.Visible = false;
            // 
            // bOldalMertekegyseg
            // 
            this.bOldalMertekegyseg.FormattingEnabled = true;
            this.bOldalMertekegyseg.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km"});
            this.bOldalMertekegyseg.Location = new System.Drawing.Point(192, 385);
            this.bOldalMertekegyseg.Name = "bOldalMertekegyseg";
            this.bOldalMertekegyseg.Size = new System.Drawing.Size(54, 21);
            this.bOldalMertekegyseg.TabIndex = 5;
            this.bOldalMertekegyseg.Text = "mm";
            // 
            // aOldalMertekegyseg
            // 
            this.aOldalMertekegyseg.FormattingEnabled = true;
            this.aOldalMertekegyseg.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km"});
            this.aOldalMertekegyseg.Location = new System.Drawing.Point(192, 350);
            this.aOldalMertekegyseg.Name = "aOldalMertekegyseg";
            this.aOldalMertekegyseg.Size = new System.Drawing.Size(54, 21);
            this.aOldalMertekegyseg.TabIndex = 4;
            this.aOldalMertekegyseg.Text = "mm";
            // 
            // bOldalTextBox
            // 
            this.bOldalTextBox.Location = new System.Drawing.Point(84, 386);
            this.bOldalTextBox.Name = "bOldalTextBox";
            this.bOldalTextBox.Size = new System.Drawing.Size(90, 20);
            this.bOldalTextBox.TabIndex = 3;
            // 
            // bOldal
            // 
            this.bOldal.AutoSize = true;
            this.bOldal.Location = new System.Drawing.Point(8, 388);
            this.bOldal.Name = "bOldal";
            this.bOldal.Size = new System.Drawing.Size(41, 13);
            this.bOldal.TabIndex = 2;
            this.bOldal.Text = "b oldal:";
            // 
            // aOldalTextBox
            // 
            this.aOldalTextBox.Location = new System.Drawing.Point(84, 351);
            this.aOldalTextBox.Name = "aOldalTextBox";
            this.aOldalTextBox.Size = new System.Drawing.Size(90, 20);
            this.aOldalTextBox.TabIndex = 1;
            // 
            // aOldal
            // 
            this.aOldal.AutoSize = true;
            this.aOldal.Location = new System.Drawing.Point(8, 353);
            this.aOldal.Name = "aOldal";
            this.aOldal.Size = new System.Drawing.Size(41, 13);
            this.aOldal.TabIndex = 0;
            this.aOldal.Text = "a oldal:";
            // 
            // gulaGomb
            // 
            this.gulaGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gulaGomb.Location = new System.Drawing.Point(12, 392);
            this.gulaGomb.Name = "gulaGomb";
            this.gulaGomb.Size = new System.Drawing.Size(104, 32);
            this.gulaGomb.TabIndex = 24;
            this.gulaGomb.Text = "Gúla";
            this.gulaGomb.UseVisualStyleBackColor = true;
            this.gulaGomb.Click += new System.EventHandler(this.gulaGomb_Click);
            // 
            // hengerGomb
            // 
            this.hengerGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hengerGomb.Location = new System.Drawing.Point(12, 354);
            this.hengerGomb.Name = "hengerGomb";
            this.hengerGomb.Size = new System.Drawing.Size(104, 32);
            this.hengerGomb.TabIndex = 23;
            this.hengerGomb.Text = "Henger";
            this.hengerGomb.UseVisualStyleBackColor = true;
            this.hengerGomb.Click += new System.EventHandler(this.hengerGomb_Click);
            // 
            // teglalapGomb
            // 
            this.teglalapGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teglalapGomb.Location = new System.Drawing.Point(12, 126);
            this.teglalapGomb.Name = "teglalapGomb";
            this.teglalapGomb.Size = new System.Drawing.Size(104, 32);
            this.teglalapGomb.TabIndex = 17;
            this.teglalapGomb.Text = "Téglalap";
            this.teglalapGomb.UseVisualStyleBackColor = true;
            this.teglalapGomb.Click += new System.EventHandler(this.teglalapGomb_Click);
            // 
            // paralelogrammaGomb
            // 
            this.paralelogrammaGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paralelogrammaGomb.Location = new System.Drawing.Point(12, 88);
            this.paralelogrammaGomb.Name = "paralelogrammaGomb";
            this.paralelogrammaGomb.Size = new System.Drawing.Size(104, 32);
            this.paralelogrammaGomb.TabIndex = 16;
            this.paralelogrammaGomb.Text = "Paralelogramma ";
            this.paralelogrammaGomb.UseVisualStyleBackColor = true;
            this.paralelogrammaGomb.Click += new System.EventHandler(this.paralelogrammaGomb_Click);
            // 
            // trapezGomb
            // 
            this.trapezGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trapezGomb.Location = new System.Drawing.Point(12, 50);
            this.trapezGomb.Name = "trapezGomb";
            this.trapezGomb.Size = new System.Drawing.Size(104, 32);
            this.trapezGomb.TabIndex = 15;
            this.trapezGomb.Text = "Trapéz";
            this.trapezGomb.UseVisualStyleBackColor = true;
            this.trapezGomb.Click += new System.EventHandler(this.trapezGomb_Click);
            // 
            // haromszogGomb
            // 
            this.haromszogGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.haromszogGomb.Location = new System.Drawing.Point(12, 12);
            this.haromszogGomb.Name = "haromszogGomb";
            this.haromszogGomb.Size = new System.Drawing.Size(104, 32);
            this.haromszogGomb.TabIndex = 14;
            this.haromszogGomb.Text = "Háromszög";
            this.haromszogGomb.UseVisualStyleBackColor = true;
            this.haromszogGomb.Click += new System.EventHandler(this.haromszogGomb_Click);
            // 
            // gombGomb
            // 
            this.gombGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gombGomb.Location = new System.Drawing.Point(12, 316);
            this.gombGomb.Name = "gombGomb";
            this.gombGomb.Size = new System.Drawing.Size(104, 32);
            this.gombGomb.TabIndex = 22;
            this.gombGomb.Text = "Gömb";
            this.gombGomb.UseVisualStyleBackColor = true;
            this.gombGomb.Click += new System.EventHandler(this.gombGomb_Click);
            // 
            // korGomb
            // 
            this.korGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korGomb.Location = new System.Drawing.Point(12, 278);
            this.korGomb.Name = "korGomb";
            this.korGomb.Size = new System.Drawing.Size(104, 32);
            this.korGomb.TabIndex = 21;
            this.korGomb.Text = "Kör";
            this.korGomb.UseVisualStyleBackColor = true;
            this.korGomb.Click += new System.EventHandler(this.korGomb_Click);
            // 
            // negyzetGomb
            // 
            this.negyzetGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.negyzetGomb.Location = new System.Drawing.Point(12, 240);
            this.negyzetGomb.Name = "negyzetGomb";
            this.negyzetGomb.Size = new System.Drawing.Size(104, 32);
            this.negyzetGomb.TabIndex = 20;
            this.negyzetGomb.Text = "Négyzet";
            this.negyzetGomb.UseVisualStyleBackColor = true;
            this.negyzetGomb.Click += new System.EventHandler(this.negyzetGomb_Click);
            // 
            // rombuszGomb
            // 
            this.rombuszGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rombuszGomb.Location = new System.Drawing.Point(12, 202);
            this.rombuszGomb.Name = "rombuszGomb";
            this.rombuszGomb.Size = new System.Drawing.Size(104, 32);
            this.rombuszGomb.TabIndex = 19;
            this.rombuszGomb.Text = "Rombusz";
            this.rombuszGomb.UseVisualStyleBackColor = true;
            this.rombuszGomb.Click += new System.EventHandler(this.rombuszGomb_Click);
            // 
            // deltoidGomb
            // 
            this.deltoidGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deltoidGomb.Location = new System.Drawing.Point(12, 164);
            this.deltoidGomb.Name = "deltoidGomb";
            this.deltoidGomb.Size = new System.Drawing.Size(104, 32);
            this.deltoidGomb.TabIndex = 18;
            this.deltoidGomb.Text = "Deltoid";
            this.deltoidGomb.UseVisualStyleBackColor = true;
            this.deltoidGomb.Click += new System.EventHandler(this.deltoidGomb_Click);
            // 
            // mOldalMertekegyseg
            // 
            this.mOldalMertekegyseg.FormattingEnabled = true;
            this.mOldalMertekegyseg.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km"});
            this.mOldalMertekegyseg.Location = new System.Drawing.Point(192, 623);
            this.mOldalMertekegyseg.Name = "mOldalMertekegyseg";
            this.mOldalMertekegyseg.Size = new System.Drawing.Size(54, 21);
            this.mOldalMertekegyseg.TabIndex = 26;
            this.mOldalMertekegyseg.Text = "mm";
            this.mOldalMertekegyseg.Visible = false;
            // 
            // mOldalTextBox
            // 
            this.mOldalTextBox.Location = new System.Drawing.Point(84, 624);
            this.mOldalTextBox.Name = "mOldalTextBox";
            this.mOldalTextBox.Size = new System.Drawing.Size(90, 20);
            this.mOldalTextBox.TabIndex = 25;
            this.mOldalTextBox.Visible = false;
            // 
            // mOldal
            // 
            this.mOldal.AutoSize = true;
            this.mOldal.Location = new System.Drawing.Point(8, 626);
            this.mOldal.Name = "mOldal";
            this.mOldal.Size = new System.Drawing.Size(44, 13);
            this.mOldal.TabIndex = 24;
            this.mOldal.Text = "M oldal:";
            this.mOldal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gulaGomb);
            this.Controls.Add(this.hengerGomb);
            this.Controls.Add(this.teglalapGomb);
            this.Controls.Add(this.paralelogrammaGomb);
            this.Controls.Add(this.trapezGomb);
            this.Controls.Add(this.haromszogGomb);
            this.Controls.Add(this.gombGomb);
            this.Controls.Add(this.korGomb);
            this.Controls.Add(this.negyzetGomb);
            this.Controls.Add(this.rombuszGomb);
            this.Controls.Add(this.deltoidGomb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TerületKerületTérfogat";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alakzatPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox alakzatPictureBox;
        private System.Windows.Forms.ComboBox dOldalMertekegyseg;
        private System.Windows.Forms.TextBox dOldalTextBox;
        private System.Windows.Forms.Label dOldal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox aOldalMagassagMertekegyseg;
        private System.Windows.Forms.TextBox aOldalMagassagTextBox;
        private System.Windows.Forms.Label aOldalMagassag;
        private System.Windows.Forms.ComboBox cOldalMertekegyseg;
        private System.Windows.Forms.TextBox cOldalTextBox;
        private System.Windows.Forms.Label cOldal;
        private System.Windows.Forms.ComboBox bOldalMertekegyseg;
        private System.Windows.Forms.ComboBox aOldalMertekegyseg;
        private System.Windows.Forms.TextBox bOldalTextBox;
        private System.Windows.Forms.Label bOldal;
        private System.Windows.Forms.TextBox aOldalTextBox;
        private System.Windows.Forms.Label aOldal;
        private System.Windows.Forms.Button gulaGomb;
        private System.Windows.Forms.Button hengerGomb;
        private System.Windows.Forms.Button teglalapGomb;
        private System.Windows.Forms.Button paralelogrammaGomb;
        private System.Windows.Forms.Button trapezGomb;
        private System.Windows.Forms.Button haromszogGomb;
        private System.Windows.Forms.Button gombGomb;
        private System.Windows.Forms.Button korGomb;
        private System.Windows.Forms.Button negyzetGomb;
        private System.Windows.Forms.Button rombuszGomb;
        private System.Windows.Forms.Button deltoidGomb;
        private System.Windows.Forms.ComboBox rSugarMertekegyseg;
        private System.Windows.Forms.TextBox rSugarTextBox;
        private System.Windows.Forms.Label sugar;
        private System.Windows.Forms.ComboBox fOldalMertekegyseg;
        private System.Windows.Forms.TextBox fOldalTextBox;
        private System.Windows.Forms.Label fOldal;
        private System.Windows.Forms.ComboBox eOldalMertekegyseg;
        private System.Windows.Forms.TextBox eOldalTextBox;
        private System.Windows.Forms.Label eOldal;
        private System.Windows.Forms.ComboBox mOldalMertekegyseg;
        private System.Windows.Forms.TextBox mOldalTextBox;
        private System.Windows.Forms.Label mOldal;
    }
}

