using ITNomina.Core.Entidades;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITNomina.Infraestructura.Datos.Configuraciones
{
    public class CompaniaConfiguracion : IEntityTypeConfiguration<Companias>
    {
        public void Configure(EntityTypeBuilder<Companias> builder)
        {
            builder.HasKey(e => e.CompaniaId);

            builder.Property(e => e.CompaniaId)
                .HasColumnName("CompaniaID")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.ContactoId).HasColumnName("ContactoID");

            builder.Property(e => e.Direccion)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.Documento)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.FchMod)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Telefonos)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.TipoDocumentoId).HasColumnName("TipoDocumentoID");

            builder.HasOne(d => d.Compania)
                .WithOne(p => p.Companias)
                .HasForeignKey<Companias>(d => d.CompaniaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Companias_ParametrosAplicacion");

            builder.HasOne(d => d.Contacto)
                .WithMany(p => p.Companias)
                .HasForeignKey(d => d.ContactoId)
                .HasConstraintName("FK_Companias_ContactosCia");
        }
    }   //*
}
