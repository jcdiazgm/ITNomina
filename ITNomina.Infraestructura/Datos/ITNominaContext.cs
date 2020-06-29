using ITNomina.Core.Entidades;
using ITNomina.Infraestructura.Datos.Configuraciones;

using Microsoft.EntityFrameworkCore;

namespace ITNomina.Infraestructura.Datos
{
    public partial class ITNominaContext : DbContext
    {
        public ITNominaContext()
        {
        }

        public ITNominaContext(DbContextOptions<ITNominaContext> options) : base(options)
        {
        }

        public virtual DbSet<Cargos> Cargos { get; set; }
        public virtual DbSet<CentrosCosto> CentrosCosto { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<Companias> Companias { get; set; }
        public virtual DbSet<ConceptosNomina> ConceptosNomina { get; set; }
        public virtual DbSet<ContactosCia> ContactosCia { get; set; }
        public virtual DbSet<EmpladosSalariales> EmpladosSalariales { get; set; }
        public virtual DbSet<EmpleadosBasicos> EmpleadosBasicos { get; set; }
        public virtual DbSet<EmpleadosFuncionales> EmpleadosFuncionales { get; set; }
        public virtual DbSet<EmpleadosPersonales> EmpleadosPersonales { get; set; }
        public virtual DbSet<Entidades> Entidades { get; set; }
        public virtual DbSet<FactoresNomina> FactoresNomina { get; set; }
        public virtual DbSet<NivelOcupacional> NivelOcupacional { get; set; }
        public virtual DbSet<Novedades> Novedades { get; set; }
        public virtual DbSet<ParametrosAplicacion> ParametrosAplicacion { get; set; }
        public virtual DbSet<Pruebas> Pruebas { get; set; }
        public virtual DbSet<Sexos> Sexos { get; set; }
        public virtual DbSet<TiposConceptoNomina> TiposConceptoNomina { get; set; }
        public virtual DbSet<TiposContrato> TiposContrato { get; set; }
        public virtual DbSet<TiposDetalle> TiposDetalle { get; set; }
        public virtual DbSet<TiposDocumento> TiposDocumento { get; set; }
        public virtual DbSet<TiposEntidad> TiposEntidad { get; set; }
        public virtual DbSet<TiposIndice> TiposIndice { get; set; }
        public virtual DbSet<TiposNomina> TiposNomina { get; set; }
        public virtual DbSet<TiposTurno> TiposTurno { get; set; }
        public virtual DbSet<Turnos> Turnos { get; set; }
        public virtual DbSet<TurnosEmpleado> TurnosEmpleado { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargos>(entity =>
            {
                entity.HasKey(e => e.CargoId);

                entity.Property(e => e.CargoId).HasColumnName("CargoID");

                entity.Property(e => e.CompaniaId).HasColumnName("CompaniaID");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Compania)
                    .WithMany(p => p.Cargos)
                    .HasForeignKey(d => d.CompaniaId)
                    .HasConstraintName("FK_Cargos_Companias");
            });

            modelBuilder.Entity<CentrosCosto>(entity =>
            {
                entity.HasKey(e => e.CentroCostoId);

                entity.Property(e => e.CentroCostoId).HasColumnName("CentroCostoID");

                entity.Property(e => e.CentroCosto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompaniaId).HasColumnName("CompaniaID");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => e.CiudadId);

                entity.Property(e => e.CiudadId).HasColumnName("CiudadID");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDane)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            // HACER ESTO MISMO CON CADA UNA DE LAS TABLAS:
            // 1. CREAR UNA CLASE LLAMADA NomTablaConfiguración
            // 2. HACER LA CLASE PÚBLICA Y QUE HEREDE DE  : IEntityTypeConfiguration<NomTabla>
            // 3. CORTAR TODO LO QUE SE ENCUENTRE DENTRO DE modelBuilder.Entity<ConceptosNomina>(entity => {}
            //    Y PEGARLO DENTRO DE LA IMPLEMENTACIÓN DE LA INTERFACE public void Configure(EntityTypeBuilder<NomTabla> builder)
            // 4. SUSTITUIR LA PALABRA entity. por builder.
            // 5. AQUÍ SE SUSTITUYE modelBuilder.Entity<ConceptosNomina>(entity => {} POR  modelBuilder.ApplyConfiguration(new NomTablaConfiguracion());
            modelBuilder.ApplyConfiguration(new CompaniaConfiguracion());

            modelBuilder.Entity<ConceptosNomina>(entity =>
            {
                entity.HasKey(e => new { e.ConceptoNominaId, e.TipoConceptoId });

                entity.Property(e => e.ConceptoNominaId)
                    .HasColumnName("ConceptoNominaID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TipoConceptoId).HasColumnName("TipoConceptoID");

                entity.Property(e => e.CompaniaId).HasColumnName("CompaniaID");

                entity.Property(e => e.ConceptoNomina)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Compania)
                    .WithMany(p => p.ConceptosNomina)
                    .HasForeignKey(d => d.CompaniaId)
                    .HasConstraintName("FK_ConceptosNomina_Companias");
            });

            modelBuilder.Entity<ContactosCia>(entity =>
            {
                entity.HasKey(e => e.ContactoId);

                entity.Property(e => e.ContactoId).HasColumnName("ContactoID");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefonos)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpladosSalariales>(entity =>
            {
                entity.HasKey(e => e.EmpleadoId);

                entity.ToTable("Emplados_Salariales");

                entity.Property(e => e.EmpleadoId)
                    .HasColumnName("EmpleadoID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FchIngreso).HasColumnType("date");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FchRetiro).HasColumnType("date");

                entity.Property(e => e.Salario).HasColumnType("money");

                entity.Property(e => e.ValorRodamiento).HasColumnType("money");

                entity.Property(e => e.ValorSubsidioTrans).HasColumnType("money");
            });

            modelBuilder.Entity<EmpleadosBasicos>(entity =>
            {
                entity.HasKey(e => e.EmpladoId);

                entity.ToTable("Empleados_Basicos");

                entity.Property(e => e.EmpladoId)
                    .HasColumnName("EmpladoID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Apellido2).HasMaxLength(25);

                entity.Property(e => e.Codigo).HasMaxLength(10);

                entity.Property(e => e.CompaniaId).HasColumnName("CompaniaID");

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre1)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre2).HasMaxLength(25);

                entity.Property(e => e.SexoId).HasColumnName("SexoID");

                entity.Property(e => e.TipoDocumentoId).HasColumnName("TipoDocumentoID");
            });

            modelBuilder.Entity<EmpleadosFuncionales>(entity =>
            {
                entity.HasKey(e => e.EmpleadoId);

                entity.ToTable("Empleados_Funcionales");

                entity.Property(e => e.EmpleadoId)
                    .HasColumnName("EmpleadoID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CargoId).HasColumnName("CargoID");

                entity.Property(e => e.CentroCostoId).HasColumnName("CentroCostoID");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NivelId).HasColumnName("NivelID");

                entity.Property(e => e.TipoContratoId).HasColumnName("TipoContratoID");

                entity.Property(e => e.TipoNominaId).HasColumnName("TipoNominaID");
            });

            modelBuilder.Entity<EmpleadosPersonales>(entity =>
            {
                entity.HasKey(e => e.EmpleadoId);

                entity.ToTable("Empleados_Personales");

                entity.Property(e => e.EmpleadoId)
                    .HasColumnName("EmpleadoID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DireccionResidencia)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FchNacimiento).HasColumnType("date");

                entity.Property(e => e.NaciCiudadId).HasColumnName("NaciCiudadID");

                entity.Property(e => e.NaciDeptoId).HasColumnName("NaciDeptoID");

                entity.Property(e => e.NaciPaisId).HasColumnName("NaciPaisID");

                entity.Property(e => e.TelefonosResidencia).HasMaxLength(25);
            });

            modelBuilder.Entity<Entidades>(entity =>
            {
                entity.HasKey(e => new { e.EntidadId, e.TipoEntidadId });

                entity.Property(e => e.EntidadId)
                    .HasColumnName("EntidadID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TipoEntidadId).HasColumnName("TipoEntidadID");

                entity.Property(e => e.CompaniaId).HasColumnName("CompaniaID");

                entity.Property(e => e.Entidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Compania)
                    .WithMany(p => p.Entidades)
                    .HasForeignKey(d => d.CompaniaId)
                    .HasConstraintName("FK_Entidades_Companias");
            });

            modelBuilder.Entity<FactoresNomina>(entity =>
            {
                entity.HasKey(e => e.CompaniaId);

                entity.Property(e => e.CompaniaId)
                    .HasColumnName("CompaniaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hediurnas)
                    .HasColumnName("HEDiurnas")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Hefdiurna)
                    .HasColumnName("HEFDiurna")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Hefnocturna)
                    .HasColumnName("HEFNocturna")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Henocturnas)
                    .HasColumnName("HENocturnas")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HfdiurnaCompensada)
                    .HasColumnName("HFDiurnaCompensada")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HfdiurnaNoCompensada)
                    .HasColumnName("HFDiurnaNoCompensada")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Hfnocturna)
                    .HasColumnName("HFNocturna")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PorcAfpempleador)
                    .HasColumnName("PorcAFPEmpleador")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PorcAfptrabajador)
                    .HasColumnName("PorcAFPTrabajador")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PorcArl)
                    .HasColumnName("PorcARL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PorcEpsempleador)
                    .HasColumnName("PorcEPSEmpleador")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PorcEpsincapacidad)
                    .HasColumnName("PorcEPSIncapacidad")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PorcEpstrabajador)
                    .HasColumnName("PorcEPSTrabajador")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PorcIntCesantias).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PorcPrima).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RecargoNocturno).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Smlv).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Subsidio).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Compania)
                    .WithOne(p => p.FactoresNomina)
                    .HasForeignKey<FactoresNomina>(d => d.CompaniaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FactoresNomina_Companias");
            });

            modelBuilder.Entity<NivelOcupacional>(entity =>
            {
                entity.HasKey(e => e.NivelId);

                entity.Property(e => e.NivelId).HasColumnName("NivelID");

                entity.Property(e => e.CompaniaId).HasColumnName("CompaniaID");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NivelOcupacional1)
                    .IsRequired()
                    .HasColumnName("NivelOcupacional")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Novedades>(entity =>
            {
                entity.HasKey(e => e.NovedadId);

                entity.Property(e => e.NovedadId).HasColumnName("NovedadID");

                entity.Property(e => e.CompaniaId)
                    .IsRequired()
                    .HasColumnName("CompaniaID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ConceptoNominaId).HasColumnName("ConceptoNominaID");

                entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");

                entity.Property(e => e.FchCompensatorio).HasColumnType("date");

                entity.Property(e => e.FchFin).HasColumnType("date");

                entity.Property(e => e.FchInicio).HasColumnType("date");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FchNovedad).HasColumnType("date");
            });

            modelBuilder.Entity<ParametrosAplicacion>(entity =>
            {
                entity.HasKey(e => e.CompaniaId);

                entity.Property(e => e.CompaniaId)
                    .HasColumnName("CompaniaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Gerente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GerenteGh)
                    .HasColumnName("GerenteGH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GerenteIt)
                    .HasColumnName("GerenteIT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Licencia).HasMaxLength(512);

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Representante)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RutaErrores).HasMaxLength(512);

                entity.Property(e => e.RutaFotos).HasMaxLength(512);

                entity.Property(e => e.RutaPlanos).HasMaxLength(512);
            });

            modelBuilder.Entity<Pruebas>(entity =>
            {
                entity.ToTable("pruebas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fchmod)
                    .IsRequired()
                    .HasColumnName("fchmod")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sexos>(entity =>
            {
                entity.HasKey(e => e.SexoId);

                entity.Property(e => e.SexoId).HasColumnName("SexoID");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposConceptoNomina>(entity =>
            {
                entity.HasKey(e => e.TipoConceptoId);

                entity.Property(e => e.TipoConceptoId).HasColumnName("TipoConceptoID");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoConcepto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposContrato>(entity =>
            {
                entity.HasKey(e => e.TipoContratoId);

                entity.Property(e => e.TipoContratoId).HasColumnName("TipoContratoID");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoContrato)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposDetalle>(entity =>
            {
                entity.HasKey(e => e.TipoDetId);

                entity.Property(e => e.TipoDetId).HasColumnName("TipoDetID");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoId).HasColumnName("TipoID");
            });

            modelBuilder.Entity<TiposDocumento>(entity =>
            {
                entity.HasKey(e => e.TipoDocumentoId);

                entity.Property(e => e.TipoDocumentoId).HasColumnName("TipoDocumentoID");

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposEntidad>(entity =>
            {
                entity.HasKey(e => e.TipoEntidadId);

                entity.Property(e => e.TipoEntidadId).HasColumnName("TipoEntidadID");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoEntidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposIndice>(entity =>
            {
                entity.HasKey(e => e.TipoId);

                entity.Property(e => e.TipoId).HasColumnName("TipoID");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tabla)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposNomina>(entity =>
            {
                entity.HasKey(e => e.TipoNominaId);

                entity.Property(e => e.TipoNominaId).HasColumnName("TipoNominaID");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoNomina)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposTurno>(entity =>
            {
                entity.HasKey(e => e.TipoTurnoId);

                entity.Property(e => e.TipoTurnoId).HasColumnName("TipoTurnoID");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoTurno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Turnos>(entity =>
            {
                entity.HasKey(e => new { e.TurnoId, e.TipoTurnoId });

                entity.Property(e => e.TurnoId)
                    .HasColumnName("TurnoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TipoTurnoId).HasColumnName("TipoTurnoID");

                entity.Property(e => e.CompaniaId).HasColumnName("CompaniaID");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Turno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Compania)
                    .WithMany(p => p.Turnos)
                    .HasForeignKey(d => d.CompaniaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Turnos_Companias");
            });

            modelBuilder.Entity<TurnosEmpleado>(entity =>
            {
                entity.HasKey(e => e.TurnoEmpleadoId);

                entity.Property(e => e.TurnoEmpleadoId).HasColumnName("TurnoEmpleadoID");

                entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");

                entity.Property(e => e.FchFin).HasColumnType("date");

                entity.Property(e => e.FchInicio).HasColumnType("date");

                entity.Property(e => e.FchMod)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoTurnoId).HasColumnName("TipoTurnoID");

                entity.Property(e => e.TurnoId).HasColumnName("TurnoID");

                entity.HasOne(d => d.TipoTurno)
                    .WithMany(p => p.TurnosEmpleado)
                    .HasForeignKey(d => d.TipoTurnoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TurnosEmpleado_TiposTurno");
            });
        }

    }   //*
}
