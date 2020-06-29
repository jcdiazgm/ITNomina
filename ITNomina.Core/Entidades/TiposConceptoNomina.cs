using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class TiposConceptoNomina
    {
        public int TipoConceptoId { get; set; }
        public string TipoConcepto { get; set; }
        public DateTime FchMod { get; set; }
    }
}
