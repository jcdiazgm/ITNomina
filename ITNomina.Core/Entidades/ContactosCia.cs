using System;
using System.Collections.Generic;

namespace ITNomina.Core.Entidades
{
    public partial class ContactosCia
    {
        public ContactosCia()
        {
            Companias = new HashSet<Companias>();
        }

        public int ContactoId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefonos { get; set; }
        public string Correo { get; set; }
        public DateTime FchMod { get; set; }

        public virtual ICollection<Companias> Companias { get; set; }
    }
}
