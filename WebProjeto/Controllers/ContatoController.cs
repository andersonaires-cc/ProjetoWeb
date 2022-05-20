using Microsoft.AspNetCore.Mvc;

namespace WebProjeto.Controllers
{
    public class ContatoController : Controller
    {
        // Método principal da pagina Index da controller
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

    }
}
