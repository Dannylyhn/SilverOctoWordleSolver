namespace WordleSolverService.API
{
    public class WordleSolver : IWordleSolver
    {
        public string SolveWordle()
        {
            this.readTextFile();
            return "It is solved";
        }

        public List<string> readTextFile()
        {
            var listOfWords = new List<string>();

            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader("listOf5LetterWords.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string word = sr.ReadLine();
                        listOfWords.Add(word);
                        
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return listOfWords;
        }
    }
}