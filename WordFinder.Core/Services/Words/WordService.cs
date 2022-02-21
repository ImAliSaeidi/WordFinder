namespace WordFinder.Core.Services.Words
{
    public class WordService : IWordService
    {
        public OutputWordDTO Find3LetterWords(InputLetterDTO dto)
        {
            var result = new OutputWordDTO();

            var path = Directory.GetCurrentDirectory() + "/words.txt";
            var source = File.ReadAllText(path).Split('\n').ToList();
            var finalSource = new List<string>();
            foreach (var word in source)
            {
                foreach (var letter in dto.Letters)
                {
                    if (word.Contains(letter))
                    {
                        finalSource.Add(word);
                    }
                }
            }
            finalSource = finalSource.Where(x => x.Length == 3).ToList();
            var letters = dto.Letters.Split("-").ToList();
            result.Words = FindWords3(letters, finalSource);
            return result;
        }

        public OutputWordDTO Find4LetterWords(InputLetterDTO dto)
        {
            var result = new OutputWordDTO();

            var path = Directory.GetCurrentDirectory() + "/words.txt";
            var source = File.ReadAllText(path).Split('\n').ToList();
            var finalSource = new List<string>();
            foreach (var word in source)
            {
                foreach (var letter in dto.Letters)
                {
                    if (word.Contains(letter))
                    {
                        finalSource.Add(word);
                    }
                }
            }
            finalSource = finalSource.Where(x => x.Length == 4).ToList();
            var letters = dto.Letters.Split("-").ToList();
            result.Words = FindWords4(letters, finalSource);
            return result;
        }

        public OutputWordDTO Find5LetterWords(InputLetterDTO dto)
        {
            var result = new OutputWordDTO();

            var path = Directory.GetCurrentDirectory() + "/words.txt";
            var source = File.ReadAllText(path).Split('\n').ToList();
            var finalSource = new List<string>();
            foreach (var word in source)
            {
                foreach (var letter in dto.Letters)
                {
                    if (word.Contains(letter))
                    {
                        finalSource.Add(word);
                    }
                }
            }
            finalSource = finalSource.Where(x => x.Length == 5).ToList();
            var letters = dto.Letters.Split("-").ToList();
            result.Words = FindWords5(letters, finalSource);
            return result;
        }

        public OutputWordDTO Find6LetterWords(InputLetterDTO dto)
        {
            var result = new OutputWordDTO();

            var path = Directory.GetCurrentDirectory() + "/words.txt";
            var source = File.ReadAllText(path).Split('\n').ToList();
            var finalSource = new List<string>();
            foreach (var word in source)
            {
                foreach (var letter in dto.Letters)
                {
                    if (word.Contains(letter))
                    {
                        finalSource.Add(word);
                    }
                }
            }
            finalSource = finalSource.Where(x => x.Length == 6).ToList();
            var letters = dto.Letters.Split("-").ToList();
            result.Words = FindWords6(letters, finalSource);
            return result;
        }

        public OutputWordDTO Find7LetterWords(InputLetterDTO dto)
        {
            var result = new OutputWordDTO();

            var path = Directory.GetCurrentDirectory() + "/words.txt";
            var source = File.ReadAllText(path).Split('\n').ToList();
            var finalSource = new List<string>();
            foreach (var word in source)
            {
                foreach (var letter in dto.Letters)
                {
                    if (word.Contains(letter))
                    {
                        finalSource.Add(word);
                    }
                }
            }
            finalSource = finalSource.Where(x => x.Length == 7).ToList();
            var letters = dto.Letters.Split("-").ToList();
            result.Words = FindWords7(letters, finalSource);
            return result;
        }

        public OutputWordDTO Find8LetterWords(InputLetterDTO dto)
        {
            var result = new OutputWordDTO();

            var path = Directory.GetCurrentDirectory() + "/words.txt";
            var source = File.ReadAllText(path).Split('\n').ToList();
            var finalSource = new List<string>();
            foreach (var word in source)
            {
                foreach (var letter in dto.Letters)
                {
                    if (word.Contains(letter))
                    {
                        finalSource.Add(word);
                    }
                }
            }
            finalSource = finalSource.Where(x => x.Length == 8).ToList();
            var letters = dto.Letters.Split("-").ToList();
            result.Words = FindWords8(letters, finalSource);
            return result;
        }

        private static List<string>? FindWords3(List<string> letters, List<string> source)
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

        private static List<string>? FindWords4(List<string> letters, List<string> source)
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

        private static List<string>? FindWords5(List<string> letters, List<string> source)
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

        private static List<string>? FindWords6(List<string> letters, List<string> source)
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

        private static List<string>? FindWords7(List<string> letters, List<string> source)
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

        private static List<string>? FindWords8(List<string> letters, List<string> source)
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
