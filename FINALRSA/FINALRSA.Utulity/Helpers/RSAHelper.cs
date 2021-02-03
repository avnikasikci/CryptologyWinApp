using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace RSAManager.Helpers
{
    public class RSAHelper
    {
        private readonly int _keySize;
        private readonly RSACryptoServiceProvider _provider;
        private readonly string _key;

        public RSAHelper(int keySize)
        {
            _provider = new RSACryptoServiceProvider(keySize);
            _key = _provider.ToXmlString(true);
            _keySize = keySize;
        }

        public string PublicKey()
        {
            return RSAKeyValue.ToPublicKey(_key).ToXml();
        }

        public string PrivateKey()
        {
            return RSAKeyValue.ToPrivateKey(_key).ToXml();
        }

        public byte[] Encrypt(string value)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            return _provider.Encrypt(bytes, false);
        }

        public string Decrypt(byte[] value)
        {
            byte[] decrypted = _provider.Decrypt(value, false);
            return Encoding.UTF8.GetString(decrypted);
        }

        public string EncryptString(string inputString, string publicKey)
        {
            using (var rsaCryptoServiceProvider = new RSACryptoServiceProvider(_keySize))
            {
                rsaCryptoServiceProvider.FromXmlString(publicKey); // RSACryptoServiceProvider windows 2000 yılından beri rsa algoritması için çıkartığı bir servistir xml datasında public ve private keyler mevcut bunları string dönüştüyorum.
                int keySize = _keySize/8; // metnin uzunluğunu 8 e bölüyorum cünkü kullanının secitiği anahtar örn.512 ise 8 e bölersek 64 çıkar buda metni oluştuaracağım blockları tutar.
                byte[] bytes = Encoding.UTF32.GetBytes(inputString); //metnin asci tablosundaki karşılıkları ile byte array dizisine ceviyorum
                int maxLength = keySize - 42; // 42 dememim sebebi rsa algoritmasında 54 bit şifrelemede kullanılır.
                int dataLength = bytes.Length; // metnin boyutu
                int iterations = dataLength/maxLength; // eğer şifrelenecek metnin boyutunu anahtarıma bölersem kac bit kaydıracaımı bulmuş olurum.
                StringBuilder stringBuilder = new StringBuilder(); // en son dönecek mesajı tutar.
                for (int i = 0; i <= iterations; i++)
                {
                    byte[] tempBytes = //yeni bir byte dizisi oluşturuyorum eğer 54 bitten fazla ise boyut datanın boyutunu iterasyonun indexi ile kaydırıyorum.
                        new byte[(dataLength - maxLength*i > maxLength) ? maxLength : dataLength - maxLength*i];
                    Buffer.BlockCopy(bytes, maxLength*i, tempBytes, 0, tempBytes.Length);
                    byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt(tempBytes, true); //rsa kendi şifreler burası benim kodum değil 
                    Array.Reverse(encryptedBytes); // dönen datayı tersine ceviyorum cünkü ascii ile okuyacağım
                    stringBuilder.Append(Convert.ToBase64String(encryptedBytes));
                }
                return stringBuilder.ToString();
            }
        }

        public string DecryptString(string inputString, string privateKey)
        {
            using (var rsaCryptoServiceProvider = new RSACryptoServiceProvider(_keySize))
            {
                rsaCryptoServiceProvider.FromXmlString(privateKey);
                int base64BlockSize = ((_keySize/8)%3 != 0) ? (((_keySize/8)/3)*4) + 4 : ((_keySize/8)/3)*4; // 64 bitlik blocklar halinde tutyorum veriyi
                int iterations = inputString.Length/base64BlockSize; // kaydarıcağım bit sayısını beliyorliyorm
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < iterations; i++)
                {
                    byte[] encryptedBytes = Convert.FromBase64String( // dönen datayı kaydırarak en son rsa servisine göndercem
                        inputString.Substring(base64BlockSize*i, base64BlockSize));
                    Array.Reverse(encryptedBytes);
                    arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(
                        encryptedBytes, true));
                }
                return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]); //return etmmeden arrayi string dönüştüyorum.
            }
        }

    }
}
