using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface ITurnoEmpleadoRepositorio
    {
        Task<List<TurnoEmpleado>> ListarTodos();

        Task<TurnoEmpleado> ObtenerPorId();

        Task<TurnoEmpleado> Insertar();

        Task<TurnoEmpleado> Actualizar();

        Task<TurnoEmpleado> Eliminar();

    }	//*    
}