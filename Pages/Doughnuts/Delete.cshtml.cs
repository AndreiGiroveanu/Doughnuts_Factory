using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DoughnutsFactory.Data;
using DoughnutsFactory.Models;

namespace DoughnutsFactory.Pages.Doughnuts
{
    public class DeleteModel : PageModel
    {
        private readonly DoughnutsFactory.Data.DoughnutsFactoryContext _context;

        public DeleteModel(DoughnutsFactory.Data.DoughnutsFactoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Doughnut Doughnut { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Doughnut = await _context.Doughnuts.FirstOrDefaultAsync(m => m.ID == id);

            if (Doughnut == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Doughnut = await _context.Doughnuts.FindAsync(id);

            if (Doughnut != null)
            {
                _context.Doughnuts.Remove(Doughnut);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
