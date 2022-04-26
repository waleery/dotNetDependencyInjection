using dotNetDependencyInjection.Models;
using Microsoft.EntityFrameworkCore;

namespace dotNetDependencyInjection.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext (DbContextOptions options) : base(options) { }

        public DbSet<Person> Person { get; set; }

        public DbSet<Address> Address { get; set; }

    }

}
