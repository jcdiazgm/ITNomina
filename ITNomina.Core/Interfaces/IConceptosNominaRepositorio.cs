using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface IConceptosNominaRepositorio
    {
        Task<List<ConceptosNomina>> ListarTodos();

        Task<ConceptosNomina> ObtenerPorId();

        Task<ConceptosNomina> Insertar();

        Task<ConceptosNomina> Actualizar();

        Task<ConceptosNomina> Eliminar();

    }	//*    
}