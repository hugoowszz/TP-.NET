namespace _2;

class Program
{
    public static void ImprimeMensagem(String mensagem)
    {
        Console.WriteLine(mensagem);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha um idioma (1 -Português, 2 -Inglês ou 3 -Espanhol):");
        int opcao = int.Parse(Console.ReadLine());
        Action<string> mensagemBoasVindas = ImprimeMensagem;
        String mensagem;
        switch (opcao)
        {
            case 1:
                mensagem = "Boas-vindas";
                mensagemBoasVindas(mensagem);
                break;
            case 2:
                mensagem = "Welcome";
                mensagemBoasVindas(mensagem);
                break;
            case 3:
                mensagem = "Bienvenida";
                mensagemBoasVindas(mensagem);
                break;
        }
    }
}