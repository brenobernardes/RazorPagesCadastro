using Microsoft.AspNetCore.Mvc;
using RazorPagesCadastro.Context;
using RazorPagesCadastro.Models;
using System.Collections.Generic;
using System.Linq;

namespace PersonApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly MyDbContext _context;

        public PeopleController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Teacher>> GetPeople()
        {
            var people = _context.Teachers.ToList();
            return Ok(people);
        }
    }
}
