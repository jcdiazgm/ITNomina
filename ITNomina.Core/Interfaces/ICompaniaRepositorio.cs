using ITNomina.Core.Entidades;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITNomina.Core.Interfaces
{
    public interface ICompaniaRepositorio
    {
        Task<List<Companias>> ListarTodos();

        Task<Companias> ObtenerPorId(int Id);

        Task<int> Insertar(Companias compania);

        Task<bool> Actualizar(Companias Compania);

        // En esta definición se solicita el Id del registroa a actualizar
        //Task<bool> Actualizar(int Id, Companias Compania);

        Task<bool> Eliminar(int Id);
    }
}
