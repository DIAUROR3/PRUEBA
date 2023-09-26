namespace Prac3.Models
{
    public class Descuentos
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; } // Clave externa para relacionar con el empleado
        public decimal Monto { get; set; }  // Monto del descuento
        public DateTime Fecha { get; set; } // Fecha en que se aplicó el descuento

        // Propiedad de navegación para acceder al empleado relacionado
        public Empleados Empleado { get; set; }
    }
}
