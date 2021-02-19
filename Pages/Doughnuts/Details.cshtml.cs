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
    public class DetailsModel : PageModel
    {
        private readonly DoughnutsFactory.Data.DoughnutsFactoryContext _context;

        public DetailsModel(DoughnutsFactory.Data.DoughnutsFactoryContext context)
        {
            _context = context;
        }

        public Doughnut Doughnuts { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Doughnuts = await _context.Doughnuts.FirstOrDefaultAsync(m => m.ID == id);

            if (Doughnuts == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}