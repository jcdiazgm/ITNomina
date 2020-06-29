using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface IParametroAppRepositorio
    {
        Task<List<ParametroApp>> ListarTodos();

        Task<ParametroApp> ObtenerPorId();

        Task<ParametroApp> Insertar();

        Task<ParametroApp> Actualizar();

        Task<ParametroApp> Eliminar();

    }	//*    
}
