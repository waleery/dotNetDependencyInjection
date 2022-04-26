using dotNetDependencyInjection.Data;
using dotNetDependencyInjection.Interfaces;
using dotNetDependencyInjection.Models;
using dotNetDependencyInjection.ViewModels.Person;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotNetDependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext _context;
        private readonly IPersonService _personService;
        public ListPersonForListVM Records { get; set; }



        public IList<Person> People { get; set; }

        public IndexModel(ILogger<IndexModel> logger, PeopleContext context, IPersonService personService)
        {
            _personService = personService;
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Records = _personService.GetPeopleForList();
            People = _context.Person.Where(p => p.FirstName == "Patryk").ToList();
        }


        [BindProperty]
        public Person Person { get; set; }
        public IActionResult OnPost()
        {
            People = _context.Person.ToList();
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Person.Add(Person);
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }

    }
}