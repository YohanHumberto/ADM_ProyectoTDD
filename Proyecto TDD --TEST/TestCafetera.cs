using Proyecto_TDD____App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TDD___TEST
{
    [TestClass]
    public class TestCafetera
    {

        [TestMethod]
        public void deberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.hasCafe(5);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void deberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.hasCafe(11);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void deberiaRestarCafeALaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);

            cafetera.giveCafe(7);

            Assert.AreEqual(3, cafetera.getCantidadCafe());
        }

    }
}
