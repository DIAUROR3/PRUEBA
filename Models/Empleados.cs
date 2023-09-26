namespace Prac3.Models
{
    public class Empleados
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ci { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Cargo { get; set; }
        public decimal SueldoBasico { get; set; }
        public int HorasTrabajadas { get; set; }
    }
}
