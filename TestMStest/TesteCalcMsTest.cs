using CalculadoraBET6;

namespace TesteMsTest
{
    [TestClass]
    public class TestCalcMsTest
    {
        [TestMethod]
        public void TesteSomarDoisNumeros()
        {
            //Arrange - Prepara��o
            double pNum = 1;
            double Snum = 1;
            double rNum = 2;

            //Act - A��o
            var resultado = Calculadora.Somar(pNum, Snum);

            //Assert - Verifica��o
            Assert.AreEqual(rNum, resultado);

        }

        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 5, 7)]
        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert
            Assert.AreEqual(rNum, resultado);

        }
    }
}