using dotNetDependencyInjection.Data;
using dotNetDependencyInjection.Interfaces;
using dotNetDependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotNetDependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        private readonly IPersonService _personService;

        private readonly PeopleContext _context;


        public IQueryable<Person> Records { get; set; }

        public IList<Person> People { get; set; }

        public IndexModel(ILogger<IndexModel> logger, PeopleContext context, IPersonService personService)
        {
            _context = context;
            _logger = logger;
            _personService = personService;
        }

        public void OnGet()
        {
            People = _context.Person.Where(p => p.FirstName == "Patryk").ToList();
            Records = _personService.GetActivePeople();
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