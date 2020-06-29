using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class CentrosCosto
    {
        public int CentroCostoId { get; set; }
        public string CentroCosto { get; set; }
        public int? CompaniaId { get; set; }
        public DateTime FchMod { get; set; }
    }
}
