using Maquis_Kevin_LigaProEcuadorMVC.Interfaces;
using Maquis_Kevin_LigaProEcuadorMVC.Models;

namespace Maquis_Kevin_LigaProEcuadorMVC.Views.Repositorios
{
    public class EquipoRepositorio : IEquipoRepository
    {
        public bool ActualizarEquipo()
        {
            throw new NotImplementedException();
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
            List<Equipo> equipos = new List<Equipo>();
            Equipo LDU = new Equipo()
            {
                ID = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2
            };
            equipos.Add(LDU);

            Equipo Barcelona = new Equipo()
            {
                ID = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 6,
                PartidosEmpatados = 2,
                PartidosPerdidos = 2
            };
            equipos.Add(Barcelona);

            Equipo Emelec = new Equipo()
            {
                ID = 2,
                Nombre = "Emelec",
                PartidosJugados = 10,
                PartidosGanados = 4,
                PartidosEmpatados = 4,
                PartidosPerdidos = 2
            };
            equipos.Add(Emelec);

            return equipos;
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }
}
