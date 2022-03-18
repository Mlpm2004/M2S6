using ClassesLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestExercicios
{

    [TestClass]
 
    public class TestedeOperacoes
    {
        private bool erro = false;
        private Calculadora c = new();
        [TestMethod]
        public void TestaSoma()
        {
            c.Memoria1 = 100;
            c.Memoria2 = 1;
            if (c.Resultado("+")=="overflow") erro = true; ;
            Assert.IsTrue(erro);

        }
        [TestMethod]
        public void TestaMultiplicacao()
        {
            c.Memoria1 = 100;
            c.Memoria2 = 2;
            if (c.Resultado("*") == "overflow") erro = true; ;
            Assert.IsTrue(erro);

        }
        [TestMethod]
        public void TestaDivisao()
        {
            c.Memoria1 = 100;
            c.Memoria2 = 0;
            if (c.Resultado("/") == "Divis�o por zero") erro = true; ;
            Assert.IsTrue(erro);

        }
        [TestMethod]
        public void TestaSubtra��o()
        {
            c.Memoria1 = -100;
            c.Memoria2 = 1;
            if (c.Resultado("-") == "underflow") erro = true; ;
            Assert.IsTrue(erro);

        }
    }
}