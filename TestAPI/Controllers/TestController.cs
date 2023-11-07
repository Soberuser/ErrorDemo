using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly TestContext _context;

        public TestController(TestContext context)
        {
            _context = context;
        }

        // GET: api/Test
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            if (_context.Customers == null)
            {
                return NotFound();
            }
            return await _context.Customers.Include(o=>o.Managers).ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Manager>>> GetManagers()
        {
            if (_context.Customers == null)
            {
                return NotFound();
            }
            return await _context.Managers.Include(o => o.Customers).ToListAsync();
        }
    }
}
