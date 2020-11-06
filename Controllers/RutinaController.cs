using System.Linq;
using DiarsT3.DB.Context;
using DiarsT3.Estrategia;
using DiarsT3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiarsT3.Controllers
{
    public class RutinaController : Controller
    {
        private readonly DiarsT3Context context;

        public RutinaController()
        {
            context = new DiarsT3Context();
        }

        public IActionResult Index()
        {
            var usuarioId = HttpContext.Session.GetString("UsuarioId");
            if (!string.IsNullOrEmpty(usuarioId))
            {
                var rutinas = context.Rutinas.Include(o => o.EjercicioRutinas).ThenInclude(o => o.Ejercicio).Where(x => x.UsuarioId.ToString() == usuarioId).ToList();
                return View(rutinas);
            }
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Rutina rutina)
        {
            if (!string.IsNullOrEmpty(rutina.Nombre))
            {
                var usuarioId = HttpContext.Session.GetString("UsuarioId");
                rutina.UsuarioId = int.Parse(usuarioId);
                context.Rutinas.Add(rutina);
                context.SaveChanges();
                var registradorEjercicios = new RegistradorDeEjercicios(rutina);
                registradorEjercicios.RegistrarEjercicios();
                return RedirectToAction("Index", "Rutina");
            }
            ModelState.AddModelError("Error", "Los datos ingresados no son válidos");
            return View();
        }

        public IActionResult Detalle(int id)
        {
            var rutina = context.Rutinas.Include(o => o.EjercicioRutinas).ThenInclude(o => o.Ejercicio).Where(x => x.Id == id).FirstOrDefault();
            return View(rutina);
        }
    }
}
