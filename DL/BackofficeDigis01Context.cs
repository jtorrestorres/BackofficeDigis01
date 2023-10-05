using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DL;

public partial class BackofficeDigis01Context : DbContext
{
    public BackofficeDigis01Context()
    {
    }

    public BackofficeDigis01Context(DbContextOptions<BackofficeDigis01Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<Credencial> Credencials { get; set; }

    public virtual DbSet<CredencialHistorial> CredencialHistorials { get; set; }

    public virtual DbSet<CredencialPiso> CredencialPisos { get; set; }

    public virtual DbSet<Dispositivo> Dispositivos { get; set; }

    public virtual DbSet<Equipo> Equipos { get; set; }

    public virtual DbSet<Generacion> Generacions { get; set; }

    public virtual DbSet<HistorialEquipo> HistorialEquipos { get; set; }

    public virtual DbSet<HistorialEquipoPiso> HistorialEquipoPisos { get; set; }

    public virtual DbSet<HistorialHoja> HistorialHojas { get; set; }

    public virtual DbSet<HistorialMobiliario> HistorialMobiliarios { get; set; }

    public virtual DbSet<HistorialPaqueteHoja> HistorialPaqueteHojas { get; set; }

    public virtual DbSet<Hoja> Hojas { get; set; }

    public virtual DbSet<Incidencia> Incidencias { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Medicamento> Medicamentos { get; set; }

    public virtual DbSet<Membretado> Membretados { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<Mobiliario> Mobiliarios { get; set; }

    public virtual DbSet<Papelerium> Papeleria { get; set; }

    public virtual DbSet<Piso> Pisos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoHistorial> ProductoHistorials { get; set; }

    public virtual DbSet<ProductoPiso> ProductoPisos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Reposicion> Reposicions { get; set; }

    public virtual DbSet<SolicitudDespensa> SolicitudDespensas { get; set; }

    public virtual DbSet<SolicitudDespensaDetalle> SolicitudDespensaDetalles { get; set; }

    public virtual DbSet<SolicitudHoja> SolicitudHojas { get; set; }

    public virtual DbSet<SolicitudHojasDetalle> SolicitudHojasDetalles { get; set; }

    public virtual DbSet<SolicitudMedicamento> SolicitudMedicamentos { get; set; }

    public virtual DbSet<SolicitudMedicamentoDetalle> SolicitudMedicamentoDetalles { get; set; }

    public virtual DbSet<StatusCrendencial> StatusCrendencials { get; set; }

    public virtual DbSet<StatusPedido> StatusPedidos { get; set; }

    public virtual DbSet<Tipo> Tipos { get; set; }

    public virtual DbSet<TipoEquipo> TipoEquipos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioGeneracion> UsuarioGeneracions { get; set; }

    public virtual DbSet<UsuarioMedicamento> UsuarioMedicamentos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.; Database=BackofficeDigis01; TrustServerCertificate=True; Trusted_Connection=True; User ID=sa; Password=pass@word1;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.IdArea).HasName("PK__Area__2FC141AA4362C415");

            entity.ToTable("Area");

            entity.Property(e => e.IdArea).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Credencial>(entity =>
        {
            entity.HasKey(e => e.IdCredencial).HasName("PK__Credenci__E0A6C25984B0EDB6");

            entity.ToTable("Credencial");

            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.IdUsuarioQueAsigno).HasMaxLength(450);
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Credencials)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK__Credencia__IdSta__70DDC3D8");

            entity.HasOne(d => d.IdUsuarioQueAsignoNavigation).WithMany(p => p.Credencials)
                .HasForeignKey(d => d.IdUsuarioQueAsigno)
                .HasConstraintName("fk_UsuarioQueAsigno");
        });

        modelBuilder.Entity<CredencialHistorial>(entity =>
        {
            entity.HasKey(e => e.IdHistorial).HasName("PK__Credenci__9CC7DBB4E0B51DF6");

            entity.ToTable("Credencial_Historial");

            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");

            entity.HasOne(d => d.IdCredencialNavigation).WithMany(p => p.CredencialHistorials)
                .HasForeignKey(d => d.IdCredencial)
                .HasConstraintName("fk_CredencialHistorial");

            entity.HasOne(d => d.IdUsuarioAsignadoNavigation).WithMany(p => p.CredencialHistorials)
                .HasForeignKey(d => d.IdUsuarioAsignado)
                .HasConstraintName("fk_HistorialUsuarioAsignado");
        });

