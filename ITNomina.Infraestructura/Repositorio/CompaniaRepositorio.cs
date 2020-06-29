
using ITNomina.Core.Entidades;
using ITNomina.Core.Interfaces;
using ITNomina.Infraestructura.Datos;

using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITNomina.Infraestructura.Repositorio
{
    public class CompaniaRepositorio : ICompaniaRepositorio
    {
        private readonly ITNominaContext _contexto;

        public CompaniaRepositorio(ITNominaContext Contexto)
        {
            _contexto = Contexto;
        }
          
        public async Task<List<Companias>> ListarTodos()
        {
            var cias = await _contexto.Companias.ToListAsync();
            
            return cias;
        }

        public async Task<Companias> ObtenerPorId(int Id)
        {
            var cia = await _contexto.Companias.FirstOrDefaultAsync(x => x.CompaniaId == Id);

            return cia;
        }

        public async Task<int> Insertar(Companias Compania)
        {
            //bool insertar = false;
            int regInsertados;


            try
            {
                _contexto.Companias.Add(Compania);
                regInsertados = await _contexto.SaveChangesAsync();
                //insertar = true; 
            }
            catch (System.Exception)
            {

                throw;
            }
            //return insertar;
            return regInsertados;
        }

        public async Task<bool> Actualizar(Companias Compania)
        {
            bool actualizar = false;
            int regAfectados = 0;
            try
            {
                var regActual = await ObtenerPorId(Compania.CompaniaId);

                regActual.Nombre = Compania.Nombre;
                regActual.TipoDocumentoId = Compania.TipoDocumentoId;
                regActual.Documento = Compania.Documento;
                regActual.Direccion = Compania.Direccion;
                regActual.Telefonos = Compania.Telefonos;
                regActual.ContactoId = Compania.ContactoId;

                // Guardamos los cambios
                regAfectados = await _contexto.SaveChangesAsync();
                
                if(regAfectados > 0)
                    actualizar = true; 
            }
            catch (System.Exception)
            {

                throw;
            }
            return actualizar;
        }

        public async Task<bool> Eliminar(int Id)
        {
            bool eliminado = false;

            try
            {
                var regActual = await ObtenerPorId(Id);
                _contexto.Companias.Remove(regActual);
                

                if (await _contexto.SaveChangesAsync() > 0)
                    eliminado = true;
            }
            catch (System.Exception)
            {

                throw;
            }
            return eliminado;
        }
    }
}
