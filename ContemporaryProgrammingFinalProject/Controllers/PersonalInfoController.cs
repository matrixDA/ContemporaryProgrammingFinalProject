using ContemporaryProgrammingFinalProject.Data;
using ContemporaryProgrammingFinalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonalInfoController : ControllerBase
    {
        InPIService ctxPI;
        public PersonalInfoController(InPIService context)
        {
			ctxPI = context;
        }

		//PersonalInfoAPI
		[HttpGet]
        [Route("api/GetInfo")]
        public IActionResult GetInfo()
        {
            return Ok(ctxPI.GetAllInfo());
        }

        [HttpGet]
		[Route("api/GetInfoByID")]
		public IActionResult GetInfo(int id)
        {
            var result = ctxPI.GetInfoById(id);

            if (result == null)
            {
                return Ok(ctxPI.GetAllInfo().Take(5));
            }
            return Ok(ctxPI.GetInfoById(id));
        }

        [HttpPost]
		[Route("api/AddInfo")]
		public IActionResult PostFood(PersonalInfo i)
        {
            var result = ctxPI.AddInfo(i);
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
		[Route("api/UpdateInfo")]
		public IActionResult PutFood(PersonalInfo i)
        {
            var result = ctxPI.UpdateInfo(i);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete]
		[Route("api/DeleteInfo")]
		public IActionResult DeleteInfo(int id)
        {
			var data = ctxPI.GetInfoById(id);
			if (data == null)
			{
				return NotFound(id);
			}
			var result = ctxPI.RemoveInfoById(id);
			if (result == 0)
			{
				return StatusCode(500, "An error occured while processing your request");
			}
			return Ok();
		}

    }
}
