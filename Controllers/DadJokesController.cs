using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
    public class DadJokesController : ControllerBase {

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
                var joke = await _dadJokesService.GetRandomJoke();
                return Ok(joke);
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
                var jokes = await _dadJokesService.SearchJoke(term);
                
                return Ok(jokes);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }  


    }