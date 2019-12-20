using System;
using System.Drawing;
using System.Windows.Forms;
using static OS2Projekt.Enumeracije;

namespace OS2Projekt
{
    public partial class uiFormMain : Form
    {
        public uiFormMain()
        {
            InitializeComponent();
        }

        AsimetricnoKriptiranje asimetricnoKriptiranje = null;
        SimetricnoKriptiranje simetricnoKriptiranje = null;
        private void uiFormMain_Load(object sender, EventArgs e)
        {
            RadSDatotekama.KreirajDatotekeKljuceva();
            asimetricnoKriptiranje = AsimetricnoKriptiranje.KreirajInstancu();
            simetricnoKriptiranje = new SimetricnoKriptiranje();
        }

        private void uiActionBrisiKljuc_Click(object sender, EventArgs e)
        {
            Kljucevi odabraniKljuc = Pomocna.DohvatiKljucIzCombBoxa(uiComboBoxKljucevi);

            string putanjaDoKljuca = DohvatiPutanjuEnum(odabraniKljuc);

            if (putanjaDoKljuca != "")
                RadSDatotekama.IzbrisiSadrzajDatoteke(putanjaDoKljuca);
            else
                MessageBox.Show("Nije odabran ključ");
        }

        private void uiActionPromijeniTextKljuca_Click(object sender, EventArgs e)
        {
            Kljucevi odabraniKljuc = Pomocna.DohvatiKljucIzCombBoxa(uiComboBoxKljucevi);

            if (odabraniKljuc != Kljucevi.Null)
            {
                Pomocna.OtvoriFormu(new FormaZaPregledTeksta(odabraniKljuc), this, false);
            }
            else
                MessageBox.Show("Nije odabran niti jedan ključ!");
        }

        bool datotekaJeOdabrana = false;
        private void uiActionUcitajDatoteku_Click(object sender, EventArgs e)
        {
            string putanja = RadSDatotekama.OdaberiDatoteku();
            if (putanja != "")
            {
                RadSDatotekama.PutanjaDoOdabraneDatoteke = putanja;
                uiOutputPutanjaDoDatoteke.Text = RadSDatotekama.PutanjaDoOdabraneDatoteke;
                datotekaJeOdabrana = true;
            }
            else
            {
                uiOutputPutanjaDoDatoteke.Text = "Nije odabrana datoteka";
                datotekaJeOdabrana = false;
            }
        }
        private void uiActionIzvrsiKriptDekript_Click(object sender, EventArgs e)
        {

            byte[] bajtoviOdabraneDatoteke = RadSDatotekama.Citaj(RadSDatotekama.PutanjaDoOdabraneDatoteke);
            byte[] kriptiraniBajtovi = null;
            try
            {
                switch (Pomocna.ProvjeriOdabranuRadnju(datotekaJeOdabrana, this))
                {
                    case VrstaRada.KriptirajSimetricno:
                        kriptiraniBajtovi = simetricnoKriptiranje.Kriptiraj(bajtoviOdabraneDatoteke);
                        RadSDatotekama.OverwriteFile(RadSDatotekama.SimetricnoKriptiranjePutanja, kriptiraniBajtovi);
                        uiOutputKriptiraniTekst.Text = RadSDatotekama.DohvatiStringIzBajta(RadSDatotekama.Citaj(RadSDatotekama.SimetricnoKriptiranjePutanja));
                        break;

                    case VrstaRada.KriptirajAsimetricno:
                        asimetricnoKriptiranje = AsimetricnoKriptiranje.getInstance();

                        kriptiraniBajtovi = asimetricnoKriptiranje.Kriptiraj(bajtoviOdabraneDatoteke);
                        RadSDatotekama.OverwriteFile(RadSDatotekama.AsimetricnoKriptiranjePutanja, kriptiraniBajtovi);
                        uiOutputKriptiraniTekst.Text = RadSDatotekama.DohvatiStringIzBajta(RadSDatotekama.Citaj(RadSDatotekama.AsimetricnoKriptiranjePutanja));
                        break;

                    case VrstaRada.DekriptirajAsimetricno:
                        asimetricnoKriptiranje = AsimetricnoKriptiranje.getInstance();

                        uiOutputCistiTekst.Text = asimetricnoKriptiranje.Dekriptiraj(bajtoviOdabraneDatoteke);
                        break;

                    case VrstaRada.DekriptirajSimetricno:
                        uiOutputCistiTekst.Text = simetricnoKriptiranje.Dekriptiraj(bajtoviOdabraneDatoteke);
                        break;

                    default:
                        MessageBox.Show("Nije odabrana datoteka!");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Provjerite odabranu datoteku ili vrstu rada nad datotekom.");
            }

        }

        private void uiActionIzracunajSazetak_Click(object sender, EventArgs e)
        {
            byte[] originalByte = RadSDatotekama.Citaj(RadSDatotekama.PutanjaDoOdabraneDatoteke);
            byte[] hashOriginala = asimetricnoKriptiranje.IzracunajSazetak(originalByte);

            RadSDatotekama.OverwriteFile(RadSDatotekama.PutanjaDoSazetka, hashOriginala);
        }

        private void uiActoionClear_Click(object sender, EventArgs e)
        {
            uiOutputCistiTekst.Text = "";
            uiOutputKriptiraniTekst.Text = "";
        }

        private void uiActionGenerirajNoveKljuceve_Click(object sender, EventArgs e)
        {
            simetricnoKriptiranje = new SimetricnoKriptiranje();
            asimetricnoKriptiranje = AsimetricnoKriptiranje.KreirajInstancu();
        }

        private void uiActionDigitalnoPiotpisi_Click(object sender, EventArgs e)
        {
            byte[] digitalniPotpis = asimetricnoKriptiranje.DigitalnoPotpisi(RadSDatotekama.Citaj(RadSDatotekama.PutanjaDoOdabraneDatoteke));

            RadSDatotekama.OverwriteFile(RadSDatotekama.PutanjaDoDigPotpisa, digitalniPotpis);
        }

        private void uiActionProvjeriPotpis_Click(object sender, EventArgs e)
        {
            bool valjanPotpis = false;

            byte[] original = RadSDatotekama.Citaj(RadSDatotekama.PutanjaDoOdabraneDatoteke);
            byte[] digitalniPotpis = RadSDatotekama.Citaj(RadSDatotekama.PutanjaDoDigPotpisa);

            valjanPotpis = asimetricnoKriptiranje.ProvjeriDigitalniPotpis(digitalniPotpis, original);

            if (valjanPotpis)
                uiOutputValjanostPotpisa.BackColor = Color.Green;
            else
                uiOutputValjanostPotpisa.BackColor = Color.Red;

        }

        private void uiActionOdaberiDigitalniPotpis_Click(object sender, EventArgs e)
        {
            RadSDatotekama.PutanjaDoDigPotpisa = RadSDatotekama.OdaberiDatoteku();
        }
    }
}
