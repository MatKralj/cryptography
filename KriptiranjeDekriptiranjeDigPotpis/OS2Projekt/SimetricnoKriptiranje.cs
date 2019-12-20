using System;
using System.Security.Cryptography;
using System.Text;

namespace OS2Projekt
{
    class SimetricnoKriptiranje
    {

        private AesCryptoServiceProvider AesAlg;

        public SimetricnoKriptiranje()
        {
            this.AesAlg = new AesCryptoServiceProvider();

            AesAlg.BlockSize = 128;
            AesAlg.KeySize = 256;

            AesAlg.GenerateKey();
            AesAlg.GenerateIV();

            AesAlg.Mode = CipherMode.CBC;
            AesAlg.Padding = PaddingMode.PKCS7;

            RadSDatotekama.OverwriteFile(RadSDatotekama.TajniKljucPutanja, AesAlg.Key);
        }

        public byte[] Kriptiraj(byte[] bajtoviZaKriptiranje)
        {

            ICryptoTransform aesEncryptor = AesAlg.CreateEncryptor(AesAlg.Key, AesAlg.IV);

            byte[] kriptiraniTekstByte = aesEncryptor.TransformFinalBlock(bajtoviZaKriptiranje, 0, bajtoviZaKriptiranje.Length);

            return kriptiraniTekstByte;
        }

        public string Dekriptiraj(byte[] kriptiraniBajtovi)
        {
            ICryptoTransform aesDecryptor = AesAlg.CreateDecryptor(AesAlg.Key, AesAlg.IV);
            byte[] cistiTekst = aesDecryptor.TransformFinalBlock(kriptiraniBajtovi, 0, kriptiraniBajtovi.Length);

            return Encoding.UTF8.GetString(cistiTekst);
        }

        internal void GenerirajNoviKljuc()
        {
            throw new NotImplementedException();
        }
    }

}
