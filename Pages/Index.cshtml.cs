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
            People = _context.Person.ToList();
        }
    }
}