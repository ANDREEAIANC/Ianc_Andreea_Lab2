using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ianc_Andreea_Lab2.Data;
using Ianc_Andreea_Lab2.Models;

namespace Ianc_Andreea_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Ianc_Andreea_Lab2.Data.Ianc_Andreea_Lab2Context _context;

        public IndexModel(Ianc_Andreea_Lab2.Data.Ianc_Andreea_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .ToListAsync();
            }
        }
    }
}