        modelBuilder.Entity<CredencialPiso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Credencial_Piso");

            entity.HasOne(d => d.IdCredencialNavigation).WithMany()
                .HasForeignKey(d => d.IdCredencial)
                .HasConstraintName("fk_CredencialPiso");

            entity.HasOne(d => d.IdPisoNavigation).WithMany()
                .HasForeignKey(d => d.IdPiso)
                .HasConstraintName("fk_PisoCredencial");
        });

        modelBuilder.Entity<Dispositivo>(entity =>
        {
            entity.HasKey(e => e.IdDispositivo).HasName("PK__Disposit__B1EDB8E449783F89");

            entity.ToTable("Dispositivo");

            entity.Property(e => e.Almacenamiento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Procesador)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ram)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RAM");
            entity.Property(e => e.SistemaOperativo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoAlmacenamiento)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoComputadora)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Dispositivos)
                .HasForeignKey(d => d.IdMarca)
                .HasConstraintName("FK__Dispositi__IdMar__01142BA1");
        });

        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.HasKey(e => e.IdEquipo).HasName("PK__Equipo__D805240882832F78");

            entity.ToTable("Equipo");

            entity.Property(e => e.Comentario)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CuentaUsuario)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.NumeroSerie)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.IdArea)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Equipo__IdArea__07C12930");

            entity.HasOne(d => d.IdDispositivoNavigation).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.IdDispositivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Equipo__IdDispos__05D8E0BE");

            entity.HasOne(d => d.IdPisoNavigation).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.IdPiso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Equipo__IdPiso__09A971A2");

            entity.HasOne(d => d.IdTipoEquipoNavigation).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.IdTipoEquipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Equipo__IdTipoEq__06CD04F7");

            entity.HasOne(d => d.IdUsuarioActualNavigation).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.IdUsuarioActual)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Equipo__IdUsuari__08B54D69");
        });

        modelBuilder.Entity<Generacion>(entity =>
        {
            entity.HasKey(e => e.IdGeneracion).HasName("PK__Generaci__527FB23DE8006048");

            entity.ToTable("Generacion");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaSalidaEstimada).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HistorialEquipo>(entity =>
        {
            entity.HasKey(e => e.IdHistorialEquipo).HasName("PK__Historia__DACF635B06F9B176");

            entity.ToTable("HistorialEquipo");

            entity.Property(e => e.Detalle)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("date");
            entity.Property(e => e.FechaRetiro).HasColumnType("date");

            entity.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.HistorialEquipos)
                .HasForeignKey(d => d.IdEquipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Historial__IdEqu__114A936A");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.HistorialEquipos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Historial__IdUsu__10566F31");
        });

        modelBuilder.Entity<HistorialEquipoPiso>(entity =>
        {
            entity.HasKey(e => e.IdHistorialEquipoPiso).HasName("PK__Historia__89177322B4B5ED87");

            entity.ToTable("HistorialEquipoPiso");

            entity.Property(e => e.Detalle)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaMovimiento).HasColumnType("datetime");

            entity.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.HistorialEquipoPisos)
                .HasForeignKey(d => d.IdEquipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Historial__IdEqu__0C85DE4D");

            entity.HasOne(d => d.IdPisoNavigation).WithMany(p => p.HistorialEquipoPisos)
                .HasForeignKey(d => d.IdPiso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Historial__IdPis__0D7A0286");
        });

        modelBuilder.Entity<HistorialHoja>(entity =>
        {
            entity.HasKey(e => e.IdHistorialHojas).HasName("PK__Historia__0B6B3F338B5BE519");

            entity.Property(e => e.IdHistorialHojas).ValueGeneratedOnAdd();
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.IdUsuario).HasMaxLength(450);
            entity.Property(e => e.Motivo)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.IdHojasNavigation).WithMany(p => p.HistorialHojas)
                .HasForeignKey(d => d.IdHojas)
                .HasConstraintName("FK__Historial__IdHoj__5E8A0973");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.HistorialHojas)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Historial__IdUsu__5D95E53A");
        });

        modelBuilder.Entity<HistorialMobiliario>(entity =>
        {
            entity.HasKey(e => e.IdHistorialMobiliario).HasName("PK__Historia__8200AAB8249378E3");

            entity.ToTable("HistorialMobiliario");

            entity.Property(e => e.IdHistorialMobiliario).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.HistorialMobiliarios)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Historial__IdPro__4A8310C6");

            entity.HasOne(d => d.IdProductoPisoNavigation).WithMany(p => p.HistorialMobiliarios)
                .HasForeignKey(d => d.IdProductoPiso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Historial__IdPro__498EEC8D");
        });

        modelBuilder.Entity<HistorialPaqueteHoja>(entity =>
        {
            entity.HasKey(e => e.IdHistorialPaqueteHojas).HasName("PK__Historia__0A17143682A54FE0");

            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.IdUsuario).HasMaxLength(450);

            entity.HasOne(d => d.IdPapeleriaNavigation).WithMany(p => p.HistorialPaqueteHojas)
                .HasForeignKey(d => d.IdPapeleria)
                .HasConstraintName("FK__Historial__IdPap__540C7B00");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.HistorialPaqueteHojas)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Historial__IdUsu__55009F39");
        });

        modelBuilder.Entity<Hoja>(entity =>
        {
            entity.HasKey(e => e.IdHojas).HasName("PK__Hojas__638B8077E9554377");

            entity.HasOne(d => d.IdMembretadoNavigation).WithMany(p => p.Hojas)
                .HasForeignKey(d => d.IdMembretado)
                .HasConstraintName("FK__Hojas__IdMembret__5AB9788F");

            entity.HasOne(d => d.IdPapeleriaNavigation).WithMany(p => p.Hojas)
                .HasForeignKey(d => d.IdPapeleria)
                .HasConstraintName("FK__Hojas__IdPapeler__59C55456");
        });

        modelBuilder.Entity<Incidencia>(entity =>
        {
            entity.HasKey(e => e.IdIncidencias).HasName("PK__Incidenc__BAFD768258365C90");

            entity.Property(e => e.Detalle)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaIncidencia).HasColumnType("date");

            entity.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.Incidencia)
                .HasForeignKey(d => d.IdEquipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Incidenci__IdEqu__14270015");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.IdMarca).HasName("PK__Marca__4076A887A66BC0F6");

            entity.ToTable("Marca");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Medicamento>(entity =>
        {
            entity.HasKey(e => e.IdMedicamento).HasName("PK__Medicame__AC96376E5965C916");

            entity.ToTable("Medicamento");

            entity.HasOne(d => d.IdProductoPisoNavigation).WithMany(p => p.Medicamentos)
                .HasForeignKey(d => d.IdProductoPiso)
                .HasConstraintName("FK__Medicamen__IdPro__2FCF1A8A");
        });

        modelBuilder.Entity<Membretado>(entity =>
        {
            entity.HasKey(e => e.IdMembretado).HasName("PK__Membreta__2929DEDDB3EC3C9B");

            entity.ToTable("Membretado");

            entity.Property(e => e.IdMembretado).ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.HasKey(e => e.IdMetodoPago).HasName("PK__MetodoPa__6F49A9BE2B5B8F26");

            entity.ToTable("MetodoPago");

            entity.Property(e => e.Metodo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Mobiliario>(entity =>
        {
            entity.HasKey(e => e.IdMobiliario).HasName("PK__Mobiliar__547F4CDFC711C4E1");

            entity.ToTable("Mobiliario");

            entity.Property(e => e.IdMobiliario).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdProductoPisoNavigation).WithMany(p => p.Mobiliarios)
                .HasForeignKey(d => d.IdProductoPiso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Mobiliari__IdPro__46B27FE2");
        });

        modelBuilder.Entity<Papelerium>(entity =>
        {
            entity.HasKey(e => e.IdPapeleria).HasName("PK__Papeleri__72DDB545C713A2B5");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.Papeleria)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__Papeleria__IdPro__503BEA1C");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Papeleria)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK__Papeleria__IdPro__51300E55");
        });

        modelBuilder.Entity<Piso>(entity =>
        {
            entity.HasKey(e => e.IdPiso).HasName("PK__Piso__F2823D8A906A00A8");

            entity.ToTable("Piso");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__09889210321DEF4F");

            entity.ToTable("Producto");

            entity.Property(e => e.IdProducto).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdUsuarioRegistro).HasMaxLength(450);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Producto__IdProv__2645B050");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Producto__IdTipo__25518C17");

            entity.HasOne(d => d.IdUsuarioRegistroNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdUsuarioRegistro)
                .HasConstraintName("FK__Producto__IdUsua__2739D489");
        });

        modelBuilder.Entity<ProductoHistorial>(entity =>
        {
            entity.HasKey(e => e.IdProductoHistorial).HasName("PK__Producto__54C154EC08FFA2A8");

            entity.ToTable("ProductoHistorial");

            entity.Property(e => e.FechaIngreso).HasColumnType("date");

            entity.HasOne(d => d.IdProductoPisoNavigation).WithMany(p => p.ProductoHistorials)
                .HasForeignKey(d => d.IdProductoPiso)
                .HasConstraintName("FK__ProductoH__IdPro__4D5F7D71");
        });

        modelBuilder.Entity<ProductoPiso>(entity =>
        {
            entity.HasKey(e => e.IdProductoPiso).HasName("PK__Producto__E182751F5C6ACC7A");

            entity.ToTable("ProductoPiso");

            entity.HasOne(d => d.IdPisoNavigation).WithMany(p => p.ProductoPisos)
                .HasForeignKey(d => d.IdPiso)
                .HasConstraintName("FK__ProductoP__IdPis__2B0A656D");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ProductoPisos)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__ProductoP__IdPro__2A164134");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK__Proveedo__E8B631AF774FA898");

            entity.ToTable("Proveedor");

            entity.Property(e => e.IdProveedor).ValueGeneratedOnAdd();
            entity.Property(e => e.Direccion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaginaWeb)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reposicion>(entity =>
        {
            entity.HasKey(e => e.IdReposicion).HasName("PK__Reposici__D08B30C3C781B05A");

            entity.ToTable("Reposicion");

            entity.Property(e => e.Costo).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.Motivo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.StatusReposicion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdCredencialNavigation).WithMany(p => p.Reposicions)
                .HasForeignKey(d => d.IdCredencial)
                .HasConstraintName("fk_CredencialReposicion");

            entity.HasOne(d => d.IdMetodoPagoNavigation).WithMany(p => p.Reposicions)
                .HasForeignKey(d => d.IdMetodoPago)
                .HasConstraintName("fk_MetodoPagoReposicion");

            entity.HasOne(d => d.IdUsuarioSolicitoNavigation).WithMany(p => p.Reposicions)
                .HasForeignKey(d => d.IdUsuarioSolicito)
                .HasConstraintName("fk_UsuarioSolicitoReposicion");
        });

        modelBuilder.Entity<SolicitudDespensa>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PK__Solicitu__9D335DC30A770054");

            entity.ToTable("SolicitudDespensa");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdUsuarioSolicito).HasMaxLength(450);

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.SolicitudDespensas)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK__Solicitud__IdSta__40058253");

            entity.HasOne(d => d.IdUsuarioSolicitoNavigation).WithMany(p => p.SolicitudDespensas)
                .HasForeignKey(d => d.IdUsuarioSolicito)
                .HasConstraintName("FK__Solicitud__IdUsu__3F115E1A");
        });

        modelBuilder.Entity<SolicitudDespensaDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("PK__Solicitu__E43646A5ADA6B31D");

            entity.ToTable("SolicitudDespensaDetalle");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.SolicitudDespensaDetalles)
                .HasForeignKey(d => d.IdPedido)
                .HasConstraintName("FK__Solicitud__IdPed__42E1EEFE");

            entity.HasOne(d => d.IdProductoPisoNavigation).WithMany(p => p.SolicitudDespensaDetalles)
                .HasForeignKey(d => d.IdProductoPiso)
                .HasConstraintName("FK__Solicitud__IdPro__43D61337");
        });

        modelBuilder.Entity<SolicitudHoja>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudHojasDetalle).HasName("PK__Solicitu__F4722C7CEC24FF04");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.IdHojasNavigation).WithMany(p => p.SolicitudHojas)
                .HasForeignKey(d => d.IdHojas)
                .HasConstraintName("FK__Solicitud__IdHoj__6DCC4D03");

            entity.HasOne(d => d.IdSolicitudHojasNavigation).WithMany(p => p.SolicitudHojas)
                .HasForeignKey(d => d.IdSolicitudHojas)
                .HasConstraintName("FK__Solicitud__IdSol__6CD828CA");
        });

        modelBuilder.Entity<SolicitudHojasDetalle>(entity =>
        {
            entity.HasKey(e => e.IdSolicitudHojas).HasName("PK__Solicitu__8BDD44E5094A376F");

            entity.ToTable("SolicitudHojasDetalle");

            entity.Property(e => e.IdUsuario).HasMaxLength(450);

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.SolicitudHojasDetalles)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK__Solicitud__IdSta__671F4F74");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.SolicitudHojasDetalles)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Solicitud__IdUsu__662B2B3B");
        });

        modelBuilder.Entity<SolicitudMedicamento>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PK__Solicitu__9D335DC3536CB0BF");

            entity.ToTable("SolicitudMedicamento");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdUsuarioSolicito).HasMaxLength(450);

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.SolicitudMedicamentos)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("FK__Solicitud__IdSta__3864608B");

            entity.HasOne(d => d.IdUsuarioSolicitoNavigation).WithMany(p => p.SolicitudMedicamentos)
                .HasForeignKey(d => d.IdUsuarioSolicito)
                .HasConstraintName("FK__Solicitud__IdUsu__37703C52");
        });

        modelBuilder.Entity<SolicitudMedicamentoDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("PK__Solicitu__E43646A5EF5DEE90");

            entity.ToTable("SolicitudMedicamentoDetalle");

            entity.HasOne(d => d.IdMedicamentoNavigation).WithMany(p => p.SolicitudMedicamentoDetalles)
                .HasForeignKey(d => d.IdMedicamento)
                .HasConstraintName("FK__Solicitud__IdMed__3C34F16F");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.SolicitudMedicamentoDetalles)
                .HasForeignKey(d => d.IdPedido)
                .HasConstraintName("FK__Solicitud__IdPed__3B40CD36");
        });

        modelBuilder.Entity<StatusCrendencial>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PK__StatusCr__B450643ACD1C9DAA");

            entity.ToTable("StatusCrendencial");

            entity.Property(e => e.TipoStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StatusPedido>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PK__StatusPe__B450643A9FC34D48");

            entity.ToTable("StatusPedido");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tipo>(entity =>
        {
            entity.HasKey(e => e.IdTipo).HasName("PK__Tipo__9E3A29A57E2CE119");

            entity.ToTable("Tipo");

            entity.Property(e => e.IdTipo).ValueGeneratedOnAdd();
            entity.Property(e => e.Tipo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo");
        });

        modelBuilder.Entity<TipoEquipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoEquipo).HasName("PK__TipoEqui__B62FEC6791C912A0");

            entity.ToTable("TipoEquipo");

            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF970E17CF5B");

            entity.ToTable("Usuario");

            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdArea)
                .HasConstraintName("FK__Usuario__IdArea__1273C1CD");
        });

        modelBuilder.Entity<UsuarioGeneracion>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioGeneracion).HasName("PK__UsuarioG__ADAF90DA4CEB0345");

            entity.ToTable("UsuarioGeneracion");

            entity.HasOne(d => d.IdGeneracionNavigation).WithMany(p => p.UsuarioGeneracions)
                .HasForeignKey(d => d.IdGeneracion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UsuarioGe__IdGen__6477ECF3");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioGeneracions)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UsuarioGe__IdUsu__6383C8BA");
        });

        modelBuilder.Entity<UsuarioMedicamento>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioMedicamento).HasName("PK__UsuarioM__C90074610F35A202");

            entity.ToTable("UsuarioMedicamento");

            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.IdUsuarioSuministro).HasMaxLength(450);
            entity.Property(e => e.Motivo)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.IdMedicamentoNavigation).WithMany(p => p.UsuarioMedicamentos)
                .HasForeignKey(d => d.IdMedicamento)
                .HasConstraintName("FK__UsuarioMe__IdMed__339FAB6E");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioMedicamentos)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__UsuarioMe__IdUsu__32AB8735");

            entity.HasOne(d => d.IdUsuarioSuministroNavigation).WithMany(p => p.UsuarioMedicamentos)
                .HasForeignKey(d => d.IdUsuarioSuministro)
                .HasConstraintName("FK__UsuarioMe__IdUsu__3493CFA7");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
