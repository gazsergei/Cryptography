using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;

namespace RSA
{
    public class RSA
    {
        #region Consts

        private const int MAX_RANDOM_VALUE = 50;

        #endregion

        #region Properties

        public BigInteger P { get; set; }
        public BigInteger Q { get; set; }
        public BigInteger N { get; set; }
        public BigInteger Fn { get; set; }
        public BigInteger E { get; set; }
        public BigInteger D { get; set; }
        public PublicKey PublicKey { get; set; }
        public PrivateKey PrivateKey { get; set; }
        public string InputMessage { get; set; }
        public List<BigInteger> InputNumbers { get; set; }
        public List<BigInteger> Сipher { get; set; }
        public List<BigInteger> OutputNumber { get; set; }
        public string OutputMessage { get; set; }

        #endregion

        #region Conctructors

        public RSA(string message)
        {
            if (string.IsNullOrEmpty(message))
                throw new Exception("");

            P = GeneratePrimeNumber();
            Q = GeneratePrimeNumber();
            N = GetN(P, Q);
            Fn = EilerFunction(P, Q);
            E = GetE(Fn);
            D = GetD(Fn, E);
            PublicKey = GetPublicKey(E, N);
            PrivateKey = GetPrivateKey(D, N);
            InputMessage = message;
            InputNumbers = ConvertInputMessageToNumbers(message);
            Сipher = GetCipher(InputNumbers, E, N);
            OutputNumber = GetOutputNumbers(Сipher, D, N);
            OutputMessage = GetOutputMessage(OutputNumber);
        }

        #endregion

        #region Private methods

        private PublicKey GetPublicKey(BigInteger e, BigInteger n)
        {
            return new PublicKey(e, n);
        }


        private PrivateKey GetPrivateKey(BigInteger d, BigInteger n)
        {
            return new PrivateKey(d, n);
        }

        private BigInteger GetN(BigInteger p, BigInteger q)
        {
            return p * q;
        }

        public BigInteger GeneratePrimeNumber(int maxValue = MAX_RANDOM_VALUE)
        {
            var arr = GeneratePrimeNumberArray(maxValue);
            var max = arr.Count - 1;

            var index = (int) GenerateRandomNumber(max);

            return arr[index];
        }

        private List<BigInteger> GeneratePrimeNumberArray(BigInteger max)
        {
            var arr = new List<BigInteger>();

            for (var i = 2; i <= max; i++)
            {
                var isPrime = true;

                for (var j = 2; j < i; j++)
                {
                    if ((i % j == 0) & (i % 1 == 0))
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    arr.Add(new BigInteger(i));
            }

            return arr;
        }

        private BigInteger EilerFunction(BigInteger p, BigInteger q)
        {
            return (p - 1) * (q - 1);
        }

        private BigInteger EilerFunction(BigInteger n)
        {
            var nInteger = (int)n;
            var result = nInteger;

            for (var i = 2; i * i <= nInteger; ++i)
            {
                if (nInteger % i == 0)
                {
                    while (nInteger % i == 0)
                        nInteger /= i;

                    result -= result / i;
                }
            }

            if (nInteger > 1)
                result -= result / nInteger;

            return new BigInteger(result);
        }

        private BigInteger GetGCD(BigInteger i, BigInteger j)
        {
            var iInteger = (int)i;
            var jInteger = (int)j;

            while (iInteger != 0 && jInteger != 0)
            {
                if (iInteger > jInteger)
                    iInteger %= jInteger;
                else
                    jInteger %= iInteger;
            }

            return iInteger == 0 ? jInteger : iInteger;
        }

        private BigInteger GenerateRandomNumber(int maxValue)
        {
            // Задержка нужна чтобы предотвратить генерацию одинаковых значений
            Thread.Sleep(500);

            var random = new Random();
            var result = random.Next(1, maxValue + 1);

            return new BigInteger(result);
        }

        private BigInteger GenerateRandomNumber(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                throw new Exception("Min value is greater than max value");
            }

            var random = new Random();
            var result = random.Next(minValue, maxValue + 1);

            return new BigInteger(result);
        }

        private BigInteger GetE(BigInteger fn)
        {
            var fnInteger = (int) fn;

            var result = 0;

            for (var i = 3; i < fnInteger; i++)
            {
                var value = GetGCD(i, fn);

                if (value == 1)
                {
                    result = i;
                    break;
                }
            }

            return new BigInteger(result);
        }

        private BigInteger GetD(BigInteger fn, BigInteger e)
        {
            var result = EuclideAlgorithm(fn, e);

            if (result.Y1 < 0)
            {
                return result.Y1 + fn;
            }

            return result.D1;
        }

        private BigInteger FastExp(BigInteger value, BigInteger exponent, BigInteger modulus)
        {
            return BigInteger.ModPow(value, exponent, modulus);
        }

        private ResultEuclideAlgorithm EuclideAlgorithm(BigInteger a, BigInteger b)
        {
            var d0 = (int) a;
            var d1 = (int) b;
            var x0 = 1;
            var x1 = 0;
            var y0 = 0;
            var y1 = 1;

            while (d1 > 1)
            {
                var q = d0 / d1;
                var d2 = d0 % d1;
                var x2 = x0 - q * x1;
                var y2 = y0 - q * y1;
                d0 = d1;
                d1 = d2;
                x0 = x1;
                x1 = x2;
                y0 = y1;
                y1 = y2;
            }

            return new ResultEuclideAlgorithm(x1, y1, d1);
        }

        private List<BigInteger> ConvertInputMessageToNumbers(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new Exception("Input message not found");
            }

            var numbers = new List<BigInteger>();

            foreach (var item in message.ToCharArray())
                numbers.Add((int)item - (int)'A');

            return numbers;
        }

        private List<BigInteger> GetCipher(List<BigInteger> numbers, BigInteger e, BigInteger n)
        {
            if (numbers == null)
                throw new Exception("");

            var result = new List<BigInteger>();

            foreach (var item in numbers)
                result.Add(BigInteger.Remainder(BigInteger.Pow(item, (int) e), n));

            return result;
        }

        private List<BigInteger> GetOutputNumbers(List<BigInteger> numbers, BigInteger d, BigInteger n)
        {
            if (numbers == null)
                throw new Exception("");

            var result = new List<BigInteger>();

            foreach (var item in numbers)
                result.Add(BigInteger.Remainder(BigInteger.Pow(item, (int) d), n));

            return result;
        }

        private string GetOutputMessage(List<BigInteger> numbers)
        {
            var result = new List<char>();

            foreach (var item in numbers)
                result.Add((char)((int) 'A' + item));

            return result.ToString();
        }

        #endregion
    }

    public class ResultEuclideAlgorithm
    {
        public BigInteger X1 { get; set; }
        public BigInteger Y1 { get; set; }
        public BigInteger D1 { get; set; }

        public ResultEuclideAlgorithm(BigInteger x1, BigInteger y1, BigInteger d1)
        {
            X1 = x1;
            Y1 = y1;
            D1 = d1;
        }
    }

    public class PublicKey
    {
        public BigInteger E { get; set; }
        public BigInteger N { get; set; }

        public PublicKey(BigInteger e, BigInteger n)
        {
            E = e;
            N = n;
        }
    }

    public class PrivateKey
    {
        public BigInteger D { get; set; }
        public BigInteger N { get; set; }

        public PrivateKey(BigInteger d, BigInteger n)
        {
            D = d;
            N = n;
        }
    }
}
