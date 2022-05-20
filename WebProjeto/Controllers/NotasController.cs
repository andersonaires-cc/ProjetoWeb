using Microsoft.AspNetCore.Mvc;

namespace WebProjeto.Controllers
{
    public class NotasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
