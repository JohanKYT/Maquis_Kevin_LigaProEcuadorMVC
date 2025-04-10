using Maquis_Kevin_LigaProEcuadorMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Maquis_Kevin_LigaProEcuadorMVC.Views.Repositorios
{
    public class EquipoRepositorio
    {
        public List<Equipo> DevuelveListaRepositorio()
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
    }
}
