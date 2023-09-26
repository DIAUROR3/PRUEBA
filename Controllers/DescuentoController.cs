using Microsoft.AspNetCore.Mvc;
using Prac3.Data;
using Prac3.Models;
using System;

namespace Practica_3.Controllers
{
    public class DescuentoController : Controller
    {
        private readonly Prac3Context _context;

        public DescuentoController(Prac3Context context)
        {
            _context = context;
        }

        public IActionResult AgregarDescuento()
        {
            var nuevoDescuento = new Descuentos
            {
                EmpleadoId = 1, // ID del empleado al que se aplica el descuento
                Monto = 50.00m, // Monto del descuento
                Fecha = DateTime.Now
            };

            // Aquí agregamos validación de modelo
            if (ModelState.IsValid)
            {
                _context.Descuentos.Add(nuevoDescuento);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            // Si la validación de modelo falla, puedes manejar el error de alguna manera, por ejemplo, mostrando un mensaje de error o redirigiendo a una vista de error.
            return View("Error"); // Cambia "Error" por el nombre de tu vista de error.
        }
    }
}
