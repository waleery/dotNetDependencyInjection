using dotNetDependencyInjection.Models;
using Microsoft.EntityFrameworkCore;

namespace dotNetDependencyInjection.Data
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
    }

}
