using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("hc")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        readonly ILogger<HealthCheckController> log;

        public HealthCheckController(ILogger<HealthCheckController> log)
        {
            this.log = log;
        }

        [HttpGet]
        public string Get()
        {
            log.LogDebug("Health check point is hit");
            return DateTime.UtcNow.ToString();
        }
    }
}
