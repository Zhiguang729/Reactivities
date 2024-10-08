using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    // [ApiController]
    // [Route("[controller]")]

    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;

        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] // api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities() // in ActionResult<>, we have a list of activities in the res body
        {
            return await _context.Activities.ToListAsync();
        }       

        [HttpGet("{id}")] // api/activities/{id}

        public async Task<ActionResult<Activity>> GetActivity(Guid id) // in ActionResult<>, we have a list of activities in the res body
        {
            return await _context.Activities.FindAsync(id);
        }  
    }
}

