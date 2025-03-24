using Bookstore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookDbContext _context;
        public BookController(BookDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetBooks")]
        public IActionResult GetBooks()
        {
            var query = _context.Books.AsQueryable();
            
            var bookList = query.ToList();
            
            return Ok(bookList);
        }
    }
}
