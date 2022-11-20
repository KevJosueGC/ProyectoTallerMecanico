using System.ComponentModel.DataAnnotations;

namespace ProyectoTallerMecanico.Models
{
    public class Cliente
    {
        [Key]
        public int CUI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Estatus { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
    }
}