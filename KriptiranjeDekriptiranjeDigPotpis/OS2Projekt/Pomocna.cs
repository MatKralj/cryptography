using System;
using System.Windows.Forms;

namespace OS2Projekt
{
    class Pomocna
    {

        public static void OtvoriFormu(Form formaZaOtvaranje, Form trenutnaForma, bool zatvoriTrenutnuFormu = true)
        {
            if (zatvoriTrenutnuFormu)
            {
                trenutnaForma.Hide();
                formaZaOtvaranje.ShowDialog();
                trenutnaForma.Close();
            }
            else
            {
                formaZaOtvaranje.ShowDialog();
            }
        }

        public static Enumeracije.Kljucevi DohvatiKljucIzCombBoxa(ComboBox uiComboBoxKljucevi)
        {
            string odabraniElement = "";
            try
            {
                odabraniElement = uiComboBoxKljucevi.SelectedItem.ToString();

                if (odabraniElement == "Javni ključ")
                    return Enumeracije.Kljucevi.Javni;
                else if (odabraniElement == "Privatni ključ")
                    return Enumeracije.Kljucevi.Privatni;
                else if (odabraniElement == "Tajni ključ")
                    return Enumeracije.Kljucevi.Tajni;
            }
            catch (Exception ex)
            {
                return Enumeracije.Kljucevi.Null;
            }

            return Enumeracije.Kljucevi.Null;
        }

        public static Enumeracije.VrstaRada ProvjeriOdabranuRadnju(bool datotekaJeOdabrana, uiFormMain forma)
        {
            if (datotekaJeOdabrana && forma.uiRadioKriptiraj.Checked && forma.uiRadioSimetricniAlg.Checked)
                return Enumeracije.VrstaRada.KriptirajSimetricno;

            else if (datotekaJeOdabrana && forma.uiRadioDekriptiraj.Checked && forma.uiRadioSimetricniAlg.Checked)
                return Enumeracije.VrstaRada.DekriptirajSimetricno;

            else if (datotekaJeOdabrana && forma.uiRadioKriptiraj.Checked && forma.uiRadioAsimetricniAlg.Checked)
                return Enumeracije.VrstaRada.KriptirajAsimetricno;

            else if (datotekaJeOdabrana && forma.uiRadioDekriptiraj.Checked && forma.uiRadioAsimetricniAlg.Checked)
                return Enumeracije.VrstaRada.DekriptirajAsimetricno;

            return Enumeracije.VrstaRada.Null;
        }

    }
}
