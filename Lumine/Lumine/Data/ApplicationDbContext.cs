//added ef core to refrence DbContext

using LumineWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace LumineWeb.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }

        public DbSet<Category> Categories { get; set; }

    }
}
