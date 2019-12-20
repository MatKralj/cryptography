using System.Security.Cryptography;
using System.Text;


namespace OS2Projekt
{
    class AsimetricnoKriptiranje
    {

        private static RSACryptoServiceProvider RSAKript;
        public string JavniKljuc { get; private set; }
        public string PrivatniKljuc { get; private set; }

        private RSAParameters rsaParametri;

        private static AsimetricnoKriptiranje instanca;


        public static AsimetricnoKriptiranje getInstance()
        {
            return instanca;
        }


        public static AsimetricnoKriptiranje KreirajInstancu()
        {
            instanca = new AsimetricnoKriptiranje();

            return instanca;
        }

        private AsimetricnoKriptiranje()
        {
            RSAKript = new RSACryptoServiceProvider(2048);
            rsaParametri = RSAKript.ExportParameters(true);

            this.JavniKljuc = RadSDatotekama.DohvatiStringIzBajta(rsaParametri.Modulus);
            this.PrivatniKljuc = RadSDatotekama.DohvatiStringIzBajta(rsaParametri.D);
            PostaviKljuceveUDat();
        }

        private void PostaviKljuceveUDat()
        {
            RadSDatotekama.OverwriteFile(RadSDatotekama.PrivatniKljucPutanja, this.PrivatniKljuc);
            RadSDatotekama.OverwriteFile(RadSDatotekama.JavniKljucPutanja, this.JavniKljuc);
        }

        public byte[] Kriptiraj(byte[] cistiTekst)
        {
            byte[] kriptiraniTekstByt = RSAKript.Encrypt(cistiTekst, false);

            return kriptiraniTekstByt;
        }

        public string Dekriptiraj(byte[] kriptiraniTekst)
        {
            byte[] dekriptiraniTekstByt = RSAKript.Decrypt(kriptiraniTekst, false);

            return Encoding.UTF8.GetString(dekriptiraniTekstByt);
        }

        public byte[] IzracunajSazetak(byte[] original)
        {
            SHA256Managed shaProvider = new SHA256Managed();
            shaProvider.ComputeHash(original, 0, original.Length);

            return shaProvider.Hash;
        }

        public byte[] DigitalnoPotpisi(byte[] cistiTekst)
        {
            byte[] sazetak = IzracunajSazetak(cistiTekst);

            byte[] digitalniPotpis = RSAKript.SignHash(sazetak, CryptoConfig.MapNameToOID("SHA256"));
            return digitalniPotpis;
        }

        public bool ProvjeriDigitalniPotpis(byte[] digitalniPotpis, byte[] original)
        {
            return RSAKript.VerifyHash(IzracunajSazetak(original), CryptoConfig.MapNameToOID("SHA256"), digitalniPotpis);
        }

    }
}