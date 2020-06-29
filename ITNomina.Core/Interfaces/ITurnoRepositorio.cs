using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface ITurnoRepositorio
    {
        Task<List<Turno>> ListarTodos();

        Task<Turno> ObtenerPorId();

        Task<Turno> Insertar();

        Task<Turno> Actualizar();

        Task<Turno> Eliminar();

    }	//*    
}