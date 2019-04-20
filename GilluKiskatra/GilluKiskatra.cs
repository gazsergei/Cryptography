using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;

namespace GilluKiskatra
{
    public class GilluKiskatra
    {
        #region Consts

        private const int MAX_RANDOM_VALUE = 50;

        #endregion

        #region Properties

        public BigInteger P { get; set; }
        public BigInteger Q { get; set; }
        public BigInteger N { get; set; }
        public BigInteger V { get; set; }
        public BigInteger Fn { get; set; }
        public BigInteger S { get; set; }
        public BigInteger Id { get; set; }
        public BigInteger Sp { get; set; }
        public BigInteger R { get; set; }
        public BigInteger X { get; set; }
        public BigInteger E { get; set; }
        public BigInteger Y { get; set; }
        // Временное поля, пока не буйдет наёдена ошибка в подсчётах
        public bool Result { get; set; }

        #endregion

        #region Сonstructors

        public GilluKiskatra()
        {
            P = GeneratePrimeNumber(MAX_RANDOM_VALUE);

            Q = GeneratePrimeNumber(MAX_RANDOM_VALUE);
        }

        public GilluKiskatra(BigInteger p, BigInteger q)
        {
            P = p;
            Q = q;

            N = GetN(P, Q);
            Fn = EilerFunction(P, Q);


            V = GetV(Fn);
            S = GetS(V, Fn);

            // Id < n
            Id = GetId(N - 1);
            Sp = GetSp(Id, S, N);

            // 1 < r < n
            R = GetR((int)N - 1);

            X = GetX(R, V, N);

            // 1 < e < v
            E = GetE((int)V - 1);

            Y = GetY(R, Sp, E, N);
            Result = GetResult();
        }

        // Для проверки расчётов из методички
        public GilluKiskatra(BigInteger p, BigInteger q, BigInteger v, BigInteger id, BigInteger r, BigInteger e)
        {
            P = p;
            Q = q;
            V = v;
            Id = id;
            R = r;
            E = e;

            N = GetN(P, Q);
            Fn = EilerFunction(p, q);
            S = GetS(V, Fn);
            Sp = GetSp(Id, S, N);
            X = GetX(R, V, N);
            Y = GetY(R, Sp, E, N);
            Result = GetResult();
        }

        #endregion

        #region Public methods

        public void Calculate(BigInteger p, BigInteger q)
        {
            N = GetN(P, Q);
            Fn = EilerFunction(P, Q);
            V = GetV(Fn);
            S = GetS(V, Fn);
            Id = GetId(N);
            Sp = GetSp(Id, S, N);

            // ??
            R = GetR((int)N - 1);

            X = GetX(R, V, N);

            // ??
            E = GetE((int)V - 1);

            Y = GetY(R, Sp, E, N);
        }

        public bool CheckEquality(BigInteger x, BigInteger y, BigInteger v, BigInteger id, BigInteger e, BigInteger n)
        {
            var firstMultiplier = BigInteger.Pow(y, (int)v);
            var secondMultiplier = BigInteger.Pow(id, (int)e);
            var multiplicationResult = firstMultiplier * secondMultiplier;

            var result = BigInteger.Remainder(multiplicationResult, n);

            return x == result;
        }

        public bool GetResult()
        {
            return CheckEquality(X, Y, V, Id, E, N);
        }

        public BigInteger GeneratePrimeNumber(int maxValue = MAX_RANDOM_VALUE)
        {
            var arr = GeneratePrimeNumberArray(maxValue);
            var max = arr.Count - 1;

            var index = (int)GenerateRandomNumber(max);

            return arr[index];
        }

        public bool Equals(GilluKiskatra obj)
        {
            return P == obj.P &&
                   Q == obj.Q &&
                   N == obj.N &&
                   V == obj.V &&
                   S == obj.S &&
                   Id == obj.Id &&
                   Sp == obj.Sp &&
                   R == obj.R &&
                   X == obj.X &&
                   E == obj.E &&
                   Y == obj.Y;
        }

        #endregion

        #region Private methods

        private BigInteger GetN(BigInteger p, BigInteger q)
        {
            return p * q;
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

        private BigInteger GetV(BigInteger fn)
        {
            var fnInteger = (int)fn;

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

        private BigInteger GetS(BigInteger v, BigInteger fn)
        {
            var exponent = (int)EilerFunction(fn) - 1;

            var firstMultiplier = BigInteger.Pow(v, exponent);
            var result = BigInteger.Remainder(firstMultiplier, fn);

            return result;
        }

        private BigInteger GetId(BigInteger max)
        {
            var rnd = new Random();
            var result = rnd.Next((int)max);

            return new BigInteger(result);
        }

        private BigInteger GetSp(BigInteger id, BigInteger s, BigInteger n)
        {
            var exponent = (int)(s * (EilerFunction(n) - 1));

            var firstMultiplier = BigInteger.Pow(id, exponent);
            var result = BigInteger.Remainder(firstMultiplier, n);

            return result;
        }

        private BigInteger GetR(int maxValue)
        {
            return GenerateRandomNumber(maxValue);
        }

        private BigInteger GetX(BigInteger r, BigInteger v, BigInteger n)
        {
            var firstMultiplier = BigInteger.Pow(r, (int)v);
            var result = BigInteger.Remainder(firstMultiplier, n);

            return result;
        }

        private BigInteger GetE(int maxValue)
        {
            return GenerateRandomNumber(maxValue);
        }

        private BigInteger GenerateRandomNumber(int maxValue)
        {
            // Задержка нужна чтобы предотвратить генерацию одинаковых значений
            Thread.Sleep(200);

            var random = new Random();
            var result = random.Next(1, maxValue + 1);

            return new BigInteger(result);
        }

        private BigInteger GenerateRandomIntegerNumber(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                throw new Exception("Min value is greater than max value");
            }

            var random = new Random();
            var result = random.Next(minValue, maxValue + 1);

            return new BigInteger(result);
        }

        private BigInteger GetY(BigInteger r, BigInteger sp, BigInteger e, BigInteger n)
        {
            var first = r * BigInteger.Pow(sp, (int)e);
            var result = BigInteger.Remainder(first, n);

            return result;
        }

        #endregion
    }
}
