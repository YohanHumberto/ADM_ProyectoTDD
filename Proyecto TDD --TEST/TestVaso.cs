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
            Vaso vasosPeque�os = new Vaso(2, 10);

            bool resultado = vasosPeque�os.hasVasos(1);

            Assert.AreEqual(true, resultado);
            
        }

        [TestMethod]
        public void deberiaDevolverFalsoSiNoExistenVasos()
        {
            Vaso vasosPeque�os = new Vaso(1, 10);

            bool resultado = vasosPeque�os.hasVasos(2);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void deberiaRestarCandtidadDeVaso()
        {
            Vaso vasosPeque�os = new Vaso(5, 10);

            vasosPeque�os.giveVasos(1);

            Assert.AreEqual(4, vasosPeque�os.getCantidadDeVasos());
        }
    }
}