using ITNomina.Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITNomina.Infraestructura.Repositorio
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        //private readonly IUnitOfWork _unitOfWork;

        //public RepositorioGenerico(IUnitOfWork UnitOfWork)
        //{
        //    _unitOfWork = UnitOfWork;
        //}

        public async Task<List<T>> ListarTodosAsync()
        {
            return null;
        }

        public async Task<T> ObtenerPorIdAsync(int Id)
        {
            return null;
        }

        public async Task<bool> InsertarAsync(T Entidad)
        {
            bool regInsertado = false;

            try
            {
                //var guardar = await _unitOfWork.Context.Set<T>().AddAsync(Entidad);

                //if(guardar != null)
                //{
                //    regInsertado = true;
                //}
            }
            catch (Exception)
            {
                throw;
            }

            return regInsertado;
        }

        public async Task<T> ActualizarAsync()
        {
            return null;
        }

        public async Task<T> EliminarAsync()
        {
            return null;
        }

    }   //*
}
