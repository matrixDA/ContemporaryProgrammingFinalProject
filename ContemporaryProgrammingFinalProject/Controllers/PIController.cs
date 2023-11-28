using Microsoft.AspNetCore.Mvc;
using ContemporaryProgrammingFinalProject.Models;
using ContemporaryProgrammingFinalProject.Data;

namespace ContemporaryProgrammingFinalProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PIController : Controller
    {
        IFinalService ctx;
        public PIController(IFinalService context)
        {
            ctx = context;
        }

        [HttpGet]
        [Route("api/getproducts")]
        public IActionResult Get()
        {
            return Ok(ctx.GetAllInfo());
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetInfoById(id));
        }

        [HttpPost]
        public IActionResult Post(PersonalInfo p)
        {
            var result = ctx.AddInfo(p);
            if (result == null)
            {
                return StatusCode(500, "A Product with this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(PersonalInfo p)
        {
            var result = ctx.UpdateInfo(p);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete("id")]
        [Route("api/delete")]
        public IActionResult Delete(int id)
        {
            var product = ctx.GetInfoById(id);
            if (product == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveInfoById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}
