using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FINALRSA.Collection.Entity
{
    public class RSAKeyManager
    {
        public int Id { get; set; } // Uretilen keyin Idsi
        public int pPrimeNumber1 { get; set; } // Asal sayı 1 orn:p 
        public int qPrimeNumber2 { get; set; } // Asal sayı 1 orn:q

        public int nNumberModulus { get { return pPrimeNumber1 * qPrimeNumber2; } } // Asal sayı  n=pq hesaplanır
        public int zEulerTotientValue { get { return ((pPrimeNumber1 - 1) * (qPrimeNumber2 - 1)); } } // Asal sayı  n=pq hesaplanır
        public int ePublicKey { get; set; } // e harfi temsili
        public int dPrivateKey { get; set; } // d harfi temsili

    }
}
