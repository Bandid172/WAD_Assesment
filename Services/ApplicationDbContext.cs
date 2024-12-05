using ContactsManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsManager.Services
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }
    }
}
