using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("v1/categories")]
    public class CategoryController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Get([FromServices] DataContext context)
        {

            var categories = await context.Categories.ToListAsync();
            return categories;
        }

        [HttpPost]
        public async Task<ActionResult<Category>> AddCategory(
            [FromServices] DataContext context,
            [FromBody] Category model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            context.Categories.Add(model);
            await context.SaveChangesAsync();
            return model;

        }

    }
}