namespace _7;

class Program
{
    public class Logger
    {
        public void LogToConsole(string msg)
        {
            Console.WriteLine(msg);
        }

        public void LogToFile(string msg)
        {
            Console.WriteLine("Gravando: "+msg+" no arquivo log.txt");
        }
        
        public void LogToDatabase(string msg)
        {
            Console.WriteLine("Inserindo: "+msg+" na tabela de logs");
        }
    }
    
    static void Main(string[] args)
    {
        Logger l = new Logger();

        Console.WriteLine("---Sem métodos---");
        Action<string> logmc = null;
        
        logmc?.Invoke("teste");
        
        Console.WriteLine("---Métodos associados---");
        
        logmc = l.LogToConsole;
        
        logmc += l.LogToFile;
        logmc += l.LogToDatabase;
        
        logmc?.Invoke("Sistema iniciado");
    }
}
