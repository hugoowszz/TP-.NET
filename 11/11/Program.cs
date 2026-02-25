namespace _11;

class Program
{
    static void Main(string[] args)
    {
        Func<string, string, string> concat = (nome, sobrenome) =>
        {
            return nome + " " + sobrenome;
        };
        
        Func<string, string> maiusculas = palavra => palavra.ToUpper();
        Func<string, string> semEspacos = palavra => palavra.Replace(" ", "");
        
        String nomeOriginal = concat("Cristiano", "Ronaldo");
        String resultadoFinal = semEspacos(maiusculas(nomeOriginal));
        
        Console.WriteLine(nomeOriginal);
        Console.WriteLine(resultadoFinal);
        
    }
}