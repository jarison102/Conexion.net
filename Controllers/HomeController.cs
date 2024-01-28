using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BibliotecaWebb.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaWebb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
            public IActionResult AgregarAutor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AgregarAutor(string nombre)
        {
            // Aquí deberías guardar el nuevo autor en tu base de datos
            // Puedes utilizar el servicio ApplicationDbContext para interactuar con la base de datos

            // Por ejemplo:
            // var nuevoAutor = new Autor { Nombre = nombre };
            // _dbContext.Autores.Add(nuevoAutor);
            // _dbContext.SaveChanges();

            return RedirectToAction("Lista"); // Redirige a la página de lista después de agregar el autor
        }

        public IActionResult AgregarLibro()
        {
            return View();
        }

        public IActionResult Lista()
        {
            return View();
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
