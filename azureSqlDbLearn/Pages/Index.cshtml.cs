using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azureSqlDbLearn.Data;

namespace azureSqlDbLearn.Pages
{
    public class IndexModel : PageModel
    {
        private readonly azureSqlDbLearn.Data.AppDbContext _context;

        public IndexModel(azureSqlDbLearn.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
