using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Collections.Generic;
using System.Numerics;
using Assert = NUnit.Framework.Assert;

namespace GilluKiskatra.Tests
{
    [TestFixture]
    public class GilluKiskatraTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCaseSource(nameof(MainTestCase))]
        public void Main_Test(BigInteger p, BigInteger q, BigInteger v, BigInteger id, BigInteger r, BigInteger e,
            GilluKiskatra expectedObject,
            bool expected)
        {
            var crypto = new GilluKiskatra(p, q, v, id, r, e);

            Assert.AreEqual(expectedObject.P, crypto.P);
            Assert.AreEqual(expectedObject.Q, crypto.Q);
            Assert.AreEqual(expectedObject.N, crypto.N);
            Assert.AreEqual(expectedObject.V, crypto.V);
            Assert.AreEqual(expectedObject.Fn, crypto.Fn);
            Assert.AreEqual(expectedObject.S, crypto.S);
            Assert.AreEqual(expectedObject.Id, crypto.Id);
            Assert.AreEqual(expectedObject.Sp, crypto.Sp);
            Assert.AreEqual(expectedObject.R, crypto.R);
            Assert.AreEqual(expectedObject.X, crypto.X);
            Assert.AreEqual(expectedObject.E, crypto.E);
            Assert.AreEqual(expectedObject.Y, crypto.Y);
            Assert.AreEqual(expected, crypto.GetResult());
        }

        [Test]
        [TestCaseSource(nameof(GetNTestCases))]
        public void GetN_Test(BigInteger p, BigInteger q, BigInteger expectedValue)
        {
            var crypto = new GilluKiskatra();
            var privateObject = new PrivateObject(crypto);

            var result = privateObject.Invoke("GetN", p, q);
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCaseSource(nameof(EilerFunctionTestCases))]
        public void EilerFunction_Test(BigInteger n, BigInteger expectedValue)
        {
            var crypto = new GilluKiskatra();
            var privateObject = new PrivateObject(crypto);

            var result = privateObject.Invoke("EilerFunction", n);
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCaseSource(nameof(GetGCDTestCases))]
        public void GetGCD_Test(BigInteger i, BigInteger j, BigInteger expectedValue)
        {
            var crypto = new GilluKiskatra();
            var privateObject = new PrivateObject(crypto);

            var result = privateObject.Invoke("GetGCD", i, j);
            Assert.AreEqual(expectedValue, result);
        }

        #region Test cases

        private static IEnumerable<TestCaseData> MainTestCase()
        {
            // Данные из методички
            //yield return new TestCaseData(
            //    new BigInteger(11),
            //    new BigInteger(13),
            //    new BigInteger(37),
            //    new BigInteger(29),
            //    new BigInteger(21),
            //    new BigInteger(17),
            //    new GilluKiskatra()
            //    {
            //        P = 11,
            //        Q = 13,
            //        N = 143,
            //        V = 37,
            //        Fn = 120,
            //        S = 13,
            //        Id = 29,
            //        Sp = 61,
            //        R = 21,
            //        X = 21,
            //        E = 17,
            //        Y = 102
            //    },
            //    true);

            yield return new TestCaseData(
                new BigInteger(7),
                new BigInteger(13),
                new BigInteger(5),
                new BigInteger(65),
                new BigInteger(85),
                new BigInteger(1),
                new GilluKiskatra()
                {
                    P = 7,
                    Q = 13,
                    N = 91,
                    V = 5,
                    Fn = 72,
                    S = 29,
                    Id = 65,
                    Sp = 65,
                    R = 85,
                    X = 50,
                    E = 1,
                    Y = 65
                },
                true);
        }

        private static IEnumerable<TestCaseData> GetNTestCases()
        {
            yield return new TestCaseData(new BigInteger(10), new BigInteger(10), new BigInteger(100));
            yield return new TestCaseData(new BigInteger(20), new BigInteger(20), new BigInteger(400));
            yield return new TestCaseData(new BigInteger(30), new BigInteger(30), new BigInteger(900));
            yield return new TestCaseData(new BigInteger(11), new BigInteger(11), new BigInteger(121));
            yield return new TestCaseData(new BigInteger(50), new BigInteger(30), new BigInteger(1500));
        }

        private static IEnumerable<TestCaseData> EilerFunctionTestCases()
        {
            yield return new TestCaseData(new BigInteger(20), new BigInteger(8));
            yield return new TestCaseData(new BigInteger(143), new BigInteger(120));
            yield return new TestCaseData(new BigInteger(120), new BigInteger(32));
            yield return new TestCaseData(new BigInteger(458), new BigInteger(228));
            yield return new TestCaseData(new BigInteger(145), new BigInteger(112));
        }

        private static IEnumerable<TestCaseData> GetGCDTestCases()
        {
            yield return new TestCaseData(new BigInteger(17), new BigInteger(11), new BigInteger(1));
            yield return new TestCaseData(new BigInteger(35), new BigInteger(48), new BigInteger(1));
            yield return new TestCaseData(new BigInteger(4), new BigInteger(24), new BigInteger(4));
            yield return new TestCaseData(new BigInteger(418), new BigInteger(2488), new BigInteger(2));
            yield return new TestCaseData(new BigInteger(4180), new BigInteger(2488), new BigInteger(4));
        }

        #endregion
    }
}
