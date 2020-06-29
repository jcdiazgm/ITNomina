using ITNomina.Core.Entidades;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface ITNominaRepositorio
    {
        Task<List<TNomina>> ListarTodos();

        Task<TNomina> ObtenerPorId();

        Task<TNomina> Insertar();

        Task<TNomina> Actualizar();

        Task<TNomina> Eliminar();

    }	//*    
}