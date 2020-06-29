using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class TiposTurno
    {
        public TiposTurno()
        {
            TurnosEmpleado = new HashSet<TurnosEmpleado>();
        }

        public int TipoTurnoId { get; set; }
        public string TipoTurno { get; set; }
        public DateTime FchMod { get; set; }

        public virtual ICollection<TurnosEmpleado> TurnosEmpleado { get; set; }
    }
}
