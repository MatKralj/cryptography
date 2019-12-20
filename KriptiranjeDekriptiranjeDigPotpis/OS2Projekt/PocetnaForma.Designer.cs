namespace OS2Projekt
{
    partial class PocetnaForma
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
            this.uiOutputPocetniText = new System.Windows.Forms.TextBox();
            this.uiActionPutanjaDoMape = new System.Windows.Forms.Button();
            this.uiOutputPutanjaDoMape = new System.Windows.Forms.TextBox();
            this.uiActionNastavak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiOutputPocetniText
            // 
            this.uiOutputPocetniText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiOutputPocetniText.Location = new System.Drawing.Point(12, 12);
            this.uiOutputPocetniText.Multiline = true;
            this.uiOutputPocetniText.Name = "uiOutputPocetniText";
            this.uiOutputPocetniText.ReadOnly = true;
            this.uiOutputPocetniText.Size = new System.Drawing.Size(285, 40);
            this.uiOutputPocetniText.TabIndex = 1;
            this.uiOutputPocetniText.Text = "Za nastavak rada, molim odaberite mapu koju ćete koristiti za pohranu datoteka.";
            // 
            // uiActionPutanjaDoMape
            // 
            this.uiActionPutanjaDoMape.Location = new System.Drawing.Point(81, 102);
            this.uiActionPutanjaDoMape.Name = "uiActionPutanjaDoMape";
            this.uiActionPutanjaDoMape.Size = new System.Drawing.Size(119, 43);
            this.uiActionPutanjaDoMape.TabIndex = 2;
            this.uiActionPutanjaDoMape.Text = "Odaberite mapu";
            this.uiActionPutanjaDoMape.UseVisualStyleBackColor = true;
            this.uiActionPutanjaDoMape.Click += new System.EventHandler(this.uiActionPutanjaDoMape_Click);
            // 
            // uiOutputPutanjaDoMape
            // 
            this.uiOutputPutanjaDoMape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiOutputPutanjaDoMape.Location = new System.Drawing.Point(12, 180);
            this.uiOutputPutanjaDoMape.Multiline = true;
            this.uiOutputPutanjaDoMape.Name = "uiOutputPutanjaDoMape";
            this.uiOutputPutanjaDoMape.ReadOnly = true;
            this.uiOutputPutanjaDoMape.Size = new System.Drawing.Size(285, 59);
            this.uiOutputPutanjaDoMape.TabIndex = 3;
            this.uiOutputPutanjaDoMape.Text = "Putanja do mape: ";
            // 
            // uiActionNastavak
            // 
            this.uiActionNastavak.Location = new System.Drawing.Point(178, 245);
            this.uiActionNastavak.Name = "uiActionNastavak";
            this.uiActionNastavak.Size = new System.Drawing.Size(119, 43);
            this.uiActionNastavak.TabIndex = 4;
            this.uiActionNastavak.Text = "Nastavite ";
            this.uiActionNastavak.UseVisualStyleBackColor = true;
            this.uiActionNastavak.Click += new System.EventHandler(this.uiActionNastavak_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 313);
            this.Controls.Add(this.uiActionNastavak);
            this.Controls.Add(this.uiOutputPutanjaDoMape);
            this.Controls.Add(this.uiActionPutanjaDoMape);
            this.Controls.Add(this.uiOutputPocetniText);
            this.Name = "PocetnaForma";
            this.Text = "PocetnaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiOutputPocetniText;
        private System.Windows.Forms.Button uiActionPutanjaDoMape;
        private System.Windows.Forms.TextBox uiOutputPutanjaDoMape;
        private System.Windows.Forms.Button uiActionNastavak;
    }
}