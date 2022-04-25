using dotNetDependencyInjection.Data;
using dotNetDependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotNetDependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext _context;

        public IList<Person> People { get; set; }

        public IndexModel(ILogger<IndexModel> logger, PeopleContext context)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
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