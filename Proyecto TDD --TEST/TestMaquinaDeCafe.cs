using Proyecto_TDD____App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TDD___TEST
{
    [TestClass]
    public class TestMaquinaDeCafe
    {
        private Cafetera cafetera;
        private Vaso vasoPequeño;
        private Vaso vasoMediano;
        private Vaso vasoGrande;
        private Azucarero azucarero;
        private MaquinaDeCafe maquinaDeCafe;

        [TestInitialize]
        public void SetUp()
        {
            cafetera = new Cafetera(50);
            vasoPequeño = new Vaso(5, 10);
            vasoMediano = new Vaso(5, 20);
            vasoGrande = new Vaso(5, 30);
            azucarero = new Azucarero(20);

            maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasoPequeño(vasoPequeño);
            maquinaDeCafe.setVasosMediano(vasoMediano);
            maquinaDeCafe.setVasosGrande(vasoGrande);
            maquinaDeCafe.setAzucarero(azucarero);
        }

        [TestMethod]
        public void deberiaDevolverUnVasoPequeño()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso(TipoVaso.Pequeño);
            Assert.AreEqual(maquinaDeCafe.VasosPequeños, vaso);
        }

        [TestMethod]
        public void deberiaDevolverUnVasoMediano()
        {
            MaquinaDeCafe maquinaDeCafe = new MaquinaDeCafe();
            Vaso vaso = maquinaDeCafe.getTipoVaso(TipoVaso.Mediano);
            Assert.AreEqual(maquinaDeCafe.VasosMedianos, vaso);
        }

        [TestMethod]
        public void deberiaDevolverUnVasoGrande()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso(TipoVaso.Grande);
            Assert.AreEqual(maquinaDeCafe.VasosGrandes, vaso);
        }

        [TestMethod]
        public void deberiaDevolverNoHayVasos()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso(TipoVaso.Pequeño);

            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 10, 2);
            Assert.AreEqual("No hay Vasos", resultado);
        }

        [TestMethod]
        public void deberiaDevolverNoHayCafe()
        {
            cafetera = new Cafetera(5);
            maquinaDeCafe.setCafetera(cafetera);

            Vaso vaso = maquinaDeCafe.getTipoVaso(TipoVaso.Pequeño);

            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 2);
            Assert.AreEqual("No hay Cafe", resultado);
        }


        [TestMethod]
        public void deberiaDevolverNoHayAzucar()
        {
            azucarero = new Azucarero(2);
            maquinaDeCafe.setAzucarero(azucarero);

            Vaso vaso = maquinaDeCafe.getTipoVaso(TipoVaso.Pequeño);

            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("No hay Azucar", resultado);
        }

        [TestMethod]
        public void deberiaRestarCafe()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso(TipoVaso.Pequeño);

            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            int resultado = maquinaDeCafe.getCafetera().getCantidadCafe();
            Assert.AreEqual(40, resultado);
        }


        [TestMethod]
        public void deberiaRestarVaso()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso(TipoVaso.Pequeño);

            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            int resultado = maquinaDeCafe.getVasoPequeño().getCantidadDeVasos();
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void deberiaRestarAzucar()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso(TipoVaso.Pequeño);

            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            int resultado = maquinaDeCafe.getAzucarero().getCantidadDeAzucar();
            Assert.AreEqual(17, resultado);
        }

        [TestMethod]
        public void deberiaDevolverFelicitaciones()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso(TipoVaso.Pequeño);

            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            Assert.AreEqual("Felicitaciones", resultado);
        }
    }
}
