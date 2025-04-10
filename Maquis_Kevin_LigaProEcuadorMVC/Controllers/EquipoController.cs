using Maquis_Kevin_LigaProEcuadorMVC.Models;
using Maquis_Kevin_LigaProEcuadorMVC.Views.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Maquis_Kevin_LigaProEcuadorMVC.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            EquipoRepositorio repositorio = new EquipoRepositorio();
            var equipos = repositorio.DevuelveListaRepositorio();  
            return View(equipos);
        }
            
    }
}
