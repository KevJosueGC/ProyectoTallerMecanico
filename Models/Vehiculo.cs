using System.ComponentModel.DataAnnotations;

namespace ProyectoTallerMecanico.Models
{
    public class Vehiculo
    {
        [Key]
        public int NumeroPlaca { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public int Estatus  { get; set; }
        public Cliente Cliente { get; set; }
        public List<Orden> Ordenes { get; set; }

    }
}