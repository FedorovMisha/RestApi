using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServerApp.WebApi.Models;

namespace ServerApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        private readonly IRepository<LoginFormModel> _repository;
        
        public LoginController(ILogger<LoginController> logger, IRepository<LoginFormModel> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        
        [HttpPost("{model}")]
        public async Task<IActionResult> Login([FromBody]LoginFormModel model)
        {
            await _repository.Add(model);
            _logger.LogWarning(HttpContext.Request.Path);
            
            // _logger.LogInformation($"Model with id = {model.Id} is aded");
            // _logger.LogInformation($" Model email: {model.Email} and Model password: {model.Password}");

            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpGet]
        public JsonResult GetLogin(int id)
        {
            return Json(_repository.Get(id));
        }
        
    }
}