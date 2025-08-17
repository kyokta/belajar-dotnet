using Microsoft.EntityFrameworkCore;
using BelajarCRUD.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BelajarCRUD.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}