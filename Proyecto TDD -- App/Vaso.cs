using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TDD____App
{
    public class Vaso
    {
        private int CantidadDeVasos { get; set; }
        private int contenido { get; set; }

        public Vaso(int cantidadDeVasos, int contenido)
        {
            this.CantidadDeVasos = cantidadDeVasos;
            this.contenido = contenido;
        }

        public void setCantidadDeVasos(int param1)
        {
            CantidadDeVasos = param1;  
        }

        public int getCantidadDeVasos()
        {
           return this.CantidadDeVasos;
        }

        public void setContenido(int param1) {
            this.contenido = param1;
        }

        public int getContenido() {
            return this.contenido; 
        }

        public bool hasVasos(int cantidadDeVasos)
        {
            return cantidadDeVasos <= this.CantidadDeVasos;
        }

        public void giveVasos(int cantidadDeVasos)
        {
            this.CantidadDeVasos -= cantidadDeVasos;
        }


    }
}
