﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Week7Assignment.Data;
using Week7Assignment.Models;

namespace Week7Assignment.Pages.Entries
{
    public class CreateModel : PageModel
    {
        private readonly Week7Assignment.Data.Week7AssignmentContext _context;

        public CreateModel(Week7Assignment.Data.Week7AssignmentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Entry Entry { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Entry.Add(Entry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
