using System;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using DgKala.Models.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DgKala.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryApiController : ControllerBase
    {
        private DgkalaContext _context;

        public CategoryApiController(DgkalaContext context)
        {
            _context = context;
        }
        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search(string filter = "") 
        {
            try 
            {
                string term = HttpContext.Request.Query["filter"].ToString();

                var categoryTitle = _context.Categories.Where(c => c.CategoryTitle.Contains(term))
                    .Select(c => c.CategoryTitle).ToList();
                return Ok(categoryTitle);
            }
            catch
            {
                return BadRequest();
            }
        }
      
    }
}