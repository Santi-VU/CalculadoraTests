using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit.Sdk;

namespace Calculadora.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            var s = Suma.Sumar(1, 2);
            Assert.AreEqual(3, s);
        }

        [TestMethod]
        public void TestSumaFail()
        {
            var s = Suma.Sumar(5, 2);
            Assert.AreNotEqual(4, s);
        }

        [TestMethod]
        public void TestSumaNegative()
        {
            //Assert.ThrowsException<InvalidOperationException>(() => Assert.AreEqual(-1, s));
            try
            {
                var s = Suma.Sumar(-1.5m, 2);
                Assert.AreEqual(-1, s);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is InvalidOperationException);
            }
        }

        [TestMethod]
        public void TestDividir()
        {
            var s = Division.Dividir(10, 2);
            Assert.AreEqual(5, s);
        }

        [TestMethod]
        public void TestDividirFail()
        {
            var s = Division.Dividir(10, 2);
            Assert.AreNotEqual(6, s);
        }

        [TestMethod]
        public void TestDividendIsZero()
        {
            try
            {
                var s = Division.Dividir(10, 0);
                Assert.AreEqual(-1, s);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is DivideByZeroException);
            }
        }

        [TestMethod]
        public void TestDividirNegative()
        {
            try
            {
                var s = Division.Dividir(-10, 2);
                Assert.AreEqual(-5, s);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is InvalidOperationException);
            }
        }

        [TestMethod]
        public void TestDividirArray()
        {
            var s = Division.DividirConResto(10, 2);
            Console.WriteLine(s[0]);
            decimal[] d = new decimal[2] { 5, 0 };
            Assert.AreEqual(d[0], s[0]);
            Assert.AreEqual(d[1], s[1]);
        }

        [TestMethod]
        public void TestDividirArrayFail()
        {
            var s = Division.DividirConResto(10, 2);
            Console.WriteLine(s[0]);
            decimal[] d = new decimal[2] { 6, 1 };
            Assert.AreNotEqual(d[0], s[0]);
            Assert.AreNotEqual(d[1], s[1]);
        }

        [TestMethod]
        public void TestDividendIsZeroArray()
        {
            try
            {
                var s = Division.DividirConResto(10, 0); 
                Assert.AreEqual(-1, s);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is DivideByZeroException);
            }
        }

        [TestMethod]
        public void TestDividirNegativeArray()
        {
            try
            {
                var s = Division.DividirConResto(-10, 2);
                Assert.AreEqual(-5, s);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is InvalidOperationException);
            }
        }

        [TestMethod]
        public void TestResta()
        {
            var s = Resta.Restar(5, 2);
            Assert.AreEqual(3, s);
        }

        [TestMethod]
        public void TestRestaFail()
        {
            var s = Resta.Restar(5, 2);
            Assert.AreNotEqual(2, s);
        }

        [TestMethod]
        public void TestRestaNegative()
        {
            try
            {
                var s = Resta.Restar(5, -1.5m);
                Assert.AreEqual(6.5m, s);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is InvalidOperationException);
            }
        }

        [TestMethod]
        public void TestRestaSecondNumber()
        {
            try
            {
                var s = Resta.Restar(5, 10);
                Assert.AreEqual(5, s);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is InvalidOperationException);
            }
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            var s = Multiplicacion.Multiplicar(5, 2);
            Assert.AreEqual(10, s);
        }

        [TestMethod]
        public void TestMultiplicacionFail()
        {
            var s = Multiplicacion.Multiplicar(5, 2);
            Assert.AreNotEqual(8, s);
        }

        [TestMethod]
        public void TestMultiplicacionNegative()
        {
            try
            {
                var s = Multiplicacion.Multiplicar(5, -2);
                Assert.AreEqual(-10, s);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is InvalidOperationException);
            }
        }

        [TestMethod]
        public void TestMultiplicacionZeros()
        {
            try
            {
                var s = Multiplicacion.Multiplicar(5, 0);
                Assert.AreEqual(0, s);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is InvalidOperationException);
            }
        }
    }
}
