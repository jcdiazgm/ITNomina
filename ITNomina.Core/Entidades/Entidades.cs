using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class Entidades
    {
        public int EntidadId { get; set; }
        public int TipoEntidadId { get; set; }
        public string Entidad { get; set; }
        public int? CompaniaId { get; set; }
        public DateTime FchMod { get; set; }

        public virtual Companias Compania { get; set; }
    }
}
