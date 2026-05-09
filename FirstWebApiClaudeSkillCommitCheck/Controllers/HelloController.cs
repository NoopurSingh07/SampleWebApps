using Microsoft.AspNetCore.Mvc;

namespace FirstWebApiClaudeSkillCommitCheck.Controllers
{
    [ApiController]
    [Route("[controller]")]
     public class HelloController : ControllerBase
     {
        [HttpGet]
        public string Get() => "Hello from Claude AI!";
     }
    
}
