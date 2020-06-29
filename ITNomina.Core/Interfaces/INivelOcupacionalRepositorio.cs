using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface INivelOcupacionalRepositorio
    {
        Task<List<NivelOcupacional>> ListarTodos();

        Task<NivelOcupacional> ObtenerPorId();

        Task<NivelOcupacional> Insertar();

        Task<NivelOcupacional> Actualizar();

        Task<NivelOcupacional> Eliminar();

    }	//*    
}
