namespace WordFinder.Core.Services.Words
{
    public class WordService : IWordService
    {

        public OutputWordDTO FindWords(InputLetterDTO dto, int letterCount)
        {
            var result = new OutputWordDTO();

            var path = Directory.GetCurrentDirectory() + "/words.txt";
            var source = File.ReadAllText(path).Split("\r\n").ToList();
            var finalSource = new List<string>();
            var letters = dto.Letters.Split("-").ToList();
            foreach (var word in source)
            {
                foreach (var letter in letters)
                {
                    if (word.Contains(letter))
                    {
                        finalSource.Add(word);
                    }
                }
            }
            finalSource = finalSource.Where(x => x.Length == letterCount).Distinct().ToList();
            if (nameof(Find3LetterWords).Contains(letterCount.ToString()))
            {
                result.Words = Find3LetterWords(letters, finalSource);
            }
            if (nameof(Find4LetterWords).Contains(letterCount.ToString()))
            {
                result.Words = Find4LetterWords(letters, finalSource);
            }
            if (nameof(Find5LetterWords).Contains(letterCount.ToString()))
            {
                result.Words = Find5LetterWords(letters, finalSource);
            }
            if (nameof(Find6LetterWords).Contains(letterCount.ToString()))
            {
                result.Words = Find6LetterWords(letters, finalSource);
            }
            if (nameof(Find7LetterWords).Contains(letterCount.ToString()))
            {
                result.Words = Find7LetterWords(letters, finalSource);
            }
            if (nameof(Find8LetterWords).Contains(letterCount.ToString()))
            {
                result.Words = Find8LetterWords(letters, finalSource);
            }
            return result;
        }

        private static List<string>? Find3LetterWords(List<string> letters, List<string> source)
        {
            var result = new List<string>();
            try
            {
                var words = new List<string>();

                for (int i = 0; i < letters.Count; i++)
                {
                    for (int j = 0; j < letters.Count; j++)
                    {
                        for (int k = 0; k < letters.Count; k++)
                        {
                            words.Add(letters[i] + letters[j] + letters[k]);
                        }
                    }
                }
                words = words.Distinct().ToList();

                result = source.Where(x => words.Contains(x)).Distinct().ToList();
            }
            catch
            {

                result = null;
            }

            return result;
        }

        private static List<string>? Find4LetterWords(List<string> letters, List<string> source)
        {
            var result = new List<string>();
            try
            {
                var words = new List<string>();

                for (int i = 0; i < letters.Count; i++)
                {
                    for (int j = 0; j < letters.Count; j++)
                    {
                        for (int k = 0; k < letters.Count; k++)
                        {
                            for (int l = 0; l < letters.Count; l++)
                            {
                                words.Add(letters[i] + letters[j] + letters[k] + letters[l]);
                            }
                        }
                    }
                }
                words = words.Distinct().ToList();

                result = source.Where(x => words.Contains(x)).Distinct().ToList();

            }
            catch
            {
                result = null;
            }
            return result;
        }

        private static List<string>? Find5LetterWords(List<string> letters, List<string> source)
        {
            var result = new List<string>();
            try
            {
                var words = new List<string>();

                for (int i = 0; i < letters.Count; i++)
                {
                    for (int j = 0; j < letters.Count; j++)
                    {
                        for (int k = 0; k < letters.Count; k++)
                        {
                            for (int l = 0; l < letters.Count; l++)
                            {
                                for (int m = 0; m < letters.Count; m++)
                                {
                                    words.Add(letters[i] + letters[j] + letters[k] + letters[l] + letters[m]);
                                }
                            }
                        }
                    }
                }
                words = words.Distinct().ToList();

                result = source.Where(x => words.Contains(x)).Distinct().ToList();
            }
            catch
            {
                result = null;
            }

            return result;
        }

        private static List<string>? Find6LetterWords(List<string> letters, List<string> source)
        {
            var result = new List<string>();
            try
            {
                var words = new List<string>();

                for (int i = 0; i < letters.Count; i++)
                {
                    for (int j = 0; j < letters.Count; j++)
                    {
                        for (int k = 0; k < letters.Count; k++)
                        {
                            for (int l = 0; l < letters.Count; l++)
                            {
                                for (int m = 0; m < letters.Count; m++)
                                {
                                    for (int n = 0; n < letters.Count; n++)
                                    {
                                        words.Add(letters[i] + letters[j] + letters[k] + letters[l] + letters[m] + letters[n]);
                                    }
                                }
                            }
                        }
                    }
                }
                words = words.Distinct().ToList();

                result = source.Where(x => words.Contains(x)).Distinct().ToList();

            }
            catch
            {
                result = null;
            }
            return result;
        }

        private static List<string>? Find7LetterWords(List<string> letters, List<string> source)
        {
            var result = new List<string>();
            try
            {
                var words = new List<string>();

                for (int i = 0; i < letters.Count; i++)
                {
                    for (int j = 0; j < letters.Count; j++)
                    {
                        for (int k = 0; k < letters.Count; k++)
                        {
                            for (int l = 0; l < letters.Count; l++)
                            {
                                for (int m = 0; m < letters.Count; m++)
                                {
                                    for (int n = 0; n < letters.Count; n++)
                                    {
                                        for (int o = 0; o < letters.Count; o++)
                                        {
                                            words.Add(letters[i] + letters[j] + letters[k] + letters[l] + letters[m] + letters[n] + letters[o]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                words = words.Distinct().ToList();

                result = source.Where(x => words.Contains(x)).Distinct().ToList();

            }
            catch
            {
                result = null;
            }
            return result;
        }

        private static List<string>? Find8LetterWords(List<string> letters, List<string> source)
        {
            var result = new List<string>();
            try
            {
                var words = new List<string>();

                for (int i = 0; i < letters.Count; i++)
                {
                    for (int j = 0; j < letters.Count; j++)
                    {
                        for (int k = 0; k < letters.Count; k++)
                        {
                            for (int l = 0; l < letters.Count; l++)
                            {
                                for (int m = 0; m < letters.Count; m++)
                                {
                                    for (int n = 0; n < letters.Count; n++)
                                    {
                                        for (int o = 0; o < letters.Count; o++)
                                        {
                                            for (int p = 0; p < letters.Count; p++)
                                            {
                                                words.Add(letters[i] + letters[j] + letters[k] + letters[l] + letters[m] + letters[n] + letters[o] + letters[p]);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                words = words.Distinct().ToList();

                result = source.Where(x => words.Contains(x)).Distinct().ToList();
            }
            catch
            {
                result = null;
            }

            return result;
        }


    }
}
