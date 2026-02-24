namespace _1;

class Program
{
    public delegate double CalculateDiscount(double precoOriginal);
    
    static void Main(string[] args)
    {
        Console.WriteLine("Qual o preço do produto?");
        double precoOriginal = double.Parse(Console.ReadLine());
            
        CalculateDiscount calculadorDesconto = AplicarDezPorcento;
        double precoFinal = calculadorDesconto(precoOriginal);
        
        double AplicarDezPorcento(double preco)
        {
            return preco * 0.9;
        }
        
        Console.WriteLine(AplicarDezPorcento(precoOriginal));
        
    }
    
}
