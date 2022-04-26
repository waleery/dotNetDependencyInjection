using dotNetDependencyInjection.ViewModels.Person;

namespace dotNetDependencyInjection.Interfaces
{
    public interface IPersonService
    {
        ListPersonForListVM GetPeopleForList();
    }
}
