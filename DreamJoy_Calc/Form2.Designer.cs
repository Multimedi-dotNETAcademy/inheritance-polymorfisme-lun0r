
namespace DreamJoy_Calc
{
    partial class Form2
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
            this.groupBoxDieren = new System.Windows.Forms.GroupBox();
            this.radioButtonMen = new System.Windows.Forms.RadioButton();
            this.radioButtonPape = new System.Windows.Forms.RadioButton();
            this.radioButtonKat = new System.Windows.Forms.RadioButton();
            this.labelDier = new System.Windows.Forms.Label();
            this.textBoxDier = new System.Windows.Forms.TextBox();
            this.buttonAanmaken = new System.Windows.Forms.Button();
            this.labelZin = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonPraten = new System.Windows.Forms.Button();
            this.buttonStrel = new System.Windows.Forms.Button();
            this.buttonEten = new System.Windows.Forms.Button();
            this.buttonSluiten = new System.Windows.Forms.Button();
            this.groupBoxDieren.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDieren
            // 
            this.groupBoxDieren.Controls.Add(this.radioButtonMen);
            this.groupBoxDieren.Controls.Add(this.radioButtonPape);
            this.groupBoxDieren.Controls.Add(this.radioButtonKat);
            this.groupBoxDieren.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDieren.Name = "groupBoxDieren";
            this.groupBoxDieren.Size = new System.Drawing.Size(250, 163);
            this.groupBoxDieren.TabIndex = 6;
            this.groupBoxDieren.TabStop = false;
            this.groupBoxDieren.Text = "Dieren";
            // 
            // radioButtonMen
            // 
            this.radioButtonMen.AutoSize = true;
            this.radioButtonMen.Enabled = false;
            this.radioButtonMen.Location = new System.Drawing.Point(17, 105);
            this.radioButtonMen.Name = "radioButtonMen";
            this.radioButtonMen.Size = new System.Drawing.Size(65, 24);
            this.radioButtonMen.TabIndex = 3;
            this.radioButtonMen.TabStop = true;
            this.radioButtonMen.Text = "Mens";
            this.radioButtonMen.UseVisualStyleBackColor = true;
            this.radioButtonMen.CheckedChanged += new System.EventHandler(this.radioButtonMen_CheckedChanged);
            // 
            // radioButtonPape
            // 
            this.radioButtonPape.AutoSize = true;
            this.radioButtonPape.Enabled = false;
            this.radioButtonPape.Location = new System.Drawing.Point(17, 75);
            this.radioButtonPape.Name = "radioButtonPape";
            this.radioButtonPape.Size = new System.Drawing.Size(91, 24);
            this.radioButtonPape.TabIndex = 3;
            this.radioButtonPape.TabStop = true;
            this.radioButtonPape.Text = "Papegaai";
            this.radioButtonPape.UseVisualStyleBackColor = true;
            this.radioButtonPape.CheckedChanged += new System.EventHandler(this.radioButtonPape_CheckedChanged);
            // 
            // radioButtonKat
            // 
            this.radioButtonKat.AutoSize = true;
            this.radioButtonKat.Enabled = false;
            this.radioButtonKat.Location = new System.Drawing.Point(17, 42);
            this.radioButtonKat.Name = "radioButtonKat";
            this.radioButtonKat.Size = new System.Drawing.Size(52, 24);
            this.radioButtonKat.TabIndex = 3;
            this.radioButtonKat.TabStop = true;
            this.radioButtonKat.Text = "Kat";
            this.radioButtonKat.UseVisualStyleBackColor = true;
            this.radioButtonKat.CheckedChanged += new System.EventHandler(this.radioButtonKat_CheckedChanged);
            this.radioButtonKat.Click += new System.EventHandler(this.radioButtonKat_Click);
            // 
            // labelDier
            // 
            this.labelDier.AutoSize = true;
            this.labelDier.Location = new System.Drawing.Point(324, 31);
            this.labelDier.Name = "labelDier";
            this.labelDier.Size = new System.Drawing.Size(170, 20);
            this.labelDier.TabIndex = 9;
            this.labelDier.Text = "Geef je \"dier\" een naam.";
            // 
            // textBoxDier
            // 
            this.textBoxDier.Location = new System.Drawing.Point(324, 54);
            this.textBoxDier.Name = "textBoxDier";
            this.textBoxDier.Size = new System.Drawing.Size(170, 27);
            this.textBoxDier.TabIndex = 1;
            this.textBoxDier.TextChanged += new System.EventHandler(this.textBoxDier_TextChanged);
            // 
            // buttonAanmaken
            // 
            this.buttonAanmaken.Location = new System.Drawing.Point(546, 49);
            this.buttonAanmaken.Name = "buttonAanmaken";
            this.buttonAanmaken.Size = new System.Drawing.Size(104, 32);
            this.buttonAanmaken.TabIndex = 0;
            this.buttonAanmaken.Text = "Aanmaken";
            this.buttonAanmaken.UseVisualStyleBackColor = true;
            this.buttonAanmaken.Click += new System.EventHandler(this.buttonAanmaken_Click);
            // 
            // labelZin
            // 
            this.labelZin.AutoSize = true;
            this.labelZin.Location = new System.Drawing.Point(29, 225);
            this.labelZin.Name = "labelZin";
            this.labelZin.Size = new System.Drawing.Size(201, 20);
            this.labelZin.TabIndex = 5;
            this.labelZin.Text = "Kies een zin uit om te praten:";
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Goedemorgen",
            "Hallo",
            "How are you?",
            "Hey Felicia",
            "Yeet",
            "Laat mij slapen",
            "Today is gonna be the day",
            "Ik wil naar huis",
            "Be zen",
            "Hello V"});
            this.listBox1.Location = new System.Drawing.Point(29, 257);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(233, 44);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonPraten
            // 
            this.buttonPraten.Enabled = false;
            this.buttonPraten.Location = new System.Drawing.Point(324, 258);
            this.buttonPraten.Name = "buttonPraten";
            this.buttonPraten.Size = new System.Drawing.Size(170, 43);
            this.buttonPraten.TabIndex = 7;
            this.buttonPraten.Text = "Praten";
            this.buttonPraten.UseVisualStyleBackColor = true;
            this.buttonPraten.Click += new System.EventHandler(this.buttonPraten_Click);
            // 
            // buttonStrel
            // 
            this.buttonStrel.Enabled = false;
            this.buttonStrel.Location = new System.Drawing.Point(118, 365);
            this.buttonStrel.Name = "buttonStrel";
            this.buttonStrel.Size = new System.Drawing.Size(112, 59);
            this.buttonStrel.TabIndex = 8;
            this.buttonStrel.Text = "Strelen";
            this.buttonStrel.UseVisualStyleBackColor = true;
            this.buttonStrel.Click += new System.EventHandler(this.buttonStrel_Click);
            // 
            // buttonEten
            // 
            this.buttonEten.Enabled = false;
            this.buttonEten.Location = new System.Drawing.Point(324, 365);
            this.buttonEten.Name = "buttonEten";
            this.buttonEten.Size = new System.Drawing.Size(112, 59);
            this.buttonEten.TabIndex = 9;
            this.buttonEten.Text = "Eten";
            this.buttonEten.UseVisualStyleBackColor = true;
            this.buttonEten.Click += new System.EventHandler(this.buttonEten_Click);
            // 
            // buttonSluiten
            // 
            this.buttonSluiten.Location = new System.Drawing.Point(538, 365);
            this.buttonSluiten.Name = "buttonSluiten";
            this.buttonSluiten.Size = new System.Drawing.Size(112, 59);
            this.buttonSluiten.TabIndex = 10;
            this.buttonSluiten.Text = "Sluiten";
            this.buttonSluiten.UseVisualStyleBackColor = true;
            this.buttonSluiten.Click += new System.EventHandler(this.buttonSluiten_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 442);
            this.Controls.Add(this.buttonSluiten);
            this.Controls.Add(this.buttonEten);
            this.Controls.Add(this.buttonStrel);
            this.Controls.Add(this.buttonPraten);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelZin);
            this.Controls.Add(this.buttonAanmaken);
            this.Controls.Add(this.textBoxDier);
            this.Controls.Add(this.labelDier);
            this.Controls.Add(this.groupBoxDieren);
            this.Name = "Form2";
            this.Text = "Dier";
            this.groupBoxDieren.ResumeLayout(false);
            this.groupBoxDieren.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDieren;
        private System.Windows.Forms.RadioButton radioButtonMen;
        private System.Windows.Forms.RadioButton radioButtonPape;
        private System.Windows.Forms.RadioButton radioButtonKat;
        private System.Windows.Forms.Label labelDier;
        private System.Windows.Forms.TextBox textBoxDier;
        private System.Windows.Forms.Button buttonAanmaken;
        private System.Windows.Forms.Label labelZin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonPraten;
        private System.Windows.Forms.Button buttonStrel;
        private System.Windows.Forms.Button buttonEten;
        private System.Windows.Forms.Button buttonSluiten;
    }
}