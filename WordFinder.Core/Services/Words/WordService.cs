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
            result.Words = FindWords3(dto, finalSource);
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
            result.Words = FindWords4(dto, finalSource);
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
            result.Words = FindWords5(dto, finalSource);
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
            result.Words = FindWords6(dto, finalSource);
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
            result.Words = FindWords7(dto, finalSource);
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
            result.Words = FindWords8(dto, finalSource);
            return result;
        }

        private static List<string>? FindWords3(InputLetterDTO dto, List<string> source)
        {
            var result = new List<string>();
            try
            {
                var words = new List<string>();

                for (int i = 0; i < dto.Letters.Count; i++)
                {
                    for (int j = 0; j < dto.Letters.Count; j++)
                    {
                        for (int k = 0; k < dto.Letters.Count; k++)
                        {
                            words.Add(dto.Letters[i] + dto.Letters[j] + dto.Letters[k]);
                        }
                    }
                }
                words = words.Distinct().ToList();

                foreach (var word in words)
                {
                    if (source.Contains(word))
                    {
                        result.Add(word);
                    }
                }
            }
            catch
            {

                result = null;
            }

            return result;
        }

        private static List<string>? FindWords4(InputLetterDTO dto, List<string> source)
        {
            var result = new List<string>();
            try
            {
                var words = new List<string>();

                for (int i = 0; i < dto.Letters.Count; i++)
                {
                    for (int j = 0; j < dto.Letters.Count; j++)
                    {
                        for (int k = 0; k < dto.Letters.Count; k++)
                        {
                            for (int l = 0; l < dto.Letters.Count; l++)
                            {
                                words.Add(dto.Letters[i] + dto.Letters[j] + dto.Letters[k] + dto.Letters[l]);
                            }
                        }
                    }
                }
                words = words.Distinct().ToList();

                foreach (var word in words)
                {
                    if (source.Contains(word))
                    {
                        result.Add(word);
                    }
                }

            }
            catch
            {
                result = null;
            }
            return result;
        }

        private static List<string>? FindWords5(InputLetterDTO dto, List<string> source)
        {
            var result = new List<string>();
            try
            {
                var words = new List<string>();

                for (int i = 0; i < dto.Letters.Count; i++)
                {
                    for (int j = 0; j < dto.Letters.Count; j++)
                    {
                        for (int k = 0; k < dto.Letters.Count; k++)
                        {
                            for (int l = 0; l < dto.Letters.Count; l++)
                            {
                                for (int m = 0; m < dto.Letters.Count; m++)
                                {
                                    words.Add(dto.Letters[i] + dto.Letters[j] + dto.Letters[k] + dto.Letters[l] + dto.Letters[m]);
                                }
                            }
                        }
                    }
                }
                words = words.Distinct().ToList();

                foreach (var word in words)
                {
                    if (source.Contains(word))
                    {
                        result.Add(word);
                    }
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

        private static List<string>? FindWords6(InputLetterDTO dto, List<string> source)
        {
            var result = new List<string>();
            try
            {
                var words = new List<string>();

                for (int i = 0; i < dto.Letters.Count; i++)
                {
                    for (int j = 0; j < dto.Letters.Count; j++)
                    {
                        for (int k = 0; k < dto.Letters.Count; k++)
                        {
                            for (int l = 0; l < dto.Letters.Count; l++)
                            {
                                for (int m = 0; m < dto.Letters.Count; m++)
                                {
                                    for (int n = 0; n < dto.Letters.Count; n++)
                                    {
                                        words.Add(dto.Letters[i] + dto.Letters[j] + dto.Letters[k] + dto.Letters[l] + dto.Letters[m] + dto.Letters[n]);
                                    }
                                }
                            }
                        }
                    }
                }
                words = words.Distinct().ToList();

                foreach (var word in words)
                {
                    if (source.Contains(word))
                    {
                        result.Add(word);
                    }
                }

            }
            catch
            {
                result = null;
            }
            return result;
        }

        private static List<string>? FindWords7(InputLetterDTO dto, List<string> source)
        {
            var result = new List<string>();
            try
            {
                var words = new List<string>();

                for (int i = 0; i < dto.Letters.Count; i++)
                {
                    for (int j = 0; j < dto.Letters.Count; j++)
                    {
                        for (int k = 0; k < dto.Letters.Count; k++)
                        {
                            for (int l = 0; l < dto.Letters.Count; l++)
                            {
                                for (int m = 0; m < dto.Letters.Count; m++)
                                {
                                    for (int n = 0; n < dto.Letters.Count; n++)
                                    {
                                        for (int o = 0; o < dto.Letters.Count; o++)
                                        {
                                            words.Add(dto.Letters[i] + dto.Letters[j] + dto.Letters[k] + dto.Letters[l] + dto.Letters[m] + dto.Letters[n] + dto.Letters[o]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                words = words.Distinct().ToList();

                foreach (var word in words)
                {
                    if (source.Contains(word))
                    {
                        result.Add(word);
                    }
                }

            }
            catch
            {
                result = null;
            }
            return result;
        }

        private static List<string>? FindWords8(InputLetterDTO dto, List<string> source)
        {
            var result = new List<string>();
            try
            {
                var words = new List<string>();

                for (int i = 0; i < dto.Letters.Count; i++)
                {
                    for (int j = 0; j < dto.Letters.Count; j++)
                    {
                        for (int k = 0; k < dto.Letters.Count; k++)
                        {
                            for (int l = 0; l < dto.Letters.Count; l++)
                            {
                                for (int m = 0; m < dto.Letters.Count; m++)
                                {
                                    for (int n = 0; n < dto.Letters.Count; n++)
                                    {
                                        for (int o = 0; o < dto.Letters.Count; o++)
                                        {
                                            for (int p = 0; p < dto.Letters.Count; p++)
                                            {
                                                words.Add(dto.Letters[i] + dto.Letters[j] + dto.Letters[k] + dto.Letters[l] + dto.Letters[m] + dto.Letters[n] + dto.Letters[o] + dto.Letters[p]);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                words = words.Distinct().ToList();

                foreach (var word in words)
                {
                    if (source.Contains(word))
                    {
                        result.Add(word);
                    }
                }
            }
            catch
            {
                result = null;
            }

            return result;
        }

    }
}
