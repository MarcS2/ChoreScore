
namespace ChoreScore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChoresController : ControllerBase
    {
        private readonly ChoresService _choresService;

        public ChoresController(ChoresService choresService)
        {
            _choresService = choresService;
        }

        [HttpGet]
        public ActionResult<List<Chore>> GetChores()
        {
            try
            {
                List<Chore> chores = _choresService.GetChores();
                return Ok(chores);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("{choreId}")]
        public ActionResult<Chore> GetChoreById(int choreId)
        {
            try
            {
                Chore chore = _choresService.GetChoreById(choreId);
                return Ok(chore);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
        [HttpDelete("{choreId}")]
        public ActionResult<string> DestroyChore(int choreId)
        {
            try
            {
                string message = _choresService.DestroyChore(choreId);
                return Ok(message);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}