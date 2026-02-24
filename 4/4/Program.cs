namespace _4;

class Program
{
    public class TemperatureEventArgs : EventArgs
    {
        public double Temperature { get; }

        public TemperatureEventArgs(double temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureSensor
    {
        public event EventHandler<TemperatureEventArgs> TemperatureExceeded;

        public void verificarTemperatura(double temperatura)
        {
            Console.WriteLine("Temperatura atual: " + temperatura);

            if (temperatura > 100)
            {
                OnTemperatureExceeded(new TemperatureEventArgs(temperatura));
            }
        }

        protected virtual void OnTemperatureExceeded(TemperatureEventArgs e)
        {
            TemperatureExceeded?.Invoke(this, e);
        }
    }
    
    static void Main(string[] args)
    {
        TemperatureSensor sensor = new TemperatureSensor();

        sensor.TemperatureExceeded += (sender, e) =>
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Temperatura excedida!");
            Console.ResetColor();
        };

        while (true)
        {
            Console.WriteLine("Informe a temperatura atual: \nDigite 'sair' para cancelar");
            string tempAtual = Console.ReadLine();

            if (tempAtual.ToLower() == "sair")
            {
                break;
            }
            
            if (double.TryParse(tempAtual, out double temperatura))
            {
                sensor.verificarTemperatura(temperatura);
            }
            else
            {
                Console.WriteLine("Informe um valor valido");
            }
        }
    }
}