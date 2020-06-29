using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class Cargos
    {
        public int CargoId { get; set; }
        public string Nombre { get; set; }
        public int? CompaniaId { get; set; }
        public DateTime FchMod { get; set; }

        public virtual Companias Compania { get; set; }
    }
}
