using _8.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _8.Pages;

public class Produtos : PageModel
{
    public List<Produto> produtos = new List<Produto>();
    
    public void OnGet()
    {
        Produto p1 = new Produto("Coca-Cola", 10);
        Produto p2 = new Produto("Sorvete", 15);
        Produto p3 = new Produto("Coxinha", 5);
        produtos.Add(p1);
        produtos.Add(p2);
        produtos.Add(p3);
        
        var linhas = System.IO.File.ReadAllLines(@".\Produtos.txt");
        foreach (var linha in linhas)
        {
            string[] dados = linha.Split(';');
            var produto = new Produto();
            {
                produto.Nome = dados[0];
                produto.Preco = int.Parse(dados[1]);
            }
            {
                produtos.Add(produto);
            }
        }
    }
}
