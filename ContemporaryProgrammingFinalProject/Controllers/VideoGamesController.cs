using ContemporaryProgrammingFinalProject.Data;
using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        InVGService ctxVG;
        public VideoGamesController(InVGService context)
        {
            ctxVG = context;
        }

		//VideoGamesAPI
		[HttpGet]
        [Route("api/GetGame")]
        public IActionResult GetGame()
        {
            return Ok(ctxVG.GetAllGame());
        }

        [HttpGet]
		[Route("api/GetGameByID")]
		public IActionResult GetGame(int id)
        {
            var result = ctxVG.GetGameById(id);

            if (result == null)
            {
                return Ok(ctxVG.GetAllGame().Take(5));
            }
            return Ok(ctxVG.GetGameById(id));
        }

        [HttpPost]
		[Route("api/AddGame")]
		public IActionResult PostGame(VideoGames i)
        {
            var result = ctxVG.AddGame(i);
            if (result == null)
            {
                return StatusCode(500, "An item with this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPut]
		[Route("api/UpdateGame")]
		public IActionResult PutGame(VideoGames i)
        {
            var result = ctxVG.UpdateGame(i);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete]
		[Route("api/DeleteGame")]
		public IActionResult DeleteGame(int id)
        {
			var data = ctxVG.GetGameById(id);
			if (data == null)
			{
				return NotFound(id);
			}
			var result = ctxVG.RemoveGameById(id);
			if (result == 0)
			{
				return StatusCode(500, "An error occured while processing your request");
			}
			return Ok();
		}

    }
}
