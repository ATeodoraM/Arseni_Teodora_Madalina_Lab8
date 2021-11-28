using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Arseni_Teodora_Madalina_Lab8.Data;
using Arseni_Teodora_Madalina_Lab8.Models;

namespace Arseni_Teodora_Madalina_Lab8.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Arseni_Teodora_Madalina_Lab8.Data.Arseni_Teodora_Madalina_Lab8Context _context;

        public CreateModel(Arseni_Teodora_Madalina_Lab8.Data.Arseni_Teodora_Madalina_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
