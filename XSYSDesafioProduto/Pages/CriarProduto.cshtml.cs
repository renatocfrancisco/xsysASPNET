using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using XSYSDesafioProduto.Context;
using XSYSDesafioProduto.Models;

namespace XSYSDesafioProduto.Pages
{
    public class CriarProdutoModel : PageModel
    {
        private readonly XSYSDesafioProduto.Context.ProdutoContext _context;

        public CriarProdutoModel(XSYSDesafioProduto.Context.ProdutoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Produto Produto { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produtos.Add(Produto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
