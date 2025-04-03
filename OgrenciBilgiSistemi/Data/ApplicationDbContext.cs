using Microsoft.EntityFrameworkCore;
using OgrenciBilgiSistemi.Models;

namespace OgrenciBilgiSistemi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
