using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class ConceptosNomina
    {
        public int ConceptoNominaId { get; set; }
        public int TipoConceptoId { get; set; }
        public string ConceptoNomina { get; set; }
        public bool EsDescontable { get; set; }
        public int? CompaniaId { get; set; }
        public DateTime FchMod { get; set; }

        public virtual Companias Compania { get; set; }
    }
}
