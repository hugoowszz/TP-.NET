namespace _3;

class Program
{
    public static double CalcularArea(double valorBase, double valorAltura)
    {
        return (valorBase * valorAltura)/2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a base:");
        double valorBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura");
        double valorAltura = double.Parse(Console.ReadLine());
        Func<double, double, double> calcularArea = CalcularArea;
        Console.WriteLine("Area = "+calcularArea(valorBase, valorAltura));
    }
}