[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
public class DadJokesController 
{
   [HttpGet()]
        public async Task<ActionResult> GetRandomJoke()
        {
            try
            {
               
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