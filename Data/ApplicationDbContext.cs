using Microsoft.EntityFrameworkCore;
using CodeFirstDemo.Models;
using Microsoft.Identity.Client;

namespace CodeFirstDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {

        }
        public DbSet <Employee > Employees {get;set;}
    }
}
