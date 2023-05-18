namespace stopwatch
{
    public class Menu
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao stopwatch!\n\nS = segundos => 10s = 10 segundos\nM = Minutos => 10m = 10 minutos\n0 = Sair\nQuanto tempo deseja contar?\n--------------------");
            Gerenciador();
        }

        static void Gerenciador()
        {
            string data = Console.ReadLine().ToLower();
            char tipo = char.Parse(data.Substring(data.Length - 1, 1));
            int tempo = int.Parse(data.Substring(0, data.Length - 1));
            int multiplicador = 1;
            if (tipo == 'm')
            {
                multiplicador = 60;
            }
            if (tempo == 0)
            {
                System.Environment.Exit(0);
            }
            PreStart(tempo * multiplicador);
        }
        
        public static void PreStart(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Ready");
            Thread.Sleep(1000);
            Console.WriteLine("set");
            Thread.Sleep(1000);
            Console.WriteLine("Go!!");
            Thread.Sleep(2500);
            Start.Comecar(tempo);
        }
    }
}