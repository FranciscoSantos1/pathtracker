using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PathTracker.Api.Data;
using PathTracker.Api.Models;

namespace PathTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ApplicationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Applications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Application>>> GetApplications()
        {
            return await _context.Applications.ToListAsync();
        }

        // GET: api/Applications/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Application>> GetApplication(int id)
        {
            var application = await _context.Applications.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }
            return application;
        }


        // POST: api/Applications
        [HttpPost]
        public async Task<ActionResult<Application>> CreateApplication(Application application)
        {
            _context.Applications.Add(application);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetApplication), new { id = application.Id }, application);
        }

        // PUT: api/Applications/1
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApplication(int id, Application application)
        {
            if (id != application.Id)
            {
                return BadRequest();
            }

            _context.Entry(application).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // DELETE: api/applications/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplication(int id)
        {
            var app = await _context.Applications.FindAsync(id);
            if (app == null) return NotFound();

            _context.Applications.Remove(app);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }

}