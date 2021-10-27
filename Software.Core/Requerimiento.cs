using System;

namespace Software.Core
{
    public class Requerimiento
    {
        public int idRequerimiento { get; set; }

        public short idProyecto { get; set; }

        public string idTecnologia { get; set; }

        public string Descripcion { get; set; }

        public string Complejidad { get; set; }
    }
}
