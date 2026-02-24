namespace _8.Model;

public class Produto
{
    public String? Nome { get; set; }
    public double Preco { get; set; }

    public Produto() { }
    public Produto(String nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
    
}
