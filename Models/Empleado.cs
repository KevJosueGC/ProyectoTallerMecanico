using System.ComponentModel.DataAnnotations;

namespace ProyectoTallerMecanico.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public float Sueldo { get; set; }
        public int Estatus { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<Orden> Ordenes { get; set; }

        // 1 para indicar que el estatus es ACTIVO
        public Empleado() => this.Estatus = 1;
    }
}