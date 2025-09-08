using Microsoft.EntityFrameworkCore;
using PathTracker.Api.Models;

namespace PathTracker.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Application> Applications { get; set;}
    }
        }