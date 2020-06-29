using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class FactoresNomina
    {
        public int CompaniaId { get; set; }
        public decimal Smlv { get; set; }
        public decimal Subsidio { get; set; }
        public int HorasMes { get; set; }
        public decimal PorcPrima { get; set; }
        public decimal PorcIntCesantias { get; set; }
        public decimal PorcEpsempleador { get; set; }
        public decimal PorcEpstrabajador { get; set; }
        public decimal PorcAfpempleador { get; set; }
        public decimal PorcAfptrabajador { get; set; }
        public decimal PorcEpsincapacidad { get; set; }
        public int DiasIncapEmpresa { get; set; }
        public decimal PorcArl { get; set; }
        public decimal Hediurnas { get; set; }
        public decimal Henocturnas { get; set; }
        public decimal Hefdiurna { get; set; }
        public decimal Hefnocturna { get; set; }
        public decimal HfdiurnaCompensada { get; set; }
        public decimal HfdiurnaNoCompensada { get; set; }
        public decimal Hfnocturna { get; set; }
        public decimal RecargoNocturno { get; set; }
        public DateTime FchMod { get; set; }

        public virtual Companias Compania { get; set; }
    }
}
