using System.Linq;
using DiarsT3.DB.Context;
using DiarsT3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiarsT3.Controllers
{
    public class AuthController : Controller
    {
        private readonly DiarsT3Context context;

        public AuthController()
        {
            context = new DiarsT3Context();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User usuario)
        {
            if (!string.IsNullOrEmpty(usuario.Username))
            {
                var usuarioEncontrado = context.Usuarios.Where(o => o.Username == usuario.Username && o.Password == usuario.Password).FirstOrDefault();
                if (usuarioEncontrado != null)
                {
                    HttpContext.Session.SetString("UsuarioId", usuarioEncontrado.Id.ToString());
                    return RedirectToAction("Index", "Routine");
                }
            }
            ViewBag.LoginError = "Datos incorrectos";
            return View();
        }
    }
}
