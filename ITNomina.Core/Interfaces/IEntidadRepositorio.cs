using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface IEntidadRepositorio
    {
        Task<List<Entidad>> ListarTodos();

        Task<Entidad> ObtenerPorId();

        Task<Entidad> Insertar();

        Task<Entidad> Actualizar();

        Task<Entidad> Eliminar();

    }	//*    
}