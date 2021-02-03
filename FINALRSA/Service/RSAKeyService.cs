using FINALRSA.Collection.Entity;
using FINALRSA.Utulity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public class RSAKeyService : IRSAKeyService
    {
        RSAKeyManager _rSAKeyManager = new RSAKeyManager();

        BigInteger p, q, n, z, d = 0, e, i;

        public RSAKeyService(RSAKeyManager rSAKeyManager)
        {
            _rSAKeyManager = rSAKeyManager;

            p = _rSAKeyManager.pPrimeNumber1;
            q = _rSAKeyManager.qPrimeNumber2;
            n = _rSAKeyManager.nNumberModulus;
            z = _rSAKeyManager.zEulerTotientValue;
            e = _rSAKeyManager.ePublicKey;
            d = _rSAKeyManager.dPrivateKey;

            n = p * q;
            z = (p - 1) * (q - 1); // EulerTotient sayıların asallığı kontol edildiği için bu şekilde yapmak gerekir.

            for (e = 2; e < z; e++)
            {
                if (gcdValueO(e, z) == 1) //e, public keyin üssü içindir asal olması ve 1-z arasında olması gerekir.
                {
                    break;
                }
            }
            //System.out.println("the value of e = " + e);

            // calculate d
            for (i = 0; i <= 9; i++)
            {
                BigInteger x = 1 + (i * z);
                if (x % e == 0) //d  private key in üssü için gereklidir.
                {
                    d = x / e;
                    break;
                }
            }
        }



        public BigInteger setGenaretePublicKey()
        {

            p = _rSAKeyManager.pPrimeNumber1;
            q = _rSAKeyManager.qPrimeNumber2;


            n = _rSAKeyManager.nNumberModulus;
            z = _rSAKeyManager.zEulerTotientValue;
            for (e = 2; e < z; e++)
            {
                if (gcdValueO(e, z) == 1) // e is for public key exponent
                {
                    break;
                }
            }
            return e;
        }
        public BigInteger setGenaretePrivateKey()
        {

            p = _rSAKeyManager.pPrimeNumber1;
            q = _rSAKeyManager.qPrimeNumber2;


            n = _rSAKeyManager.nNumberModulus;
            z = _rSAKeyManager.zEulerTotientValue;
            // calculate d
            for (i = 0; i <= 9; i++)
            {
                BigInteger x = 1 + (i * z);
                if (x % e == 0) //d is for private key exponent
                {
                    d = x / e;
                    break;
                }
            }
            return d;
        }
        private static BigInteger gcdValueO(BigInteger e, BigInteger z)
        {
            if (e == 0)
            {
                return z;
            }
            else
            {
                return gcdValueO(z % e, e);
            }
        }

        /*Enc Desc*/


        BigInteger Encrypter(int msg)
        {
            //Encrypting  C = msg ^e mod n
            //return (Math.Pow(msg, e)) % n;
            //return ((msg ^ e) % n);

            return BigInteger.ModPow(msg, e, n);


        }

        public List<BigInteger> encrypt(String msg)
        {
            int[] charactersAsNumbers = new int[msg.Length];
            for (int i = 0; i < msg.Length; i++)
            {
                charactersAsNumbers[i] = (int)msg[i];
            }
            //System.out.println("Plain text as sequence of numbers: " + Arrays.toString(charactersAsNumbers));

            //int[] encryptedMsg = new int[msg.Length];
            List<BigInteger> encryptedMsg = new List<BigInteger>();
            for (int i = 0; i < charactersAsNumbers.Length; i++)
            {
                //encryptedMsg[i] = encrypt(charactersAsNumbers[i]);
                encryptedMsg.Add(Encrypter(charactersAsNumbers[i]));
            }
            return encryptedMsg;
        }
        public string encryptInput(String msg)
        {
            List<BigInteger> BigIntList = this.encrypt(msg);
            var ReturnResult = "";
            //var checkSperator = 0;
            //foreach (var BigInt in BigIntList)
            //{
            //    string ResultStr = Convert.ToBase64String(BigInt.ToByteArray());
            //    ReturnResult += (checkSperator == 1) ? "," + ResultStr : ResultStr;
            //    checkSperator++;
            //    //byte[] bytes = Convert.FromBase64String(str2);
            //    //if (c_ == new BigInteger(bytes))
            //    //{
            //    //    var essss = true;
            //    //}
            //}
            ReturnResult = string.Join(",", BigIntList);
            return ReturnResult;
        }


        BigInteger Decrypter(BigInteger encryptedLocal)
        {
            return BigInteger.ModPow(encryptedLocal, d, n);
        }

        public String decrypt(List<BigInteger> encrypted)
        {
            StringBuilder builder = new StringBuilder();


            foreach (BigInteger encryptedCharacter in encrypted)
            //for (double encryptedCharacter: encrypted)
            {
                BigInteger decryptedCharacter = Decrypter(encryptedCharacter);

                //var se = Convert.ToInt32( decryptedCharacter.ToString());
                builder.Append((char)decryptedCharacter);

                //builder.Append(Encoding.ASCII.GetString(decryptedCharacter.ToByteArray()));
            }
            return builder.ToString();
        }

        public String decryptInput(string encryptedStr)
        {
            List<BigInteger> encrypted = new List<BigInteger>();
            var SperatorList = encryptedStr.Split(',').ToList();
            foreach (var _Sperator in SperatorList)
            {
                //byte[] bytes = Convert.FromBase64String(_Sperator);
                //encrypted.Add(new BigInteger(bytes));
                encrypted.Add(BigInteger.Parse(_Sperator));

            }
            return decrypt(encrypted);


        }
    }
}
