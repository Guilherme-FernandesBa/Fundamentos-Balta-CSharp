namespace stopwatch
{
    public class Start
    {
        public static void Comecar(int tempo)
        {
            int tempoAtual = 0;
            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado");
            Thread.Sleep(25000);
            Menu.Mostrar();
        }
    }
}