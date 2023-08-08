namespace WordleSolverAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/wordleSolver")]
    public class WordleSolverController
    {
        private readonly ILogger<WordleSolverController> _logger;

        public WordleSolverController(ILogger<WordleSolverController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Solve")]
        public string Solve()
        {
            return "Hello";
        }
        
    }
}
