
using ClassesLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace M2S6Exercicios
{
    [TestClass]
    public class TestesExercicios
    {

        private Calculadora c = new();
        public void TesteOverflow()
        {

            c.Memoria1 = 99;
            c.Memoria2 = 2;
        }
        [TestMethod]
        public void TestaOverflow()
        {

            var deuerro = false;

            try
            {
                var e = c.Somar().ToString();
            }
            catch (Exception ex)
            {
                deuerro = ex.Message.Contains("overflow");
            }
            Assert.IsTrue(deuerro);
        }
    }
}