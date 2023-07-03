using Microsoft.AspNetCore.Mvc;

namespace P4h_Saude_Site.Controllers
{
    public class Paginas : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AppApoio()
        {
            return View("AppApoio", "Paginas");
        }

        public IActionResult VendaOnline()
        {
            return View("VendaOnline", "Paginas");
        }

        public IActionResult TabelaDeVendas()
        {
            return View("TabelaDeVendas", "Paginas");
        }

        public IActionResult Documentos()
        {
            return View("Documentos", "Paginas");
        }

        public IActionResult Coparticipacao()
        {
            return View("Coparticipacao", "Paginas");
        }

    }
}
