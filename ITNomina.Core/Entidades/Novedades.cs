using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class Novedades
    {
        public int NovedadId { get; set; }
        public string CompaniaId { get; set; }
        public int EmpleadoId { get; set; }
        public int ConceptoNominaId { get; set; }
        public DateTime FchNovedad { get; set; }
        public DateTime FchInicio { get; set; }
        public DateTime FchFin { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public DateTime FchCompensatorio { get; set; }
        public DateTime FchMod { get; set; }
    }
}
