using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class TurnosEmpleado
    {
        public int TurnoEmpleadoId { get; set; }
        public int TurnoId { get; set; }
        public int EmpleadoId { get; set; }
        public int TipoTurnoId { get; set; }
        public DateTime FchInicio { get; set; }
        public DateTime FchFin { get; set; }
        public DateTime FchMod { get; set; }

        public virtual TiposTurno TipoTurno { get; set; }
    }
}
