namespace WordleSolverService.API
{
    public class WordleSolver : IWordleSolver
    {
        public List<string> SolveWordle(string word, List<char> usedLetters)
        {
            //FRIES
            var dummyWord = "F_I_S";
            var dummyUsedLetters = new List<char>
            {
                'd',
                'f',
                'k'
            };

            var listOfWords = sortUsedLetters(dummyUsedLetters, this.readTextFile());

            foreach (var letter in dummyWord.Split(""))
            {
                int i = 0;

                if(letter == "_")
                {
                    continue;
                }
                listOfWords.Find(x => x.Split("")[i] == letter);
                i++;
            }


            return new List<string> { "hello"};
        }


        private List<string> sortUsedLetters(List<char> usedLetters, List<string> listOfWords)
        {
            foreach(var letter in usedLetters)
            {

            }



            return new List<string>();
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