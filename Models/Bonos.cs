namespace Prac3.Models
{
    public class Bonos
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; } // Clave externa para relacionar con el empleado
        public decimal Monto { get; set; }  // Monto del bono
        public DateTime Fecha { get; set; } // Fecha en que se otorgó el bono

        // Propiedad de navegación para acceder al empleado relacionado
        public Empleados Empleado { get; set; }
    }
}
