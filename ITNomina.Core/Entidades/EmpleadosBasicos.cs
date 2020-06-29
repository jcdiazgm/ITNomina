using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class EmpleadosBasicos
    {
        public int EmpladoId { get; set; }
        public string Codigo { get; set; }
        public int TipoDocumentoId { get; set; }
        public string Documento { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public int SexoId { get; set; }
        public int CompaniaId { get; set; }
        public bool Activo { get; set; }
        public DateTime FchMod { get; set; }
    }
}
