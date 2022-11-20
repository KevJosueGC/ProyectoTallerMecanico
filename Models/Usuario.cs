using System.ComponentModel.DataAnnotations;

namespace ProyectoTallerMecanico.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public string Alias { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Estatus { get; set; }
        public Empleado Empleado { get; set; }

    }
}