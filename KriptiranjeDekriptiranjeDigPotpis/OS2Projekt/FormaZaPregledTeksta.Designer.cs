namespace OS2Projekt
{
    partial class FormaZaPregledTeksta
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
            this.uiInputTextDat = new System.Windows.Forms.TextBox();
            this.uiAcitionZatvori = new System.Windows.Forms.Button();
            this.uiOutputNaslovImeDat = new System.Windows.Forms.Label();
            this.uiOutputImeDatoteke = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiInputTextDat
            // 
            this.uiInputTextDat.Location = new System.Drawing.Point(12, 76);
            this.uiInputTextDat.Multiline = true;
            this.uiInputTextDat.Name = "uiInputTextDat";
            this.uiInputTextDat.ReadOnly = true;
            this.uiInputTextDat.Size = new System.Drawing.Size(530, 306);
            this.uiInputTextDat.TabIndex = 0;
            // 
            // uiAcitionZatvori
            // 
            this.uiAcitionZatvori.Location = new System.Drawing.Point(461, 413);
            this.uiAcitionZatvori.Name = "uiAcitionZatvori";
            this.uiAcitionZatvori.Size = new System.Drawing.Size(81, 29);
            this.uiAcitionZatvori.TabIndex = 1;
            this.uiAcitionZatvori.Text = "Zatvori";
            this.uiAcitionZatvori.UseVisualStyleBackColor = true;
            this.uiAcitionZatvori.Click += new System.EventHandler(this.uiActionSpremiPromjene_Click);
            // 
            // uiOutputNaslovImeDat
            // 
            this.uiOutputNaslovImeDat.AutoSize = true;
            this.uiOutputNaslovImeDat.Location = new System.Drawing.Point(9, 28);
            this.uiOutputNaslovImeDat.Name = "uiOutputNaslovImeDat";
            this.uiOutputNaslovImeDat.Size = new System.Drawing.Size(75, 13);
            this.uiOutputNaslovImeDat.TabIndex = 2;
            this.uiOutputNaslovImeDat.Text = "Ime datoteke: ";
            // 
            // uiOutputImeDatoteke
            // 
            this.uiOutputImeDatoteke.AutoSize = true;
            this.uiOutputImeDatoteke.Location = new System.Drawing.Point(79, 28);
            this.uiOutputImeDatoteke.Name = "uiOutputImeDatoteke";
            this.uiOutputImeDatoteke.Size = new System.Drawing.Size(26, 13);
            this.uiOutputImeDatoteke.TabIndex = 3;
            this.uiOutputImeDatoteke.Text = "IME";
            // 
            // FormaZaPregledTeksta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 468);
            this.Controls.Add(this.uiOutputImeDatoteke);
            this.Controls.Add(this.uiOutputNaslovImeDat);
            this.Controls.Add(this.uiAcitionZatvori);
            this.Controls.Add(this.uiInputTextDat);
            this.Name = "FormaZaPregledTeksta";
            this.Text = "FormaZaPromjenuTeksta";
            this.Load += new System.EventHandler(this.FormaZaPromjenuTeksta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiInputTextDat;
        private System.Windows.Forms.Button uiAcitionZatvori;
        private System.Windows.Forms.Label uiOutputNaslovImeDat;
        private System.Windows.Forms.Label uiOutputImeDatoteke;
    }
}