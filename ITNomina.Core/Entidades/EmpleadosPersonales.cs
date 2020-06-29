using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class EmpleadosPersonales
    {
        public int EmpleadoId { get; set; }
        public DateTime FchNacimiento { get; set; }
        public int NaciPaisId { get; set; }
        public int NaciDeptoId { get; set; }
        public int NaciCiudadId { get; set; }
        public string DireccionResidencia { get; set; }
        public string TelefonosResidencia { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public DateTime FchMod { get; set; }
    }
}
