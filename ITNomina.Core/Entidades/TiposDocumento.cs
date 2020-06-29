using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class TiposDocumento
    {
        public int TipoDocumentoId { get; set; }
        public string TipoDocumento { get; set; }
        public string Alias { get; set; }
        public DateTime FchMod { get; set; }
    }
}
