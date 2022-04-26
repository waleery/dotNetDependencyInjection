using dotNetDependencyInjection.Interfaces;
using dotNetDependencyInjection.ViewModels.Person;

namespace dotNetDependencyInjection.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepo;

        public PersonService(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public ListPersonForListVM GetPeopleForList()
        {
            throw new NotImplementedException();
        }

    }
}
