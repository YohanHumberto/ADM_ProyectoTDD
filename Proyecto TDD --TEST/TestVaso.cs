using Proyecto_TDD____App;
using Xunit.Sdk;

namespace Proyecto_TDD___TEST
{
    [TestClass]
    public class TestVaso
    {
        [TestMethod]
        public void deberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasosPequeños = new Vaso(2, 10);

            bool resultado = vasosPequeños.hasVasos(1);

            Assert.AreEqual(true, resultado);
            
        }

        [TestMethod]
        public void deberiaDevolverFalsoSiNoExistenVasos()
        {
            Vaso vasosPequeños = new Vaso(1, 10);

            bool resultado = vasosPequeños.hasVasos(2);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void deberiaRestarCandtidadDeVaso()
        {
            Vaso vasosPequeños = new Vaso(5, 10);

            vasosPequeños.giveVasos(1);

            Assert.AreEqual(4, vasosPequeños.getCantidadDeVasos());
        }
    }
}