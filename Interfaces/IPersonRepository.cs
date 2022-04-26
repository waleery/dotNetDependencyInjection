using dotNetDependencyInjection.Models;

namespace dotNetDependencyInjection.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<Person> GetAllActivePeople();
    }

}
