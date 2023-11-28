using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContemporaryProgrammingFinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HController : ControllerBase
    {
        IItemService ctx;
        public ItemAPIController(IItemService context)
        {
            ctx = context;
        }
        [HttpGet]
        [Route("api/getitems")]
        public IActionResult Get()
        {
            return Ok(ctx.GetItems());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetItemById(id));
        }

        [HttpPost("api/additem")]
        public IActionResult Post(Item i)
        {
            var result = ctx.AddItem(i);
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

        [HttpPut("api/updateitem")]
        public IActionResult Put(Item i)
        {
            var result = ctx.UpdateItem(i);
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
            var product = ctx.GetItemById(id);
            if (product == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveItemById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}
}
