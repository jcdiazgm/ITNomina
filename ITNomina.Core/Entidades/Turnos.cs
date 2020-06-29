using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class Turnos
    {
        public int TurnoId { get; set; }
        public int TipoTurnoId { get; set; }
        public string Turno { get; set; }
        public int Duracion { get; set; }
        public int DiasSemana { get; set; }
        public TimeSpan HoraIni { get; set; }
        public TimeSpan HoraFin { get; set; }
        public TimeSpan? HoraIniAlmuerzo { get; set; }
        public TimeSpan? HoraFinAlmuerzo { get; set; }
        public bool Activo { get; set; }
        public int MinutosAlmuerzo { get; set; }
        public int MinutosDescanso { get; set; }
        public int CompaniaId { get; set; }
        public DateTime FchMod { get; set; }

        public virtual Companias Compania { get; set; }
    }
}
