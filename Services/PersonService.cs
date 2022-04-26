using dotNetDependencyInjection.Data;
using dotNetDependencyInjection.Interfaces;
using dotNetDependencyInjection.Models;

namespace dotNetDependencyInjection.Services
{
    public class PersonService : IPersonService
    {
        private readonly PeopleContext _context;

        public PersonService(PeopleContext context)
        {
            _context = context;
        }

        public IQueryable<Person> GetActivePeople()
        {
            return _context.Person.Where(p => p.IsActive);
        }

    }
}
