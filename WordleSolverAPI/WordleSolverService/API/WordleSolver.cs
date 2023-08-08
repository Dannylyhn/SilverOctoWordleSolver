namespace WordleSolverService.API
{
    public class WordleSolver : IWordleSolver
    {
        public List<string> SolveWordle(string word, List<char> usedLetters)
        {
            var listOfWords = this.readTextFile();

            return new List<string> { "hello"};
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
                        if(word != null)
                        {
                            listOfWords.Add(word);
                        }
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