using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Week7Assignment.Data;
using Week7Assignment.Models;

namespace Week7Assignment.Pages.Entries
{
    public class DetailsModel : PageModel
    {
        private readonly Week7Assignment.Data.Week7AssignmentContext _context;

        public DetailsModel(Week7Assignment.Data.Week7AssignmentContext context)
        {
            _context = context;
        }

        public Entry Entry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Entry = await _context.Entry.FirstOrDefaultAsync(m => m.ID == id);

            if (Entry == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
