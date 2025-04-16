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
                Nombre = "LDU (Liga De Quito)",
                PartidosGanados = 5,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2,
                LOGOUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e0/Liga_Deportiva_Universitaria_de_Quito.png",
                Descripcion = "Liga de Quito es uno de los clubes más exitosos y respetados del fútbol ecuatoriano." +
                " Ha sido campeón nacional en varias ocasiones y es reconocido internacionalmente por ganar la Copa Libertadores en 2008, convirtiéndose en el primer club ecuatoriano en lograrlo." +
                " Su hinchada es apasionada y su estadio, Casa Blanca, es una fortaleza histórica en la capital."
            },
            new Equipo
            {
                ID = 2,
                Nombre = "Barcelona SC",
                PartidosGanados = 6,
                PartidosEmpatados = 2,
                PartidosPerdidos = 2,
                LOGOUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6a/Barcelona_Sporting_Club_Logo.png",
                Descripcion = "Barcelona SC es el club más popular de Ecuador, con una enorme afición a nivel nacional. " +
                "Fundado en 1925, ha ganado múltiples títulos de la Serie A y ha llegado a la final de la Copa Libertadores en dos ocasiones. Su estadio, el Monumental, es uno de los más grandes de Sudamérica." +
                " Es un equipo símbolo de Guayaquil y del fútbol ecuatoriano"
            },
            new Equipo
            {
                ID = 3,
                Nombre = "Emelec",
                PartidosGanados = 4,
                PartidosEmpatados = 4,
                PartidosPerdidos = 2,
                LOGOUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d8/Escudo_del_Club_Sport_Emelec.svg",
                Descripcion = "Emelec es uno de los clubes más tradicionales y competitivos del fútbol ecuatoriano. " +
                "Fundado en 1929 en Guayaquil, se ha coronado campeón nacional en varias ocasiones y es reconocido por su estilo de juego dinámico y ofensivo. " +
                "Su hinchada, conocida como la “Boca del Pozo”, es una de las más fervientes del país. " +
                "Juega en el estadio George Capwell, un ícono del deporte en Ecuador."
            }
        };
        //Se uso inteligencia artificial para poder crear el logo y la descripcion de los equipos
        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }
}
