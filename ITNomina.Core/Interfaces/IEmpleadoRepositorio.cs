using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface IEmpleadoRepositorio
    {
        Task<List<Empleado>> ListarTodos();

        Task<Empleado> ObtenerPorId();

        Task<Empleado> Insertar();

        Task<Empleado> Actualizar();

        Task<Empleado> Eliminar();

    }	//*    
}