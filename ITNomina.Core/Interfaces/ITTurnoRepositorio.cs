using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface ITTurnoRepositorio
    {
        Task<List<TTurno>> ListarTodos();

        Task<TTurno> ObtenerPorId();

        Task<TTurno> Insertar();

        Task<TTurno> Actualizar();

        Task<TTurno> Eliminar();

    }	//*    
}