using _8.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _8.Pages;

[IgnoreAntiforgeryToken]
public class AdicionarProduto : PageModel
{
    [BindProperty]
    public Produto Produto { get; set; }
    
    
    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            Console.WriteLine("çadflvk");
            return Page();
        }
        else
        {
            String nome = Produto.Nome;
            double preco = Produto.Preco;

            using (var writer = new StreamWriter("produtos.txt", true))
            {
             writer.WriteLine(nome + ";" + preco);
             return RedirectToPage("/Produtos");
            }
        }
    }
}