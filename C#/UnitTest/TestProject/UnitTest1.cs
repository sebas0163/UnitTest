
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        
        [DataTestMethod]
        [DataRow(10,20,30)]
        [DataRow(10, 20, 50)]
        public void suma_test(int x, int y, int expected)
        {
            int result = Calculadora.suma(x,y);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(20, 20, 0)]
        [DataRow(10, 20, 50)]
        public void resta_test(int x, int y, int expected)
        {
            int result = Calculadora.resta(x, y);
            Assert.AreEqual(expected, result);
        }
        [DataTestMethod]
        [DataRow(20, 20, 1)]
        [DataRow(10, 20, 50)]
        public void division_test(int x, int y, int expected)
        {
            int result = Calculadora.division(x, y);
            Assert.AreEqual(expected, result);
        }
        [DataTestMethod]
        [DataRow(20, 20, 400)]
        [DataRow(10, 20, 50)]
        public void multiplicacion_test(int x, int y, int expected)
        {
            int result = Calculadora.multiplicacion(x, y);
            Assert.AreEqual(expected, result);
        }

    }
}
