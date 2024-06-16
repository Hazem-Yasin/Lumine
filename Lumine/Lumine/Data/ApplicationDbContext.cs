//added ef core to refrence DbContext

using Microsoft.EntityFrameworkCore;

namespace LumineWeb.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }

    }
}
