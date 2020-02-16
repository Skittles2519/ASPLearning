using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPLearning.Data;
using ASPLearning.Models;

namespace ASPLearning
{
    public class IndexModel : PageModel
    {
        private readonly ASPLearning.Data.ASPLearningContext _context;

        public IndexModel(ASPLearning.Data.ASPLearningContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
