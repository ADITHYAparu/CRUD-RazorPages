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
    public class IndexModel : PageModel
    {
        private readonly CRUDWithRazorPages.DAL.AppDbContext _context;

        public IndexModel(CRUDWithRazorPages.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
