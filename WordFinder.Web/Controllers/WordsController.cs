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

        [HttpPost]
        public IActionResult Find3LetterWords([FromBody] InputLetterDTO dto)
        {
            return Ok(wordService.FindWords(dto, dto.LetterCount));
        }
    }
}