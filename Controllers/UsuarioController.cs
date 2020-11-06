using DiarsT3.DB.Context;
using DiarsT3.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiarsT3.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DiarsT3Context context;

        public UsuarioController()
        {
            context = new DiarsT3Context();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Usuario usuario)
        {
            if (!string.IsNullOrEmpty(usuario.Username) && !string.IsNullOrEmpty(usuario.Password))
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return RedirectToAction("Login", "Auth");
            }
            ModelState.AddModelError("Error", "Los datos ingresados no son válidos");
            return View();
        }
    }
}
