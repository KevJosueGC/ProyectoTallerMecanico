using System.ComponentModel.DataAnnotations;

namespace ProyectoTallerMecanico.Models
{
    public class Cotizacion
    {
        [Key]
        public int IdCotizacion { get; set; }
        public int NombreCliente { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaIngreso  { get; set; }
        public float Total { get; set; }
        public List<DetalleCotizacion> DetalleCotizaciones { get; set; }
        
    }
}