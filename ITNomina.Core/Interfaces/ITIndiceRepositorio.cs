using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface ITIndiceRepositorio
    {
        Task<List<TIndice>> ListarTodos();

        Task<TIndice> ObtenerPorId();

        Task<TIndice> Insertar();

        Task<TIndice> Actualizar();

        Task<TIndice> Eliminar();

    }	//*    
}