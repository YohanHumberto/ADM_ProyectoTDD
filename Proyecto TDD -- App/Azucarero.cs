using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TDD____App
{
    public class Azucarero
    {
        private int cantidadDeAzucar { get; set; }

        public Azucarero(int cantidadDeAzucar)
        {
            this.cantidadDeAzucar = cantidadDeAzucar;
        }

        public void setCantidadDeAzucar(int param1) {
        this.cantidadDeAzucar = param1;
        }

        public int getCantidadDeAzucar() {
            return cantidadDeAzucar; 
        }

        public bool hasAzucar(int param1) {
            return param1 <= cantidadDeAzucar;
        }

        public void giveAzucar(int param1) {
         this.cantidadDeAzucar -= param1;
        }

    }
}
