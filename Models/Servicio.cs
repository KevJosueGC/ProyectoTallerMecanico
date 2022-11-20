using System.ComponentModel.DataAnnotations;

namespace ProyectoTallerMecanico.Models
{
    public class Servicio
    {
        [Key]
        public int IdServicio { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Estatus { get; set; }
        public List<DetalleOrden> DetalleOrdenes { get; set; }
        public List<DetalleCotizacion> DetalleCotizaciones { get; set; }
        public Categoria Categoria { get; set; }

    }
}