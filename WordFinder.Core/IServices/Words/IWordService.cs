namespace WordFinder.Core.IServices.Words
{
    public interface IWordService
    {
        OutputWordDTO Find3LetterWords(InputLetterDTO dto);
        OutputWordDTO Find4LetterWords(InputLetterDTO dto);
        OutputWordDTO Find5LetterWords(InputLetterDTO dto);
        OutputWordDTO Find6LetterWords(InputLetterDTO dto);
        OutputWordDTO Find7LetterWords(InputLetterDTO dto);
        OutputWordDTO Find8LetterWords(InputLetterDTO dto);
    }
}
