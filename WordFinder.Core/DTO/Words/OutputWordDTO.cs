namespace WordFinder.Core.DTO.Words
{
    public class OutputWordDTO
    {
        public OutputWordDTO()
        {
            Words = new List<string>();
        }
        public List<string>? Words { get; set; }
    }
}
