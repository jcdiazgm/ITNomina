using FluentValidation;

using ITNomina.Core.DTOs;

using System;
using System.Collections.Generic;
using System.Text;

namespace ITNomina.Infraestructura.Validadores
{
    /// <summary>
    /// En esta clase se implementan las reglas de validación para las entidades
    /// Este tipo de reglas sustituye a los DataAnnotations que se colocna en las entidades
    /// </summary>
    public class CompaniaValidador : AbstractValidator<CompaniaDto>
    {
        public CompaniaValidador()
        {
            RuleFor(ciaDto => ciaDto.Nombre)
             .NotNull()
             .Length(5, 50);
        }
    }   //*
}
