using System;
using System.Windows.Forms;

namespace OS2Projekt
{
    public partial class PocetnaForma : Form
    {
        bool datotekaJeOdabrana = false;
        public PocetnaForma()
        {
            InitializeComponent();

        }

        private void uiActionPutanjaDoMape_Click(object sender, EventArgs e)
        {
            datotekaJeOdabrana = RadSDatotekama.OdaberiMapu();

            if (datotekaJeOdabrana)
                uiOutputPutanjaDoMape.Text = RadSDatotekama.FolderPath;
            else
            {
                uiOutputPutanjaDoMape.Text = "Nije odabrana niti jedna datoteka";
            }
        }

        private void uiActionNastavak_Click(object sender, EventArgs e)
        {
            if (datotekaJeOdabrana)
            {
                Pomocna.OtvoriFormu(new uiFormMain(), this);
            }
            else
                MessageBox.Show("Nije odabrana niti jedna mapa!");

        }
    }
}
