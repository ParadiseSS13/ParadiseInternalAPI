using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ParadiseInternalAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParadiseInternalAPI.Core {
    public abstract class ParaControllerBase : Controller {
        protected ILogger<ParaControllerBase> _logger;
        protected paradise_gamedbContext _context;
        protected IConfiguration _config;

        public override void OnActionExecuting(ActionExecutingContext context) {
            if(!context.HttpContext.Request.Headers.ContainsKey("AuthKey")) {
                Unauthorized("Auth key not provided!");
                return;
            }

            if (!context.HttpContext.Request.Headers["AuthKey"].Equals(_config["AuthKey"])) {
                Unauthorized("Auth key invalid!");
                return;
            }

            base.OnActionExecuting(context);
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next) {
            if (!context.HttpContext.Request.Headers.ContainsKey("AuthKey")) {
                await Unauthorized("Auth key not provided!").ExecuteResultAsync(context).ConfigureAwait(false);
                return;
            }

            if (!context.HttpContext.Request.Headers["AuthKey"].Equals(_config["AuthKey"])) {
                await Unauthorized("Auth key invalid!").ExecuteResultAsync(context).ConfigureAwait(false);
                return;
            }

            await base.OnActionExecutionAsync(context, next).ConfigureAwait(false);
        }
    }
}
