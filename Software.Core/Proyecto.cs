using System;

namespace Software.Core
{
    public class Proyecto
    {
        public short idProyecto { get; set; }

        public Cliente Cliente { get; set; }

        public string Descripcion { get; set; }

        public int Presupuesto { get; set; }

        public double Inicio { get; set; }

        public double Fin { get; set; }
    }
}
