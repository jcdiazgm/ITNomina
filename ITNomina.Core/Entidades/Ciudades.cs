using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class Ciudades
    {
        public int CiudadId { get; set; }
        public string Ciudad { get; set; }
        public string CodigoDane { get; set; }
        public DateTime FchMod { get; set; }
    }
}
