using ITNomina.Core.Entidades;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITNomina.Infraestructura.Datos.Configuraciones
{
    public class CentrosCostoConfiguracion : IEntityTypeConfiguration<CentrosCosto>
    {
        public void Configure(EntityTypeBuilder<CentrosCosto> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
