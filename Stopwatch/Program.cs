namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //Start(6);
            //Console.Clear();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            int time = 0;
            char type = '0';
            if (VerificarCaracteresInvalidos(data) == true && data.Length != 1)
            {
                type = char.Parse(data.Substring(data.Length - 1, 1));
                
                //time = int.Parse(data.Substring(0, data.Length - 1));
                string tempo = data.Substring(0, data.Length - 1);
                if (VerificarApenasDigitos(tempo))
                {
                    time = int.Parse(tempo);
                }else
                    ForaDeFormato();
            }
            else
            {
                ForaDeFormato();
            }

            
            int multiplier = 1;
            
            if(data == "0")
                System.Environment.Exit(0);
            if (type != 's' && type != 'm')
            {
                ForaDeFormato();
            }
            if (type == 'm')
                multiplier = 60;
            
            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            
            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //Pausa por 1 segundo, contagem em milisegundos
            }

            Console.Clear();
            Console.WriteLine("Cronometro finalizado!");
            Thread.Sleep(2500);
            Console.Clear();
            Menu();
        }
        
        static bool VerificarApenasDigitos(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c)) // Verifica se o caractere não é um dígito
                {
                    return false; // Se encontrar um caractere que não é um dígito, retorna falso
                }
            }
            return true; // Se todos os caracteres forem dígitos, retorna verdadeiro
        }
        
        static bool VerificarCaracteresInvalidos(string str)
        {
            foreach (char c in str)
            {
                if (!(char.IsDigit(c) || c == 'm' || c == 's')) // Verifica se o caractere não é um dígito, 'm' ou 's'
                {
                    return false; // Se encontrar um caractere que não é um dígito, retorna falso
                }
            }
            return true; // Se todos os caracteres forem dígitos, retorna verdadeiro
        }

        static void ForaDeFormato()
        {
            Console.Clear();
            Console.WriteLine("SIGA O FORMATO EXPECIFICADO!!!!");
            Thread.Sleep(2000);
            Menu();
        }
    }
}