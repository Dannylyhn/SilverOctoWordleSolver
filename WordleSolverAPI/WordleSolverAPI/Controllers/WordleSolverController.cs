namespace WordleSolverAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WordleSolverAPI.Models.Requests;
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

        [HttpPost("solve")]
        public List<string> solve(SolverRequest request)
        {
            List<char> testing = new List<char>();
            return _wordleSolver.SolveWordle("H_LLO", testing);
        }
        
    }
}
