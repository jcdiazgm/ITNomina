using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface ICiudadRepositorio
    {
        Task<List<Ciudad>> ListarTodos();

        Task<Ciudad> ObtenerPorId();

        Task<Ciudad> Insertar();

        Task<Ciudad> Actualizar();

        Task<Ciudad> Eliminar();

    }	//*    
}