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
            Equipo LDU = new Equipo()
            {
                ID = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2,
                LOGOUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e0/Liga_Deportiva_Universitaria_de_Quito.png"
            };
            return View(LDU);

            EquipoRepositorio repositorio = new EquipoRepositorio();
            var equipos = repositorio.DevuelveInfoEquipoPorID(ID);
            return View(equipos);

        }
    }
}

