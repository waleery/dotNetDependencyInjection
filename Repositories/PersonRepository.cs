using dotNetDependencyInjection.Data;
using dotNetDependencyInjection.Interfaces;
using dotNetDependencyInjection.Models;

namespace dotNetDependencyInjection.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PeopleContext _context;

        public PersonRepository(PeopleContext context)
        {
            _context = context;
        }


        public IQueryable<Person> GetAllActivePeople()
        {
            return _context.Person.Where(p => p.IsActive);
        }
    }
}
