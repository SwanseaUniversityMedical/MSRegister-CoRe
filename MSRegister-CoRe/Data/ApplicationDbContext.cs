using Microsoft.EntityFrameworkCore;
using MSRegister_CoRe.Models;

namespace MSRegister_CoRe.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Root> Root { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
    }
}
