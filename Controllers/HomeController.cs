using Microsoft.AspNetCore.Mvc;

namespace TP_Zaselsky.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Paquete = ORTWorld.Paquete;
        return View();
    }

    public IActionResult SelectPaquete()
    {
        ViewBag.destinos = ORTWorld.ListaDestinos;
        ViewBag.hoteles = ORTWorld.ListaHoteles;
        ViewBag.aereos = ORTWorld.ListaAereos;
        ViewBag.excursiones = ORTWorld.ListaExcursiones;
        

        return View();
    }
}
