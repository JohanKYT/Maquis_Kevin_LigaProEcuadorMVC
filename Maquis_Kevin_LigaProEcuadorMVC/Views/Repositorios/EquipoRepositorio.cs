using Maquis_Kevin_LigaProEcuadorMVC.Interfaces;
using Maquis_Kevin_LigaProEcuadorMVC.Models;

namespace Maquis_Kevin_LigaProEcuadorMVC.Views.Repositorios
{
    public class EquipoRepositorio : IEquipoRepository
    {
        public bool ActualizarEquipo(int ID, Equipo equipoActualizado)
        {
            var equipos = DevuelveListadoEquipos();
            var equipoExistente = equipos.FirstOrDefault(item => item.ID == ID);

            if (equipoExistente != null)
            {
                equipoExistente.PartidosGanados = equipoActualizado.PartidosGanados;
                equipoExistente.PartidosEmpatados = equipoActualizado.PartidosEmpatados;
                equipoExistente.PartidosPerdidos = equipoActualizado.PartidosPerdidos;
                // PartidosJugados y Puntos se calculan automáticamente
                return true;
            }

            return false;
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipoPorID(int ID)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.Where(item => item.ID == ID).First();
            return equipo;
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            return equipos;
        }
        private static List<Equipo> equipos = new List<Equipo>()
        {
            new Equipo
            {
                ID = 1,
                Nombre = "LDU",
                PartidosGanados = 5,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2,
                LOGOUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e0/Liga_Deportiva_Universitaria_de_Quito.png"
            },
            new Equipo
            {
                ID = 2,
                Nombre = "Barcelona",
                PartidosGanados = 6,
                PartidosEmpatados = 2,
                PartidosPerdidos = 2,
                LOGOUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6a/Barcelona_Sporting_Club_Logo.png"
            },
            new Equipo
            {
                ID = 3,
                Nombre = "Emelec",
                PartidosGanados = 4,
                PartidosEmpatados = 4,
                PartidosPerdidos = 2,
                LOGOUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d8/Escudo_del_Club_Sport_Emelec.svg"
            }
        };
        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }
}
