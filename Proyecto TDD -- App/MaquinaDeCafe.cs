using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TDD____App
{
    public enum TipoVaso
    {
        Pequeño,
        Mediano,
        Grande
    }

    public class MaquinaDeCafe
    {
        public Cafetera Cafetera { get; set; }
        public Vaso VasosPequeños { get; set; }
        public Vaso VasosMedianos { get; set; }
        public Vaso VasosGrandes { get; set; }
        public Azucarero Azucar { get; set; }

        public Vaso getTipoVaso(TipoVaso tipoDeVaso)
        {
            switch (tipoDeVaso)
            {
                case TipoVaso.Pequeño:
                    return VasosPequeños;
                case TipoVaso.Mediano:
                    return VasosMedianos;
                case TipoVaso.Grande:
                    return VasosGrandes;
                default: return null;
            }
        }

        public string getVasoDeCafe(Vaso TipoDeVaso, int cantidadDeVasos, int cantidadDeAzucar)
        {
            if (TipoDeVaso.getCantidadDeVasos() < cantidadDeVasos) return "No hay Vasos";
            if (TipoDeVaso.getContenido() > this.Cafetera.getCantidadCafe()) return "No hay Cafe";
            if (cantidadDeAzucar > this.Azucar.getCantidadDeAzucar()) return "No hay Azucar";

            this.Cafetera.setCantidadCafe(this.Cafetera.getCantidadCafe() - TipoDeVaso.getContenido());

            if (TipoDeVaso.getContenido() == 10) VasosPequeños.setCantidadDeVasos(VasosPequeños.getCantidadDeVasos() - cantidadDeVasos);
            if (TipoDeVaso.getContenido() == 20) VasosMedianos.setCantidadDeVasos(VasosMedianos.getCantidadDeVasos() - cantidadDeVasos);
            if (TipoDeVaso.getContenido() == 30) VasosGrandes.setCantidadDeVasos(VasosGrandes.getCantidadDeVasos() - cantidadDeVasos);

            this.Azucar.setCantidadDeAzucar(this.Azucar.getCantidadDeAzucar() - (cantidadDeAzucar * cantidadDeVasos));

            return "Felicitaciones";
        }

        public void setCafetera(Cafetera value) => this.Cafetera = value;
        public void setVasoPequeño(Vaso value) => this.VasosPequeños = value;
        public void setVasosMediano(Vaso value) => this.VasosMedianos = value;
        public void setVasosGrande(Vaso value) => this.VasosGrandes = value;
        public void setAzucarero(Azucarero value) => this.Azucar = value;

        public Cafetera getCafetera() => this.Cafetera;
        public Vaso getVasoPequeño() => this.VasosPequeños;
        public Vaso getVasosMediano() => this.VasosMedianos;
        public Vaso getVasosGrande() => this.VasosGrandes;
        public Azucarero getAzucarero() => this.Azucar;

    }
}
