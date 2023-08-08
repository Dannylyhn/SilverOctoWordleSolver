namespace WordleSolverService.API
{
    public class WordleSolver : IWordleSolver
    {
        public List<string> SolveWordle(string word, List<char> usedLetters)
        {
            //FRIES
            var dummyWord = "f_i_s";
            var dummyUsedLetters = new List<char>
            {
                'd',
                'k',
                'a',
            };

            var result = new List<string>();

            var listOfWords = sortUsedLetters(dummyUsedLetters, this.readTextFile());
            int i = 0;

            foreach (var letter in dummyWord.ToCharArray())
            {
                if(letter.ToString() == "_")
                {
                    i++;
                    continue;
                }
                result = listOfWords.Where(x => x.ToCharArray()[i] == letter).ToList();
                listOfWords = result;
                i++;
            }

            return result;
        }


        private List<string> sortUsedLetters(List<char> usedLetters, List<string> listOfWords)
        {
            var result = new List<string>();
            var list = new List<string>();

            foreach(var letter in usedLetters)
            {
                list = listOfWords.Where(x => !x.Contains(letter.ToString())).ToList();
                listOfWords = list;
            }

            result.AddRange(list);
            return result;
        }

        private List<string> readTextFile()
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