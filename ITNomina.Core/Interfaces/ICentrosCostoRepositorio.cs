using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface ICentrosCostoRepositorio
    {
        Task<List<CentrosCosto>> ListarTodos();

        Task<CentrosCosto> ObtenerPorId();

        Task<CentrosCosto> Insertar();

        Task<CentrosCosto> Actualizar();

        Task<CentrosCosto> Eliminar();

    }	//*    
}