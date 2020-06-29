using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface ITEntidadRepositorio
    {
        Task<List<TEntidad>> ListarTodos();

        Task<TEntidad> ObtenerPorId();

        Task<TEntidad> Insertar();

        Task<TEntidad> Actualizar();

        Task<TEntidad> Eliminar();

    }	//*    
}