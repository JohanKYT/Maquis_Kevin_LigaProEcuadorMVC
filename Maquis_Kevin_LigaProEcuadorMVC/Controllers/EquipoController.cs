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
            var equipos = repositorio.DevuelveListadoEquipos();
            return View(equipos);
        }
        public IActionResult Details(int ID)
        {
            EquipoRepositorio repositorio = new EquipoRepositorio();
            var equipos = repositorio.DevuelveInfoEquipoPorID(ID);
            return View(equipos);

        }
        public IActionResult Edit(int ID)
        {
            EquipoRepositorio repositorio = new EquipoRepositorio();
            var equipos = repositorio.DevuelveInfoEquipoPorID(ID);
            return View(equipos);

        }
        //Esto se uso inteligencia artificial para poder guardar correctamente los nuevos datos de los equipos
        [HttpPost]
        public IActionResult Edit(Equipo equipo)
        {
            EquipoRepositorio repositorio = new EquipoRepositorio();
            var actualizado = repositorio.ActualizarEquipo(equipo.ID, equipo);

            if (actualizado)
            {
                return RedirectToAction("ListaEquipos");
            }

            // En caso de error, vuelve a mostrar el formulario con el modelo
            return View(equipo);
        }
        
    }
}

