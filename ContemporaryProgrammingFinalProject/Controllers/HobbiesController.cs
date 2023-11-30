using ContemporaryProgrammingFinalProject.Data;
using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HobbiesController : ControllerBase
    {
        InHService ctxH;
        public HobbiesController(InHService context)
        {
			ctxH = context;
        }

        //HobbiesAPI
        [HttpGet]
        [Route("api/GetHobby")]
        public IActionResult GetHobby()
        {
            return Ok(ctxH.GetAllHobby());
        }

        [HttpGet]
		[Route("api/GetHobbyByID")]
		public IActionResult GetHobby(int id)
        {
            var result = ctxH.GetHobbyById(id);

            if (result == null)
            {
                return Ok(ctxH.GetAllHobby().Take(5));
            }
            return Ok(ctxH.GetHobbyById(id));
        }

        [HttpPost]
		[Route("api/AddHobby")]
		public IActionResult PostHobby(Hobbies i)
        {
            var result = ctxH.AddHobby(i);
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
		[Route("api/UpdateHobby")]
		public IActionResult PutHobby(Hobbies i)
        {
            var result = ctxH.UpdateHobby(i);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete]
		[Route("api/DeleteHobby")]
		public IActionResult DeleteHobby(int id)
        {
			var data = ctxH.GetHobbyById(id);
			if (data == null)
			{
				return NotFound(id);
			}
			var result = ctxH.RemoveHobbyById(id);
			if (result == 0)
			{
				return StatusCode(500, "An error occured while processing your request");
			}
			return Ok();
		}

    }
}
