using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class TiposDetalle
    {
        public int TipoDetId { get; set; }
        public int TipoId { get; set; }
        public string Descripcion { get; set; }
        public string Alias { get; set; }
        public DateTime FchMod { get; set; }
    }
}
