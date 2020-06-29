using System;
using System.Collections.Generic;
using System.Text;

namespace ITNomina.Core.DTOs
{
    public class CompaniaDto
    {
        public int CompaniaId { get; set; }
        public string Nombre { get; set; }
        public int TipoDocumentoId { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
        public int? ContactoId { get; set; }
        public DateTime FchMod { get; set; }

    }   //*
}
