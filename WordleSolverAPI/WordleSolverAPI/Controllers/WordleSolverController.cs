namespace WordleSolverAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WordleSolverService.API;

    [ApiController]
    [Route("api/wordleSolver")]
    public class WordleSolverController
    {
        private readonly ILogger<WordleSolverController> _logger;
        public IWordleSolver _wordleSolver;

        public WordleSolverController(ILogger<WordleSolverController> logger, IWordleSolver wordleSolver)
        {
            _logger = logger;
            _wordleSolver = wordleSolver;
        }

        [HttpGet("Solve")]
        public string Solve()
        {
            return _wordleSolver.SolveWordle();
        }
        
    }
}
