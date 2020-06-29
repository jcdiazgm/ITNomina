using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface IRepositorioGenerico<T> where T : class
    {
        Task<List<T>> ListarTodosAsync();

        Task<T> ObtenerPorIdAsync(int Id);

        Task<bool> InsertarAsync(T Entidad);

        Task<T> ActualizarAsync();

        Task<T> EliminarAsync();

    }   //*
}
