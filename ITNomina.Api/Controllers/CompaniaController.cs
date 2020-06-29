using ITNomina.Core.Interfaces;
using ITNomina.Core.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ITNomina.Core.DTOs;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using AutoMapper;

namespace ITNomina.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniaController : ControllerBase
    {
        //private readonly IRepositorioGenerico<Companias> _repositorio;
        //private readonly IUnitOfWork _unitOfWork;
        private readonly ICompaniaRepositorio _repositorio;
        private readonly IMapper _mapper;

        public CompaniaController(ICompaniaRepositorio Repositorio, IMapper Mapper)  //, IUnitOfWork UnitOfWork)
        {
            _repositorio = Repositorio;
            _mapper = Mapper;
            //_unitOfWork = UnitOfWork;
        }
        
        [HttpGet]
        public async Task<ActionResult> Listar()
        {
            var companias = await _repositorio.ListarTodos();
            var companiasDto = _mapper.Map<List<CompaniaDto>>(companias);

            return Ok(companiasDto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerPorId(int Id)
        {
            var compania =  await _repositorio.ObtenerPorId(Id);
            var companiaDto = _mapper.Map<CompaniaDto>(compania);

            return Ok(companiaDto);
        }

        [HttpPost]
        public async Task<Companias> Insertar([FromBody] CompaniaDto companiaDto)
        {
            var compania = _mapper.Map<Companias>(companiaDto);
            int resultado = await _repositorio.Insertar(compania);

            return compania;
        }

        [HttpPut]
        public async Task<IActionResult> Actualizar(int Id, CompaniaDto companiaDto)
        {
            var compania = _mapper.Map<Companias>(companiaDto);
            compania.CompaniaId = Id;

            await _repositorio.Actualizar(compania);

            return Ok(compania);
        }

        [HttpDelete]
        public async Task<IActionResult> Elininar(int Id)
        {
            var eliminado = await _repositorio.Eliminar(Id);
            return Ok(eliminado);

        }



    }   //*
}
