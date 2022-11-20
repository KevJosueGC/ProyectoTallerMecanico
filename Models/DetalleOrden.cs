namespace ProyectoTallerMecanico.Models
{
    public class DetalleOrden
    {
        public int IdOrden { get; set; }
        public int IdServicio { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int Estatus { get; set; }
        public Orden Orden { get; set; }
        public Servicio Servicio { get; set; }
    }
}