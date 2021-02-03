using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FINALRSA.Utulity
{

    public static class UUtilityManager
    {
        public static Random _random = new Random(); //  Random  değer üretmek için                                                    
        /// <summary>
        /// </summary>
        /// <param name="length"></param>
        /// <returns>Random Sayı Üretimi</returns> 
   
        public static int RandomNumberByRange(int min, int max)
        {
            return _random.Next(min, max);
        }
        public static List<int> RandomPrimerGenerateTwoNumber()
        {
            var returnList = new List<int>();
            var PrimerRandomNumber1 = RandomNumberByRange(1, 100);
            int PrimerStartCount = 101;
            while (CheckIfPrime(PrimerRandomNumber1) == false) // number generated will be check if is prime,if false regenerate another random number
            {
                PrimerRandomNumber1 = RandomNumberByRange(1, PrimerStartCount++);
            }
            PrimerStartCount++;
            int PrimerEndCount = PrimerStartCount + 100;

            var PrimerRandomNumber2 = RandomNumberByRange(PrimerStartCount, PrimerEndCount);

            while (CheckIfPrime(PrimerRandomNumber2) == false) // number generated will be check if is prime,if false regenerate another random number
            {
                PrimerRandomNumber2 = RandomNumberByRange(PrimerStartCount, PrimerEndCount++);
            }
            returnList.Add(PrimerRandomNumber1);
            returnList.Add(PrimerRandomNumber2);
            return returnList;
        }
        public static List<int> RandomPrimerBetweenGenerateTwoNumber()
        {
            var returnList = new List<int>();
            var PrimerRandomNumber1 = RandomNumberByRange(1, 100);
            int PrimerCount = 101;
            while (CheckIfPrime(PrimerRandomNumber1) == false) //Asal mı diye kontrol et değilse üretmeye devam et
            {
                PrimerRandomNumber1 = RandomNumberByRange(1, PrimerCount++);
            }
            var PrimerRandomNumber2 = PrimerRandomNumber1 + 1;//Ek güvenlik olarak 1. sayı ile aynı sayı üretimi olmasın diye rangi 1. sayıdan başlatıyorum.

            while (CheckObeb(PrimerRandomNumber1, PrimerRandomNumber2) == 1)//Asal mı diye kontrol et değilse üretmeye devam et
            {
                PrimerRandomNumber2++;
            }
            returnList.Add(PrimerRandomNumber1);
            returnList.Add(PrimerRandomNumber2);
            return returnList;
        }

        //euler function: f(n) = (p-1)(q-1) Asallar için gecerli sadece

        public static int EulerFunction(int p, int q)          //euler function: f(n) = (p-1)(q-1)
        {
            int m = p - 1;
            int n = q - 1;
            int Expolit = m * n;
            return Expolit;
        }

        //Euler Totient Fonksiyonu
        public static int EulerTotient(int n)
        {
            int Counter = 0;
            for (int i = 1; i < n; i++)
            {
                if (CheckObeb(n, i) == 1) // Aralarında asal olana kadar devam
                {
                    Counter++;
                }
            }

            return Counter;
        }
        public static int CheckObeb(int a, int b) //  asal mı değilmi ?
        {
            if (b == 0)
                return a;
            else
            {
                return CheckObeb(b, a % b);
            }
        }
        public static bool CheckPrimerNumber(int Number)
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = Number;
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    //return false;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.Write("Number is Prime.");
                return true;
            }
            return false;
        }
        public static bool CheckIfPrime(int n) //to check if the random number generated is prime
        {
            var sqrt = Math.Sqrt(n);
            for (var i = 2; i <= sqrt; i++)
                if ((n % i) == 0) return false;
            return true;
        }

        // Function to print the character sequence 
        // for the given ASCII sentence 
        public static string asciiToSentence(String str, int len)
        {
            var ReturnResult = "";
            int num = 0;
            for (int i = 0; i < len; i++)
            {

                // Append the current digit 
                num = num * 10 + (str[i] - '0');

                // If num is within the required range 
                if (num >= 32 && num <= 122)
                {

                    // Convert num to char 
                    char ch = (char)num;
                    Console.Write(ch);
                    ReturnResult += ch;
                    // Reset num to 0 
                    num = 0;
                }
            }
            return ReturnResult;
        }
        public static List<int> StringToAscii(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Value cannot be null or empty.", nameof(value));

            return value.Select(System.Convert.ToInt32).ToList();
        }
        public static string ASCIItoStr(string value)
        {
            var ReturnStr = "";
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Value cannot be null or empty.", nameof(value));
            var CheckInt = 0;
            var List = value.Split(',').ToList().Where(str => int.TryParse(str, out CheckInt)).Select(str => CheckInt).ToList();

            foreach (var _Charto in List)
            {
                char c = (char)_Charto;
                ReturnStr += c;
            }
            return ReturnStr;
        }

        public static string ToBinaryString(BigInteger bigint)
        {
            var bytes = bigint.ToByteArray();
            var index = bytes.Length - 1;
            var base2 = new StringBuilder(bytes.Length * 8);
            var binary = Convert.ToString(bytes[index], 2);
            if (binary[0] != '0' && bigint.Sign == 1) base2.Append('0');
            base2.Append(binary);
            for (index--; index >= 0; index--)
                base2.Append(Convert.ToString(bytes[index], 2).PadLeft(8, '0'));
            return base2.ToString();
        }
        public static BigInteger NewBigInteger2(string binaryValue)
        {
            BigInteger res = 0;
            if (binaryValue.Count(b => b == '1') + binaryValue.Count(b => b == '0') != binaryValue.Length) return res;
            foreach (var c in binaryValue)
            {
                res <<= 1;
                res += c == '1' ? 1 : 0;
            }

            return res;
        }



    }



}

