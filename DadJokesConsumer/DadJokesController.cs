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
}