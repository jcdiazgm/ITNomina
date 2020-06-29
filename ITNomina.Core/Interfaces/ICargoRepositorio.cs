using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface ICargoRepositorio
    {
        Task<List<Cargo>> ListarTodos();

        Task<Cargo> ObtenerPorId();

        Task<Cargo> Insertar();

        Task<Cargo> Actualizar();

        Task<Cargo> Eliminar();

    }	//*    
}