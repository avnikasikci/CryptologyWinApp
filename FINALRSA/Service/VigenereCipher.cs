using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class VigenereCipher : IEncryptionAlgorithm
    {
        public string Name => "Vigenere Cipher";

        const char randomChar = 'a';
        string _key;
        string _text;

        string _output;

        public VigenereCipher(string text, string key)
        {
            _key = key;
            _text = text;
        }

        public string Encrypt()
        {
            // Split
            IEnumerable<Block> blocks = Block.Split(_text, _key.Length);

            _output = string.Empty;

            // Encrypt ve kulalnıcıya verilecek mesajın birleştiriyorum.
            foreach (Block block in blocks) // dönen liste ile şifreli mesajı oluşturuyorum.
            {
                _output += block.Encrypt(_key);
            }

            return _output;
        }

        public string Decrypt()
        {
            // Split
            IEnumerable<Block> blocks = Block.Split(_output, _key.Length);

            _output = string.Empty;

            // Decrypt and merge
            foreach (Block block in blocks)
            {
                _output += block.Decrypt(_key);
            }

            return _output.TrimEnd(randomChar);
        }


        class Block
        {
            string _content;

            public Block(char[] content)
            {
                _content = new string(content);
            }

            public string Encrypt(string key)
            {
                char[] contentArr = _content.ToCharArray();
                char[] keyArr = key.ToCharArray();

                for (int i = 0; i < contentArr.Length - 1; i++)
                {
                    contentArr[i] = (char)((contentArr[i] + keyArr[i]) % 127);
                }

                return new string(contentArr);
            }

            public string Decrypt(string key)
            {
                char[] contentArr = _content.ToCharArray();
                char[] keyArr = key.ToCharArray();

                for (int i = 0; i < contentArr.Length - 1; i++)
                {
                    if (contentArr[i] < keyArr[i])
                    {
                        contentArr[i] += (char)127;// 127 delete demek eğer anahtarın değerinden kücükse o harfe delete atıyorum.
                    }

                    contentArr[i] = (char)((contentArr[i] - keyArr[i]) % 127); // vigenere tablosundaki kaydırma mantığı
                }

                return new string(contentArr);
            }

            public static IEnumerable<Block> Split(string text, int blockLength) // blockl uzunluğunu anahtar belirler.
            {
                while (text.Length % blockLength != 0) //gelen text ile block uzunluğu eşit olana kadar modunu alıyorum.
                {
                    text += randomChar; // random olarak alfabedeki en cok kullanılan bir harf belirledim.
                }

                ICollection<Block> blocks = new List<Block>();

                for (int i = 0; i < text.Length - 1; i += blockLength) // buradaki işlemdede şifrenilcek mesaj ile anahtarımı topluyorum. elde edilen sonucu listeye atıyorum.
                {
                    char[] arr = new char[blockLength];

                    for (int j = 0; j < blockLength; j++)
                    {
                        arr[j] = text[i + j];
                    }

                    blocks.Add(new Block(arr));
                }

                return blocks;
            }
        }
    }
}