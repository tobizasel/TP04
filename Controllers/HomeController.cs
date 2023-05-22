using Microsoft.AspNetCore.Mvc;

namespace TP_Zaselsky.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Paquetes = ORTWorld.Paquetes;
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

    public IActionResult GuardarPaquete(string destinoSel, string hotelSel, string aereolineaSel, string excursionSel){

         if (ORTWorld.IngresarPaquete(destinoSel)){

            ORTWorld.Paquetes.Add(destinoSel, new Paquete(hotelSel, aereolineaSel, excursionSel));
            return RedirectToAction("Index");
        } else {
            return RedirectToAction("SelectPaquete");
        }

    }

    public IActionResult BorrarPaquete(string key){

        ORTWorld.BorrarPaquete(key);
        return RedirectToAction("index");
    }

}
