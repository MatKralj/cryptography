namespace OS2Projekt
{
    partial class uiFormMain
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
            this.gBoxUpravljanjeKljucevima = new System.Windows.Forms.GroupBox();
            this.uiActionGenerirajNoveKljuceve = new System.Windows.Forms.Button();
            this.uiComboBoxKljucevi = new System.Windows.Forms.ComboBox();
            this.uiActionPregledajTextKljuca = new System.Windows.Forms.Button();
            this.gBoxKriptDekript = new System.Windows.Forms.GroupBox();
            this.uiActionDigitalnoPiotpisi = new System.Windows.Forms.Button();
            this.uiOutputPutanjaDoDatoteke = new System.Windows.Forms.Label();
            this.gBoxVrstaKript = new System.Windows.Forms.GroupBox();
            this.uiRadioSimetricniAlg = new System.Windows.Forms.RadioButton();
            this.uiRadioAsimetricniAlg = new System.Windows.Forms.RadioButton();
            this.gBoxRadnja = new System.Windows.Forms.GroupBox();
            this.uiRadioKriptiraj = new System.Windows.Forms.RadioButton();
            this.uiRadioDekriptiraj = new System.Windows.Forms.RadioButton();
            this.uiActionUcitajDatoteku = new System.Windows.Forms.Button();
            this.uiActionIzvrsiKriptDekript = new System.Windows.Forms.Button();
            this.uiActionIzracunajHash = new System.Windows.Forms.Button();
            this.uiOutputKriptiraniTekst = new System.Windows.Forms.TextBox();
            this.uiOutputCistiTekst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiActoionClear = new System.Windows.Forms.Button();
            this.uiActionProvjeriPotpis = new System.Windows.Forms.Button();
            this.uiOutputRezultatProvjerePotpisa = new System.Windows.Forms.Label();
            this.uiOutputValjanostPotpisa = new System.Windows.Forms.Panel();
            this.uiActionOdaberiDigitalniPotpis = new System.Windows.Forms.Button();
            this.gBoxUpravljanjeKljucevima.SuspendLayout();
            this.gBoxKriptDekript.SuspendLayout();
            this.gBoxVrstaKript.SuspendLayout();
            this.gBoxRadnja.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxUpravljanjeKljucevima
            // 
            this.gBoxUpravljanjeKljucevima.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gBoxUpravljanjeKljucevima.Controls.Add(this.uiActionGenerirajNoveKljuceve);
            this.gBoxUpravljanjeKljucevima.Controls.Add(this.uiComboBoxKljucevi);
            this.gBoxUpravljanjeKljucevima.Controls.Add(this.uiActionPregledajTextKljuca);
            this.gBoxUpravljanjeKljucevima.Location = new System.Drawing.Point(12, 12);
            this.gBoxUpravljanjeKljucevima.Name = "gBoxUpravljanjeKljucevima";
            this.gBoxUpravljanjeKljucevima.Size = new System.Drawing.Size(212, 174);
            this.gBoxUpravljanjeKljucevima.TabIndex = 0;
            this.gBoxUpravljanjeKljucevima.TabStop = false;
            this.gBoxUpravljanjeKljucevima.Text = "Upravljanje kriptografskim ključevima";
            // 
            // uiActionGenerirajNoveKljuceve
            // 
            this.uiActionGenerirajNoveKljuceve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiActionGenerirajNoveKljuceve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiActionGenerirajNoveKljuceve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiActionGenerirajNoveKljuceve.Location = new System.Drawing.Point(48, 119);
            this.uiActionGenerirajNoveKljuceve.Name = "uiActionGenerirajNoveKljuceve";
            this.uiActionGenerirajNoveKljuceve.Size = new System.Drawing.Size(108, 43);
            this.uiActionGenerirajNoveKljuceve.TabIndex = 4;
            this.uiActionGenerirajNoveKljuceve.Text = "Generiraj nove kljuceve";
            this.uiActionGenerirajNoveKljuceve.UseVisualStyleBackColor = false;
            this.uiActionGenerirajNoveKljuceve.Click += new System.EventHandler(this.uiActionGenerirajNoveKljuceve_Click);
            // 
            // uiComboBoxKljucevi
            // 
            this.uiComboBoxKljucevi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiComboBoxKljucevi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiComboBoxKljucevi.FormattingEnabled = true;
            this.uiComboBoxKljucevi.Items.AddRange(new object[] {
            "Javni ključ",
            "Privatni ključ",
            "Tajni ključ"});
            this.uiComboBoxKljucevi.Location = new System.Drawing.Point(41, 40);
            this.uiComboBoxKljucevi.Name = "uiComboBoxKljucevi";
            this.uiComboBoxKljucevi.Size = new System.Drawing.Size(121, 21);
            this.uiComboBoxKljucevi.TabIndex = 3;
            // 
            // uiActionPregledajTextKljuca
            // 
            this.uiActionPregledajTextKljuca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiActionPregledajTextKljuca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiActionPregledajTextKljuca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiActionPregledajTextKljuca.Location = new System.Drawing.Point(63, 67);
            this.uiActionPregledajTextKljuca.Name = "uiActionPregledajTextKljuca";
            this.uiActionPregledajTextKljuca.Size = new System.Drawing.Size(79, 31);
            this.uiActionPregledajTextKljuca.TabIndex = 2;
            this.uiActionPregledajTextKljuca.Text = "Pregledaj";
            this.uiActionPregledajTextKljuca.UseVisualStyleBackColor = false;
            this.uiActionPregledajTextKljuca.Click += new System.EventHandler(this.uiActionPromijeniTextKljuca_Click);
            // 
            // gBoxKriptDekript
            // 
            this.gBoxKriptDekript.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gBoxKriptDekript.Controls.Add(this.uiActionDigitalnoPiotpisi);
            this.gBoxKriptDekript.Controls.Add(this.uiOutputPutanjaDoDatoteke);
            this.gBoxKriptDekript.Controls.Add(this.gBoxVrstaKript);
            this.gBoxKriptDekript.Controls.Add(this.gBoxRadnja);
            this.gBoxKriptDekript.Controls.Add(this.uiActionUcitajDatoteku);
            this.gBoxKriptDekript.Controls.Add(this.uiActionIzvrsiKriptDekript);
            this.gBoxKriptDekript.Controls.Add(this.uiActionIzracunajHash);
            this.gBoxKriptDekript.Location = new System.Drawing.Point(230, 12);
            this.gBoxKriptDekript.Name = "gBoxKriptDekript";
            this.gBoxKriptDekript.Size = new System.Drawing.Size(392, 246);
            this.gBoxKriptDekript.TabIndex = 4;
            this.gBoxKriptDekript.TabStop = false;
            this.gBoxKriptDekript.Text = "Kriptiranje i dekriptiranje";
            // 
            // uiActionDigitalnoPiotpisi
            // 
            this.uiActionDigitalnoPiotpisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiActionDigitalnoPiotpisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiActionDigitalnoPiotpisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiActionDigitalnoPiotpisi.Location = new System.Drawing.Point(293, 30);
            this.uiActionDigitalnoPiotpisi.Name = "uiActionDigitalnoPiotpisi";
            this.uiActionDigitalnoPiotpisi.Size = new System.Drawing.Size(93, 31);
            this.uiActionDigitalnoPiotpisi.TabIndex = 11;
            this.uiActionDigitalnoPiotpisi.Text = "Digitalno potpisi";
            this.uiActionDigitalnoPiotpisi.UseVisualStyleBackColor = false;
            this.uiActionDigitalnoPiotpisi.Click += new System.EventHandler(this.uiActionDigitalnoPiotpisi_Click);
            // 
            // uiOutputPutanjaDoDatoteke
            // 
            this.uiOutputPutanjaDoDatoteke.AutoSize = true;
            this.uiOutputPutanjaDoDatoteke.Location = new System.Drawing.Point(19, 64);
            this.uiOutputPutanjaDoDatoteke.Name = "uiOutputPutanjaDoDatoteke";
            this.uiOutputPutanjaDoDatoteke.Size = new System.Drawing.Size(103, 13);
            this.uiOutputPutanjaDoDatoteke.TabIndex = 6;
            this.uiOutputPutanjaDoDatoteke.Text = "Putanja do datoteke";
            // 
            // gBoxVrstaKript
            // 
            this.gBoxVrstaKript.Controls.Add(this.uiRadioSimetricniAlg);
            this.gBoxVrstaKript.Controls.Add(this.uiRadioAsimetricniAlg);
            this.gBoxVrstaKript.Location = new System.Drawing.Point(16, 168);
            this.gBoxVrstaKript.Name = "gBoxVrstaKript";
            this.gBoxVrstaKript.Size = new System.Drawing.Size(158, 73);
            this.gBoxVrstaKript.TabIndex = 7;
            this.gBoxVrstaKript.TabStop = false;
            this.gBoxVrstaKript.Text = "Vrsta kriptiranja";
            // 
            // uiRadioSimetricniAlg
            // 
            this.uiRadioSimetricniAlg.AutoSize = true;
            this.uiRadioSimetricniAlg.Checked = true;
            this.uiRadioSimetricniAlg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioSimetricniAlg.Location = new System.Drawing.Point(6, 19);
            this.uiRadioSimetricniAlg.Name = "uiRadioSimetricniAlg";
            this.uiRadioSimetricniAlg.Size = new System.Drawing.Size(115, 17);
            this.uiRadioSimetricniAlg.TabIndex = 5;
            this.uiRadioSimetricniAlg.TabStop = true;
            this.uiRadioSimetricniAlg.Text = "Simetrični algoritam";
            this.uiRadioSimetricniAlg.UseVisualStyleBackColor = true;
            // 
            // uiRadioAsimetricniAlg
            // 
            this.uiRadioAsimetricniAlg.AutoSize = true;
            this.uiRadioAsimetricniAlg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioAsimetricniAlg.Location = new System.Drawing.Point(6, 41);
            this.uiRadioAsimetricniAlg.Name = "uiRadioAsimetricniAlg";
            this.uiRadioAsimetricniAlg.Size = new System.Drawing.Size(120, 17);
            this.uiRadioAsimetricniAlg.TabIndex = 6;
            this.uiRadioAsimetricniAlg.TabStop = true;
            this.uiRadioAsimetricniAlg.Text = "Asimetrični algoritam";
            this.uiRadioAsimetricniAlg.UseVisualStyleBackColor = true;
            // 
            // gBoxRadnja
            // 
            this.gBoxRadnja.Controls.Add(this.uiRadioKriptiraj);
            this.gBoxRadnja.Controls.Add(this.uiRadioDekriptiraj);
            this.gBoxRadnja.Location = new System.Drawing.Point(100, 88);
            this.gBoxRadnja.Name = "gBoxRadnja";
            this.gBoxRadnja.Size = new System.Drawing.Size(157, 74);
            this.gBoxRadnja.TabIndex = 5;
            this.gBoxRadnja.TabStop = false;
            // 
            // uiRadioKriptiraj
            // 
            this.uiRadioKriptiraj.AutoSize = true;
            this.uiRadioKriptiraj.Checked = true;
            this.uiRadioKriptiraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioKriptiraj.Location = new System.Drawing.Point(16, 10);
            this.uiRadioKriptiraj.Name = "uiRadioKriptiraj";
            this.uiRadioKriptiraj.Size = new System.Drawing.Size(104, 17);
            this.uiRadioKriptiraj.TabIndex = 5;
            this.uiRadioKriptiraj.TabStop = true;
            this.uiRadioKriptiraj.Text = "Kriptiraj datoteku";
            this.uiRadioKriptiraj.UseVisualStyleBackColor = true;
            // 
            // uiRadioDekriptiraj
            // 
            this.uiRadioDekriptiraj.AutoSize = true;
            this.uiRadioDekriptiraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioDekriptiraj.Location = new System.Drawing.Point(16, 42);
            this.uiRadioDekriptiraj.Name = "uiRadioDekriptiraj";
            this.uiRadioDekriptiraj.Size = new System.Drawing.Size(117, 17);
            this.uiRadioDekriptiraj.TabIndex = 6;
            this.uiRadioDekriptiraj.TabStop = true;
            this.uiRadioDekriptiraj.Text = "Dekriptiraj datoteku";
            this.uiRadioDekriptiraj.UseVisualStyleBackColor = true;
            // 
            // uiActionUcitajDatoteku
            // 
            this.uiActionUcitajDatoteku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiActionUcitajDatoteku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiActionUcitajDatoteku.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiActionUcitajDatoteku.Location = new System.Drawing.Point(60, 30);
            this.uiActionUcitajDatoteku.Name = "uiActionUcitajDatoteku";
            this.uiActionUcitajDatoteku.Size = new System.Drawing.Size(114, 31);
            this.uiActionUcitajDatoteku.TabIndex = 2;
            this.uiActionUcitajDatoteku.Text = "Učitaj datoteku";
            this.uiActionUcitajDatoteku.UseVisualStyleBackColor = false;
            this.uiActionUcitajDatoteku.Click += new System.EventHandler(this.uiActionUcitajDatoteku_Click);
            // 
            // uiActionIzvrsiKriptDekript
            // 
            this.uiActionIzvrsiKriptDekript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiActionIzvrsiKriptDekript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiActionIzvrsiKriptDekript.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiActionIzvrsiKriptDekript.Location = new System.Drawing.Point(180, 168);
            this.uiActionIzvrsiKriptDekript.Name = "uiActionIzvrsiKriptDekript";
            this.uiActionIzvrsiKriptDekript.Size = new System.Drawing.Size(79, 31);
            this.uiActionIzvrsiKriptDekript.TabIndex = 1;
            this.uiActionIzvrsiKriptDekript.Text = "Izvrši radnju";
            this.uiActionIzvrsiKriptDekript.UseVisualStyleBackColor = false;
            this.uiActionIzvrsiKriptDekript.Click += new System.EventHandler(this.uiActionIzvrsiKriptDekript_Click);
            // 
            // uiActionIzracunajHash
            // 
            this.uiActionIzracunajHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiActionIzracunajHash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiActionIzracunajHash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiActionIzracunajHash.Location = new System.Drawing.Point(185, 27);
            this.uiActionIzracunajHash.Name = "uiActionIzracunajHash";
            this.uiActionIzracunajHash.Size = new System.Drawing.Size(93, 37);
            this.uiActionIzracunajHash.TabIndex = 8;
            this.uiActionIzracunajHash.Text = "Izracunaj sazetak";
            this.uiActionIzracunajHash.UseVisualStyleBackColor = false;
            this.uiActionIzracunajHash.Click += new System.EventHandler(this.uiActionIzracunajSazetak_Click);
            // 
            // uiOutputKriptiraniTekst
            // 
            this.uiOutputKriptiraniTekst.Location = new System.Drawing.Point(12, 302);
            this.uiOutputKriptiraniTekst.Multiline = true;
            this.uiOutputKriptiraniTekst.Name = "uiOutputKriptiraniTekst";
            this.uiOutputKriptiraniTekst.ReadOnly = true;
            this.uiOutputKriptiraniTekst.Size = new System.Drawing.Size(327, 289);
            this.uiOutputKriptiraniTekst.TabIndex = 5;
            // 
            // uiOutputCistiTekst
            // 
            this.uiOutputCistiTekst.Location = new System.Drawing.Point(415, 302);
            this.uiOutputCistiTekst.Multiline = true;
            this.uiOutputCistiTekst.Name = "uiOutputCistiTekst";
            this.uiOutputCistiTekst.ReadOnly = true;
            this.uiOutputCistiTekst.Size = new System.Drawing.Size(327, 289);
            this.uiOutputCistiTekst.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kriptirani tekst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cisti tekst";
            // 
            // uiActoionClear
            // 
            this.uiActoionClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiActoionClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiActoionClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiActoionClear.Location = new System.Drawing.Point(354, 302);
            this.uiActoionClear.Name = "uiActoionClear";
            this.uiActoionClear.Size = new System.Drawing.Size(45, 43);
            this.uiActoionClear.TabIndex = 8;
            this.uiActoionClear.Text = "CLR";
            this.uiActoionClear.UseVisualStyleBackColor = false;
            this.uiActoionClear.Click += new System.EventHandler(this.uiActoionClear_Click);
            // 
            // uiActionProvjeriPotpis
            // 
            this.uiActionProvjeriPotpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiActionProvjeriPotpis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiActionProvjeriPotpis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiActionProvjeriPotpis.Location = new System.Drawing.Point(649, 110);
            this.uiActionProvjeriPotpis.Name = "uiActionProvjeriPotpis";
            this.uiActionProvjeriPotpis.Size = new System.Drawing.Size(93, 31);
            this.uiActionProvjeriPotpis.TabIndex = 9;
            this.uiActionProvjeriPotpis.Text = "Provjeri potpis";
            this.uiActionProvjeriPotpis.UseVisualStyleBackColor = false;
            this.uiActionProvjeriPotpis.Click += new System.EventHandler(this.uiActionProvjeriPotpis_Click);
            // 
            // uiOutputRezultatProvjerePotpisa
            // 
            this.uiOutputRezultatProvjerePotpisa.AutoSize = true;
            this.uiOutputRezultatProvjerePotpisa.Location = new System.Drawing.Point(625, 149);
            this.uiOutputRezultatProvjerePotpisa.Name = "uiOutputRezultatProvjerePotpisa";
            this.uiOutputRezultatProvjerePotpisa.Size = new System.Drawing.Size(89, 13);
            this.uiOutputRezultatProvjerePotpisa.TabIndex = 9;
            this.uiOutputRezultatProvjerePotpisa.Text = "Digitalni potpis je:";
            // 
            // uiOutputValjanostPotpisa
            // 
            this.uiOutputValjanostPotpisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uiOutputValjanostPotpisa.Location = new System.Drawing.Point(716, 150);
            this.uiOutputValjanostPotpisa.Name = "uiOutputValjanostPotpisa";
            this.uiOutputValjanostPotpisa.Size = new System.Drawing.Size(16, 13);
            this.uiOutputValjanostPotpisa.TabIndex = 10;
            // 
            // uiActionOdaberiDigitalniPotpis
            // 
            this.uiActionOdaberiDigitalniPotpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiActionOdaberiDigitalniPotpis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiActionOdaberiDigitalniPotpis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiActionOdaberiDigitalniPotpis.Location = new System.Drawing.Point(649, 58);
            this.uiActionOdaberiDigitalniPotpis.Name = "uiActionOdaberiDigitalniPotpis";
            this.uiActionOdaberiDigitalniPotpis.Size = new System.Drawing.Size(93, 46);
            this.uiActionOdaberiDigitalniPotpis.TabIndex = 11;
            this.uiActionOdaberiDigitalniPotpis.Text = "Odaberi digitalni potpis";
            this.uiActionOdaberiDigitalniPotpis.UseVisualStyleBackColor = false;
            this.uiActionOdaberiDigitalniPotpis.Click += new System.EventHandler(this.uiActionOdaberiDigitalniPotpis_Click);
            // 
            // uiFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 625);
            this.Controls.Add(this.uiActionOdaberiDigitalniPotpis);
            this.Controls.Add(this.uiOutputValjanostPotpisa);
            this.Controls.Add(this.uiActoionClear);
            this.Controls.Add(this.uiOutputRezultatProvjerePotpisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiActionProvjeriPotpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiOutputCistiTekst);
            this.Controls.Add(this.uiOutputKriptiraniTekst);
            this.Controls.Add(this.gBoxKriptDekript);
            this.Controls.Add(this.gBoxUpravljanjeKljucevima);
            this.Name = "uiFormMain";
            this.Text = "Kriptiranje, dekriptiranje i digitalni potpis";
            this.Load += new System.EventHandler(this.uiFormMain_Load);
            this.gBoxUpravljanjeKljucevima.ResumeLayout(false);
            this.gBoxKriptDekript.ResumeLayout(false);
            this.gBoxKriptDekript.PerformLayout();
            this.gBoxVrstaKript.ResumeLayout(false);
            this.gBoxVrstaKript.PerformLayout();
            this.gBoxRadnja.ResumeLayout(false);
            this.gBoxRadnja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxUpravljanjeKljucevima;
        private System.Windows.Forms.Button uiActionPregledajTextKljuca;
        private System.Windows.Forms.GroupBox gBoxKriptDekript;
        private System.Windows.Forms.GroupBox gBoxVrstaKript;
        private System.Windows.Forms.GroupBox gBoxRadnja;
        private System.Windows.Forms.Button uiActionUcitajDatoteku;
        private System.Windows.Forms.Button uiActionIzvrsiKriptDekript;
        public System.Windows.Forms.Label uiOutputPutanjaDoDatoteke;
        private System.Windows.Forms.ComboBox uiComboBoxKljucevi;
        public System.Windows.Forms.RadioButton uiRadioSimetricniAlg;
        public System.Windows.Forms.RadioButton uiRadioAsimetricniAlg;
        public System.Windows.Forms.RadioButton uiRadioKriptiraj;
        public System.Windows.Forms.RadioButton uiRadioDekriptiraj;
        private System.Windows.Forms.TextBox uiOutputKriptiraniTekst;
        private System.Windows.Forms.TextBox uiOutputCistiTekst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uiActoionClear;
        private System.Windows.Forms.Panel uiOutputValjanostPotpisa;
        private System.Windows.Forms.Label uiOutputRezultatProvjerePotpisa;
        private System.Windows.Forms.Button uiActionProvjeriPotpis;
        private System.Windows.Forms.Button uiActionIzracunajHash;
        private System.Windows.Forms.Button uiActionDigitalnoPiotpisi;
        private System.Windows.Forms.Button uiActionGenerirajNoveKljuceve;
        private System.Windows.Forms.Button uiActionOdaberiDigitalniPotpis;
    }
}

