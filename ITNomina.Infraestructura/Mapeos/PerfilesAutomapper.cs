using AutoMapper;

using ITNomina.Core.DTOs;
using ITNomina.Core.Entidades;

using System;
using System.Collections.Generic;
using System.Text;

namespace ITNomina.Infraestructura.Mapeos
{
    public class PerfilesAutomapper : Profile 
    {
        public PerfilesAutomapper()
        {
            CreateMap<Companias, CompaniaDto>();
            CreateMap<CompaniaDto, Companias>();
        }
    }   //*
}
