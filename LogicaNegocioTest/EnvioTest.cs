using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;

namespace LogicaNegocioTest
{
    [TestClass]
    public class EnvioTest
    {
        [TestMethod]
        public void TestCalcularValorEnvioWithDistanciaCortaYEnvioPrioritario()
        {
            int precioEsperado = 32000;
            int precioLogicaNegocio = Envio.calcularValorEnvio(10, 50, true);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

        [TestMethod]
        public void TestCalcularValorEnvioWithDistanciaCortaYEnvioNormal()
        {
            int precioEsperado = 25000;
            int precioLogicaNegocio = Envio.calcularValorEnvio(10, 50, false);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

        [TestMethod]
        public void TestCalcularValorEnvioWithDistanciaMediaYEnvioPrioritario()
        {
            int precioEsperado = 50000;
            int precioLogicaNegocio = Envio.calcularValorEnvio(10,250, true);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }

        [TestMethod]
        public void TestCalcularValorEnvioWithDistanciaMediaYEnvioNormal()
        {
            int precioEsperado = 45000;
            int precioLogicaNegocio = Envio.calcularValorEnvio(10, 250, false);

            Assert.AreEqual(precioEsperado, precioLogicaNegocio);
        }
    }
}
