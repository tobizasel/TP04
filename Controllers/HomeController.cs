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
        PasarImagenes();
        return View();
    }

    public void PasarImagenes()
    {

        List <string> rutaDestinos = new List<string>();
        List <string> rutaHoteles = new List<string>();
        List <string> rutaAereos = new List<string>();
        List <string> rutaExcursiones = new List<string>();


        for (int i = 0; i < ORTWorld.ListaDestinos.Count; i++)
        {   
            rutaDestinos.Add(ORTWorld.ListaDestinos[i]+".jpg");
            rutaAereos.Add(ORTWorld.ListaAereos[i]+".jpg");
            rutaExcursiones.Add(ORTWorld.ListaHoteles[i]+".jpg");
        }

        foreach (string item in ORTWorld.ListaHoteles)
        {
            rutaHoteles.Add(item+".jpg");

        }

        // ViewBag.rutaAereos = rutaAereos;
        // ViewBag.rutaDestinos = rutaDestinos;
        // ViewBag.rutaExcursiones = rutaExcursiones;
        ViewBag.rutaHoteles = rutaHoteles;
        

    }
}
