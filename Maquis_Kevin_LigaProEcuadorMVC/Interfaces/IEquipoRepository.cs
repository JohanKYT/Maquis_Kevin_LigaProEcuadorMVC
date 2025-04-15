using Maquis_Kevin_LigaProEcuadorMVC.Models;

namespace Maquis_Kevin_LigaProEcuadorMVC.Interfaces
{
    public interface IEquipoRepository
    {
        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveInfoEquipoPorID();
        bool CrearEquipo();
        bool ActualizarEquipo();
        bool EliminarEquipo();
    }
}
