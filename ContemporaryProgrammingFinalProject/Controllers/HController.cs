using ContemporaryProgrammingFinalProject.Data;
using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HController : ControllerBase
    {
        IFinalService ctx;
        public HController(IFinalService context)
        {
            ctx = context;
        }

        //HobbyAPI
        [HttpGet]
        [Route("api/gethobby")]
        public IActionResult GetHobby()
        {
            return Ok(ctx.GetAllHobbies());
        }

        [HttpGet("id")]
        public IActionResult GetHobby(int id)
        {
            return Ok(ctx.GetHobbyById(id));
        }

        [HttpPost("api/addhobby")]
        public IActionResult Post(Hobbies i)
        {
            var result = ctx.AddHobby(i);
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

        [HttpPut("api/updatehobby")]
        public IActionResult Put(Hobbies i)
        {
            var result = ctx.UpdateHobbies(i);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete("id")]
        [Route("api/deletehobby")]
        public IActionResult Delete(int id)
        {
            var product = ctx.GetHobbyById(id);
            if (product == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveHobbyById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}
