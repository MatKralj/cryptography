using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OS2Projekt
{
    class RadSDatotekama
    {
        public static string FolderPath { get; private set; }
        public static string JavniKljucPutanja { get; set; }
        public static string PrivatniKljucPutanja { get; set; }
        public static string TajniKljucPutanja { get; private set; }

        public static string AsimetricnoKriptiranjePutanja { get; private set; }
        public static string SimetricnoKriptiranjePutanja { get; private set; }
        public static string PutanjaDoOdabraneDatoteke { get; set; }

        public static string PutanjaDoDigPotpisa { get; set; }

        public static string PutanjaDoSazetka { get; private set; }


        public static bool OdaberiMapu()
        {
            FolderBrowserDialog folderBrDialog = new FolderBrowserDialog();
            if (folderBrDialog.ShowDialog() == DialogResult.OK)
            {
                FolderPath = folderBrDialog.SelectedPath;

                PutanjaDoDigPotpisa = FolderPath + @"\digitalniPotpis.txt";
                PutanjaDoSazetka = FolderPath + @"\sazetak.txt";
                AsimetricnoKriptiranjePutanja = FolderPath + @"\asimetricnoKriptiraniTekst.txt";
                SimetricnoKriptiranjePutanja = FolderPath + @"\simetricnoKriptiraniTekst.txt";
                return true;
            }
            else
                FolderPath = "";

            return false;
        }

        public static string OdaberiDatoteku()
        {
            OpenFileDialog fDialog = new OpenFileDialog();

            string odabranaPutanja = "";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                odabranaPutanja = fDialog.FileName;
            }

            return odabranaPutanja;
        }

        public static void IzbrisiSadrzajDatoteke(string putanja)
        {
            FileStream datoteka = new FileStream(putanja, FileMode.Truncate);
            datoteka.Close();
        }

        public static void KreirajDatotekeKljuceva()
        {
            JavniKljucPutanja = FolderPath + @"\javniKljuc.txt";
            PrivatniKljucPutanja = FolderPath + @"\privatniKljuc.txt";
            TajniKljucPutanja = FolderPath + @"\tajniKljuc.txt";

            File.Create(JavniKljucPutanja).Close();
            File.Create(TajniKljucPutanja).Close();
            File.Create(PrivatniKljucPutanja).Close();
        }

        public static byte[] Citaj(string putanjaDoDat)
        {
            byte[] returnString = null;

            if (putanjaDoDat != null)
            {
                returnString = DohvatiBajtIzStringa(File.ReadAllText(putanjaDoDat));
            }

            return returnString;
        }

        public static byte[] DohvatiBajtIzStringa(string tekst)
        {
            try
            {
                return Convert.FromBase64String(tekst);
            }
            catch (Exception ex)
            {
                return Encoding.UTF8.GetBytes(tekst);
            }
        }

        public static string DohvatiStringIzBajta(byte[] bajtovi)
        {
            return Convert.ToBase64String(bajtovi);
        }

        public static void OverwriteFile(string putanjaDoDat, byte[] bajtoviZaPisanje)
        {
            File.WriteAllText(putanjaDoDat, DohvatiStringIzBajta(bajtoviZaPisanje));

        }

        public static void OverwriteFile(string putanjaDoDat, string tekstzaPisanje)
        {
            //File.WriteAllText(putanjaDoDat, DohvatiStringIzBajta(bajtoviZaPisanje));
            File.WriteAllText(putanjaDoDat, tekstzaPisanje);

        }

        public static string OdaberiKljuc()
        {
            string putanjaDoKljuca = "";
            OpenFileDialog fDialog = new OpenFileDialog();
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                putanjaDoKljuca = fDialog.FileName;
            }

            return putanjaDoKljuca;
        }
    }
}
