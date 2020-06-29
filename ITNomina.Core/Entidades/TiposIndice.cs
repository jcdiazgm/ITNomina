using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class TiposIndice
    {
        public int TipoId { get; set; }
        public string Tabla { get; set; }
        public DateTime FchMod { get; set; }
    }
}
