using Microsoft.AspNetCore.Mvc.Filters;


namespace WebApiLaptops.Filtros
{
    public class FiltroDeExepcion : ExceptionFilterAttribute
    {
        private readonly ILogger<FiltroDeExepcion> log;

        public FiltroDeExepcion(ILogger<FiltroDeExepcion> log)
        {
            this.log = log;
        }

        public override void OnException(ExceptionContext context)
        {
            log.LogError(context.Exception, context.Exception.Message);
            base.OnException(context);
        }
    }
}
