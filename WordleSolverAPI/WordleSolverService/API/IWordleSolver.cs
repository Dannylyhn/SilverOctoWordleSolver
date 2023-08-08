using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleSolverService.API
{
    public interface IWordleSolver
    {
        public List<string> SolveWordle(string word, List<char> usedLetters);
    }
}
