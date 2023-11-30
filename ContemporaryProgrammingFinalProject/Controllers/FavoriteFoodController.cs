using ContemporaryProgrammingFinalProject.Data;
using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FavoriteFoodController : ControllerBase
    {
        InFFService ctxFF;
        public FavoriteFoodController(InFFService context)
        {
            ctxFF = context;
        }

        //FavoriteFoodAPI
        [HttpGet]
        [Route("api/GetFood")]
        public IActionResult GetFood()
        {
            return Ok(ctxFF.GetAllFood());
        }

        [HttpGet]
		[Route("api/GetFoodByID")]
		public IActionResult GetFood(int id)
        {
            var result = ctxFF.GetFoodById(id);

            if (result == null)
            {
                return Ok(ctxFF.GetAllFood().Take(5));
            }

            return Ok(ctxFF.GetFoodById(id));
        }

        [HttpPost]
		[Route("api/AddFood")]
		public IActionResult PostFood(FavoriteFood i)
        {
            var result = ctxFF.AddFood(i);
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
		[Route("api/UpdateFood")]
		public IActionResult PutFood(FavoriteFood i)
        {
            var result = ctxFF.UpdateFood(i);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete]
		[Route("api/DeleteFood")]
		public IActionResult DeleteFood(int id)
        {
			var data = ctxFF.GetFoodById(id);
			if (data == null)
			{
				return NotFound(id);
			}
			var result = ctxFF.RemoveFoodById(id);
			if (result == 0)
			{
				return StatusCode(500, "An error occured while processing your request");
			}
			return Ok();
		}

    }
}
