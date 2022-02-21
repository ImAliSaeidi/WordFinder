namespace WordFinder.Core.IServices.Words
{
    public interface IWordService
    {
        OutputWordDTO FindWords(InputLetterDTO dto, int letterCount);
    }
}
