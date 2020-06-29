using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class ParametrosAplicacion
    {
        public int CompaniaId { get; set; }
        public string Nit { get; set; }
        public string Gerente { get; set; }
        public string Representante { get; set; }
        public string GerenteIt { get; set; }
        public string GerenteGh { get; set; }
        public string Licencia { get; set; }
        public string RutaFotos { get; set; }
        public string RutaPlanos { get; set; }
        public string RutaErrores { get; set; }
        public DateTime FchMod { get; set; }

        public virtual Companias Companias { get; set; }
    }
}
