using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class Companias
    {
        public Companias()
        {
            Cargos = new HashSet<Cargos>();
            ConceptosNomina = new HashSet<ConceptosNomina>();
            Entidades = new HashSet<Entidades>();
            Turnos = new HashSet<Turnos>();
        }

        public int CompaniaId { get; set; }
        public string Nombre { get; set; }
        public int TipoDocumentoId { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
        public int? ContactoId { get; set; }
        public DateTime FchMod { get; set; }

        public virtual ParametrosAplicacion Compania { get; set; }
        public virtual ContactosCia Contacto { get; set; }
        public virtual FactoresNomina FactoresNomina { get; set; }
        public virtual ICollection<Cargos> Cargos { get; set; }
        public virtual ICollection<ConceptosNomina> ConceptosNomina { get; set; }
        public virtual ICollection<Entidades> Entidades { get; set; }
        public virtual ICollection<Turnos> Turnos { get; set; }
    }
}
