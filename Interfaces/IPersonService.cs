using dotNetDependencyInjection.Models;

namespace dotNetDependencyInjection.Interfaces
{
    public interface IPersonService
    {
        public IQueryable<Person> GetActivePeople();
    }
}
