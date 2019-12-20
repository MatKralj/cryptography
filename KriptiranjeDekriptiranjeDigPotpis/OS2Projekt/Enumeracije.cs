
namespace OS2Projekt
{
    public class Enumeracije
    {
        public enum Kljucevi
        {
            Javni,
            Privatni,
            Tajni,
            Null
        }

        public enum VrstaRada
        {
            KriptirajAsimetricno,
            KriptirajSimetricno,
            DekriptirajAsimetricno,
            DekriptirajSimetricno,
            Null
        }

        public static string DohvatiPutanjuEnum(Kljucevi kljuc)
        {
            if (kljuc is Kljucevi.Javni)
                return RadSDatotekama.JavniKljucPutanja;
            else if (kljuc is Kljucevi.Privatni)
                return RadSDatotekama.PrivatniKljucPutanja;
            else if (kljuc is Kljucevi.Tajni)
                return RadSDatotekama.TajniKljucPutanja;

            return "";
        }
    }
}
