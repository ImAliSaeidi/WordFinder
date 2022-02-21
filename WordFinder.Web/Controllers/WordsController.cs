namespace WordFinder.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WordsController : ControllerBase
    {
        private readonly IWordService wordService;

        public WordsController(IWordService wordService)
        {
            this.wordService = wordService;
        }

        [HttpPost]
        public IActionResult FindWords([FromBody] InputLetterDTO dto)
        {
            return Ok(wordService.FindWords(dto));
        }

    }
}