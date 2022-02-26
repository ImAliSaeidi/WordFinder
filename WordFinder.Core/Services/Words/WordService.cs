using System.Text.RegularExpressions;

namespace WordFinder.Core.Services.Words
{
    public class WordService : IWordService
    {
        public OutputWordDTO FindWords(InputLetterDTO dto)
        {
            var result = new OutputWordDTO();
            var path = "";
            var source = new List<string>();
            if (dto.IsEnglish == true)
            {
                path = Directory.GetCurrentDirectory() + "/english-words.txt";
                source = File.ReadAllText(path)
                    .Replace("\n", "")
                    .Split("\r")
                    .Where(s => s.Length >= 3 && s.Length <= 8)
                    .ToList();
            }
            else
            {
                path = Directory.GetCurrentDirectory() + "/persian-words.txt";
                source = File.ReadAllText(path)
                    .Split("\n")
                    .Where(s => s.Length >= 3 && s.Length <= 8)
                    .ToList();
            }

            var finalSource = new List<string>();
            var letters = dto.Letters.Replace("-", "");


            var sample = string.Format("[{0}]", letters);
            var repeat = Enumerable.Repeat(sample, dto.LetterCount).ToList();
            var repeatToString = "";
            foreach (var item in repeat)
            {
                repeatToString += item;
            }
            var regex = "^" + repeatToString + "$";

            finalSource = source.Where(s => s.Length == dto.LetterCount && Regex.IsMatch(s, regex)).Distinct().ToList();


            foreach (var item in finalSource)
            {
                result.Words.Add(item);
            }

            return result;
        }

    }
}
