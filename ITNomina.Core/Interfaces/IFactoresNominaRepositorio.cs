using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface IFactoresNominaRepositorio
    {
        Task<List<FactoresNomina>> ListarTodos();

        Task<FactoresNomina> ObtenerPorId();

        Task<FactoresNomina> Insertar();

        Task<FactoresNomina> Actualizar();

        Task<FactoresNomina> Eliminar();

    }	//*    
}
