namespace ProyectoTallerMecanico.Models
{
    public class DetalleCotizacion
    {
        public int IdServicio { get; set; }
        public int IdCotizacion { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public float Subtotal { get; set; }
        public int Estatus { get; set; }
        public Servicio Servicio { get; set; }
        public Cotizacion Cotizacion { get; set; }
    }
}