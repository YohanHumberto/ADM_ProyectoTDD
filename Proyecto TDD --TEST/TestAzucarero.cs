using Proyecto_TDD____App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Proyecto_TDD___TEST
{
    [TestClass]
    public class TestAzucarero
    {

        private Azucarero azucarero;

        [TestInitialize]
        public void setUp() => azucarero = new Azucarero(10);

        [TestMethod]
        public void deberiaDevolverVerdaderoSiHaySuficienteAzucarEnElAzucarero()
        {
           
            bool resultado = this.azucarero.hasAzucar(5);

            Assert.AreEqual(true, resultado);

            resultado = this.azucarero.hasAzucar(10);
            Assert.AreEqual(true, resultado);   
        }

        [TestMethod]
        public void deberiaDevolverFalsoPorqueNoHaySuficienteAzucarEnElAzucarero()
        {
            bool resultado = azucarero.hasAzucar(15);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void deberiaRestarAzucarAlAzucarero()
        {
            azucarero.giveAzucar(5);

            Assert.AreEqual(5, azucarero.getCantidadDeAzucar());
            
            azucarero.giveAzucar(2);

            Assert.AreEqual(3, azucarero.getCantidadDeAzucar());
        }

    }
}