using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class EmpleadosFuncionales
    {
        public int EmpleadoId { get; set; }
        public int? TipoContratoId { get; set; }
        public int? TipoNominaId { get; set; }
        public int? CentroCostoId { get; set; }
        public int? NivelId { get; set; }
        public int? CargoId { get; set; }
        public DateTime? FchMod { get; set; }
    }
}
