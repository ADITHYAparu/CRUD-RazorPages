using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDWithRazorPages.DAL;
using CRUDWithRazorPages.Models;

namespace CRUDWithRazorPages.Pages.ProductMaster
{
    public class DetailsModel : PageModel
    {
        private readonly CRUDWithRazorPages.DAL.AppDbContext _context;

        public DetailsModel(CRUDWithRazorPages.DAL.AppDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }
    }
}
