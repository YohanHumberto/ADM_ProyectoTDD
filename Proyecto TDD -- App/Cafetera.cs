using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TDD____App
{
    public class Cafetera
    {
        private int cantidadCafe { get; set; }

        public Cafetera(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
        }

        public void setCantidadCafe(int param1)
        {
            this.cantidadCafe = param1;
        }

        public int getCantidadCafe()
        {
            return this.cantidadCafe;
        }

        public bool hasCafe(int cantidadCafe)
        {
            return cantidadCafe <= this.cantidadCafe;
        }

        public void giveCafe(int cantidadCafe)
        {
            this.cantidadCafe -= cantidadCafe;
        }
    }
}
