using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class NivelOcupacional
    {
        public int NivelId { get; set; }
        public string NivelOcupacional1 { get; set; }
        public int? CompaniaId { get; set; }
        public DateTime FchMod { get; set; }
    }
}
