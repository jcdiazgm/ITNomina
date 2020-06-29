using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class Sexos
    {
        public int SexoId { get; set; }
        public string Sexo { get; set; }
        public string Alias { get; set; }
        public DateTime FchMod { get; set; }
    }
}
