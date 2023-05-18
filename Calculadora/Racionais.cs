namespace Calculadora
{
    public class Racionais
    {

        public static void Potencia()
        {
            Console.WriteLine("Insira a Base: ");
            double potencia = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora insira o expoente: ");
            double expoente = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(potencia, expoente);
            Console.WriteLine($"O resultado da Potenciação é {resultado}");
            Console.ReadLine();
            Console.Clear();
            Menu.Mostrar();
        }
        public static void MenuRaiz()
        {
            Console.Clear();
            Console.WriteLine("Escolha entre\n1 - Raiz quadrada\n2 - Raiz Cubica");
            short escolha = short.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1: Raiz(1); break;
                case 2: Raiz(2); break;
            }
        }
        public static void Raiz(int numero)
        {
            Console.Clear();
            Console.WriteLine("Por favor, insira o Radicando:\n---------- ");
            double radicando = double.Parse(Console.ReadLine());
            double resultado = radicando;
            string operacao = "";
            if (numero == 1)
            {
                resultado = Math.Sqrt(radicando);
                operacao = "Quadrada";
            }
            else if (numero == 2)
            {
                resultado = Math.Cbrt(radicando);
                operacao = "Cubica";

            }
            Console.WriteLine($"A raiz {operacao} de {radicando} é {resultado}");
            Console.ReadLine();
            Console.Clear();
            Menu.Mostrar();
        }
    }
}