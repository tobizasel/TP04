﻿using Microsoft.AspNetCore.Mvc;

namespace TP_Zaselsky.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Paquete = ORTWorld.Paquetes;
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

        
        if (ORTWorld.IngresarPaquete(destinoSel))
        {
            ORTWorld.Paquetes.Add(destinoSel, new Paquete(hotelSel, aereolineaSel, excursionSel));
        }

        return View("index");
    }

}
