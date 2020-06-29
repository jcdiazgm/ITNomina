using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface ISexoRepositorio
    {
        Task<List<Sexo>> ListarTodos();

        Task<Sexo> ObtenerPorId();

        Task<Sexo> Insertar();

        Task<Sexo> Actualizar();

        Task<Sexo> Eliminar();

    }	//*    
}
