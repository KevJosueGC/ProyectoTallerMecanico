using System.ComponentModel.DataAnnotations;

namespace ProyectoTallerMecanico.Models
{
    public class Orden
    {
        [Key]
        public int IdOrden { get; set; }
        public int IdEmpleado { get; set; }
        public int NumeroPlaca { get; set; }
        public int Estatus { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public Empleado Empleado { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public List<DetalleOrden> DetalleOrdenes { get; set; }
        public List<Agenda> Agendas { get; set; }

    }
}