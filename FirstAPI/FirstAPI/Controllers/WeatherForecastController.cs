using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;

namespace FirstAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private ILoggerManager _logger;
        
        //private readonly ILogger<WeatherForecastController> _logger;
        
        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogDebug("here is debug message from our values controller.");
            _logger.LogError("here is error message from our values controller.");
            _logger.LogInfo("here is info message from our values controller.");
            _logger.LogWarn("here is warn message from our values controller.");

            return new string[] {"value1", "value2"};
        }
        
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        
    }
}
