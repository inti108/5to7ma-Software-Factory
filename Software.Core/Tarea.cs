using System;

namespace Software.Core
{
    public class Tarea
    {
        public int idRequerimiento { get; set; }

        public Empleado Empleado { get; set; }

        public string Inicio { get; set; }

        public string Fin { get; set; }
    }
}
