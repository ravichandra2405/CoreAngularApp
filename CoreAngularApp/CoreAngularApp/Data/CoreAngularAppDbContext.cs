using CoreAngularApp.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoreAngularApp.Data
{
    public class CoreAngularAppDbContext : DbContext
    {
        public CoreAngularAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
