namespace WordleSolverAPI.Models.Requests
{
    public class SolverRequest
    {
        public string Word {get; set;}
        public List<char> InvalidChars { get; set;}

        public List<char> ValidChars { get; set; }

    }
}
