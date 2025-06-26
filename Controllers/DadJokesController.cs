[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
    public class DadJokesController{

        private readonly DadJokesService _dadJokesService;

        public DadJokesController(DadJokesService dadJokesService)
        {
            _dadJokesService = dadJokesService;
        }
      
      [HttpGet()]
        public async Task<ActionResult> GetRandomJoke()
        {
            
            try
            {
                var jokes = await _dadJokesService.GetRandomJoke();
                return Ok(jokes);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

         [HttpGet("{term}")]
        public async Task<ActionResult> SearchJoke(string term)
        {
            try
            {
                
                
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }


    }