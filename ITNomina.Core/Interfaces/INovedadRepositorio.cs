using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface INovedadRepositorio
    {
        Task<List<Novedad>> ListarTodos();

        Task<Novedad> ObtenerPorId();

        Task<Novedad> Insertar();

        Task<Novedad> Actualizar();

        Task<Novedad> Eliminar();

    }	//*    
}
