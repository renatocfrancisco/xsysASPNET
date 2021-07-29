using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using XSYSDesafioProduto.Context;
using XSYSDesafioProduto.Models;

namespace XSYSDesafioProduto.Pages
{
    public class ListaProdutosModel : PageModel
    {
        private readonly XSYSDesafioProduto.Context.ProdutoContext _context;

        public ListaProdutosModel(XSYSDesafioProduto.Context.ProdutoContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; }

        public async Task OnGetAsync()
        {
            Produto = await _context.Produtos.ToListAsync();
        }
    }
}
