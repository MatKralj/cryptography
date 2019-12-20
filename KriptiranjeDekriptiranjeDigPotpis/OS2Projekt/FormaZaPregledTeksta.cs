using System.Windows.Forms;

namespace OS2Projekt
{
    public partial class FormaZaPregledTeksta : Form
    {
        Enumeracije.Kljucevi OdabraniKljuc { get; }
        string PutanjaKljuca { get; }

        public FormaZaPregledTeksta(Enumeracije.Kljucevi odabraniKljuc)
        {
            InitializeComponent();

            this.OdabraniKljuc = odabraniKljuc;
            this.PutanjaKljuca = Enumeracije.DohvatiPutanjuEnum(odabraniKljuc);
        }

        private void FormaZaPromjenuTeksta_Load(object sender, System.EventArgs e)
        {
            uiOutputImeDatoteke.Text = $"{OdabraniKljuc} ključ";

            uiInputTextDat.Text = RadSDatotekama.DohvatiStringIzBajta(RadSDatotekama.Citaj(PutanjaKljuca));
        }

        private void uiActionSpremiPromjene_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
