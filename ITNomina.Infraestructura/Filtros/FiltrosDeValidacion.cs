using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace ITNomina.Infraestructura.Filtros
{
    /// <summary>
    /// Clase que implementa filtros de validacion a nivel global para todos los cotroladores
    /// </summary>
    public class FiltrosDeValidacion : IAsyncActionFilter

    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if(!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
                // Retornamos este context.Result
            }

            //Sino se presentó error entonces continuamos con el flujo de la aplicación
            await next();
        }
    }   //*
}
