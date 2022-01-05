using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacionIII
{
    public class Nodo
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Nodo LigaIzquierda;
        public Nodo LigaDerecha;
        public Int32 Llave { get; set; }
        public Nodo Padre { get; set; }

        public Nodo()
        {
            LigaIzquierda = null;
            LigaDerecha = null;
            Llave = 0;
        }

        public Nodo(Int32 llave)
        {
            LigaIzquierda = null;
            LigaDerecha = null;
            Llave = llave;
        }


        public Nodo(int llave, int posx, int posy)
        {
            this.LigaIzquierda = null;
            this.LigaDerecha = null;
            this.Llave = llave;
            this.PosX = posx;
            this.PosY = posy;
        }

        public override string ToString()
        {
            return $"/{Llave}\\";
        }


    }
}
