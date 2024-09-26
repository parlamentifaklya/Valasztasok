using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Valasztasok.Models;

namespace Valasztasok.Pages
{
    public class PartokListazasModel : PageModel
    {
        private readonly Valasztasok.Models.ValasztasDbContext _context;

        public PartokListazasModel(Valasztasok.Models.ValasztasDbContext context)
        {
            _context = context;
        }

        public IList<Part> Part { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Part = await _context.Partok.ToListAsync();
        }
    }
}
