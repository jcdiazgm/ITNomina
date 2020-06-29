using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface IContactoCiaRepositorio
    {
        Task<List<ContactoCia>> ListarTodos();

        Task<ContactoCia> ObtenerPorId();

        Task<ContactoCia> Insertar();

        Task<ContactoCia> Actualizar();

        Task<ContactoCia> Eliminar();

    }	//*    
}