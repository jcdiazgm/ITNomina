using ITNomina.Core.Entidades;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITNomina.Infraestructura.Datos.Configuraciones
{
    public class CargoConfiguracion : IEntityTypeConfiguration<Cargos>
    {
        public void Configure(EntityTypeBuilder<Cargos> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
