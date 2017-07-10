using nInjectTest.Models;
using System.Web.Http;

namespace nInjectTest.Controllers
{
    public class LoggerController : ApiController
    {
        private ILogger _logger;

        public LoggerController(ILogger logger)
        {
            _logger = logger;
        }

        public IHttpActionResult GetLoggerType()
        {
            var loggerType = _logger.GetLoggerType();
            return Ok(loggerType);
        }
    }
}
