namespace WordFinder.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordsController : ControllerBase
    {
        private readonly IWordService wordService;

        public WordsController(IWordService wordService)
        {
            this.wordService = wordService;
        }

        [HttpPost("Find3LetterWords")]
        public IActionResult Find3LetterWords([FromBody] InputLetterDTO dto)
        {
            return Ok(wordService.Find3LetterWords(dto));
        }

        [HttpPost("Find4LetterWords")]
        public IActionResult Find4LetterWords([FromBody] InputLetterDTO dto)
        {
            return Ok(wordService.Find4LetterWords(dto));
        }

        [HttpPost("Find5LetterWords")]
        public IActionResult Find5LetterWords([FromBody] InputLetterDTO dto)
        {
            return Ok(wordService.Find5LetterWords(dto));
        }

        [HttpPost("Find6LetterWords")]
        public IActionResult Find6LetterWords([FromBody] InputLetterDTO dto)
        {
            return Ok(wordService.Find6LetterWords(dto));
        }

        [HttpPost("Find7LetterWords")]
        public IActionResult Find7LetterWords([FromBody] InputLetterDTO dto)
        {
            return Ok(wordService.Find7LetterWords(dto));
        }

        [HttpPost("Find8LetterWords")]
        public IActionResult Find8LetterWords([FromBody] InputLetterDTO dto)
        {
            return Ok(wordService.Find8LetterWords(dto));
        }
    }
}