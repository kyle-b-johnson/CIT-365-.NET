using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Week7Assignment.Data;
using Week7Assignment.Models;

namespace Week7Assignment.Pages.Entries
{
    public class IndexModel : PageModel
    {
        private readonly Week7Assignment.Data.Week7AssignmentContext _context;

        public IndexModel(Week7Assignment.Data.Week7AssignmentContext context)
        {
            _context = context;
        }

        public IList<Entry> Entry { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchNoteString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchBookString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string EntryBook { get; set; }

        public SelectList Books { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime EntryDate { get; set; }

        public SelectList Dates { get; set; }


        public async Task OnGetAsync()
        {
            IQueryable<string> bookQuery = from e in _context.Entry
                                           orderby e.Book
                                           select e.Book;

            IQueryable<DateTime> dateQuery = from e in _context.Entry
                                             orderby e.DateAdded
                                             select e.DateAdded;

            var entries = from e in _context.Entry
                          select e;
            if (!string.IsNullOrEmpty(SearchNoteString))
            {
                entries = entries.Where(s => s.Note.Contains(SearchNoteString));
            }

            if (!string.IsNullOrEmpty(SearchBookString))
            {
                entries = entries.Where(s => s.Book.Contains(SearchBookString));
            }

            Books = new SelectList(await bookQuery.Distinct().ToListAsync());

            Dates = new SelectList(await dateQuery.Distinct().ToListAsync());

            Entry = await entries.ToListAsync();
        }
    }
}
