using Microsoft.AspNetCore.Mvc;

namespace PaquetesTuristicos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(string k)
    {
        Console.WriteLine(k);
        if(k !=null){
        ORTWorld.Paquetes.Remove(k);
        }
        ViewBag.lDestinos = ORTWorld.ListaDestinos;
        ViewBag.dPaquetes = ORTWorld.Paquetes;
        return View();
    }

    public IActionResult SelectPaquete()
    {
        if(TempData["error"] != null && TempData["error"].ToString() == "t"){
            ViewBag.Error = true;
        }else{
            ViewBag.Error = false;
        }
        ViewBag.lDestinos = ORTWorld.ListaDestinos;
        ViewBag.lImagenes = ORTWorld.ListaImagenes;

        return View();
    }

    public IActionResult GuardarPaquete(string _destino, int _hotel, int _aereo, int _excursion)
    {
        ViewBag.lDestinos = ORTWorld.ListaDestinos;
        ViewBag.lImagenes = ORTWorld.ListaImagenes;
        Paquete p = new Paquete(ViewBag.lImagenes[_hotel], ViewBag.lImagenes[_aereo], ViewBag.lImagenes[_excursion]);
        if (ORTWorld.IngresarPaquete(_destino, p)) {TempData["error"] = "f"; return RedirectToAction("Index");}
        else{TempData["error"] = "t"; return RedirectToAction("SelectPaquete"); }
    }




}
