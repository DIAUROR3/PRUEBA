using Microsoft.AspNetCore.Mvc;
using Prac3.Data;
using Prac3.Models;
using System; // Agregar esta línea para la clase DateTime

namespace Prac3.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly Prac3Context _context;

        public EmpleadoController(Prac3Context context)
        {
            _context = context;
        }

        public IActionResult AgregarEmpleado()
        {
            var nuevoEmpleado = new Empleados
            {
                Nombre = "Nombre del Empleado",
                Ci = "123456789",
                FechaIngreso = DateTime.Now,
                Cargo = "Cargo del Empleado",
                SueldoBasico = 1000.00m,
                HorasTrabajadas = 40
            };

            // Aquí agregamos validación de modelo
            if (ModelState.IsValid)
            {
                _context.Empleados.Add(nuevoEmpleado);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            // Si la validación de modelo falla, puedes manejar el error de alguna manera, por ejemplo, mostrando un mensaje de error o redirigiendo a una vista de error.
            return View("Error"); // Cambia "Error" por el nombre de tu vista de error.
        }
    }
}
