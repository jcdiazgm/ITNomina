using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class EmpladosSalariales
    {
        public int EmpleadoId { get; set; }
        public DateTime FchIngreso { get; set; }
        public DateTime? FchRetiro { get; set; }
        public decimal Salario { get; set; }
        public bool SubsidioTransporte { get; set; }
        public decimal? ValorSubsidioTrans { get; set; }
        public decimal? ValorRodamiento { get; set; }
        public DateTime FchMod { get; set; }
    }
}
