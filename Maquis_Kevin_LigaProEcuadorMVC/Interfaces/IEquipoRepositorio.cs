using Maquis_Kevin_LigaProEcuadorMVC.Models;

namespace Maquis_Kevin_LigaProEcuadorMVC.Interfaces
{
    public interface IEquipoRespository
    {
        List<Equipo> DevuelevListadoEquipos();
        Equipo DevuelveInfoEquipo();
        bool CrearEquipo();
        bool EliminarEquipo();

    }
}

