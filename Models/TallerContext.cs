using Microsoft.EntityFrameworkCore;

namespace ProyectoTallerMecanico.Models
{
    public class TallerContext : DbContext
    {
        public TallerContext(DbContextOptions<TallerContext> opciones)
        : base(opciones)
        {

        }

        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cotizacion> Cotizacion { get; set; }
        public DbSet<DetalleCotizacion> DetalleCotizacion { get; set; }
        public DbSet<DetalleOrden> DetalleOrden { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //RELACION DE MUCHOS A MUCHOS - MAESTRO DETALLE (ORDEN)
            modelBuilder.Entity<DetalleCotizacion>().HasKey(x => new{x.IdServicio, x.IdCotizacion});

            modelBuilder.Entity<DetalleCotizacion>().HasOne(x => x.Servicio)
            .WithMany(p => p.DetalleCotizaciones)
            .HasForeignKey(p => p.IdServicio);
            modelBuilder.Entity<DetalleCotizacion>().HasOne(x => x.Cotizacion)
            .WithMany(p => p.DetalleCotizaciones)
            .HasForeignKey(p => p.IdCotizacion);

            //RELACION DE MUCHOS A MUCHOS - MAESTRO DETALLE (COTIZACION)
            modelBuilder.Entity<DetalleOrden>().HasKey(x => new{x.IdServicio, x.IdOrden});

            modelBuilder.Entity<DetalleOrden>().HasOne(x => x.Servicio)
            .WithMany(p => p.DetalleOrdenes)
            .HasForeignKey(p => p.IdServicio);
            modelBuilder.Entity<DetalleOrden>().HasOne(x => x.Orden)
            .WithMany(p => p.DetalleOrdenes)
            .HasForeignKey(p => p.IdOrden);
            
        }        

    }
}