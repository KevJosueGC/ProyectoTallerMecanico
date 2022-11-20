using System.ComponentModel.DataAnnotations;

namespace ProyectoTallerMecanico.Models
{
    public class Agenda
    {
        [Key]
        public int IdAgenda { get; set; }
        public int IdOrden { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int Estatus { get; set; }
        public Orden Orden { get; set; }
    }
}