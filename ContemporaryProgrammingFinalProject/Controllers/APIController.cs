using ContemporaryProgrammingFinalProject.Data;
using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        IFinalService ctx;
        public APIController(IFinalService context)
        {
            ctx = context;
        }
        //FavoriteFoodAPI
        [HttpGet]
        [Route("api/getfood")]
        public IActionResult GetFood()
        {
            return Ok(ctx.GetAllFood());
        }

        [HttpGet("id")]
        public IActionResult GetFood(int id)
        {
            return Ok(ctx.GetFoodById(id));
        }

        [HttpPost("api/addfood")]
        public IActionResult PostFood(FavoriteFood i)
        {
            var result = ctx.AddFood(i);
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

        [HttpPut("api/updatefood")]
        public IActionResult PutFood(FavoriteFood i)
        {
            var result = ctx.UpdateFood(i);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete("id")]
        [Route("api/deletefood")]
        public IActionResult DeleteFood(int id)
        {
            var product = ctx.GetFoodById(id);
            if (product == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveFoodById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
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
