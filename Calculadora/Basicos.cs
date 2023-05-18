namespace Calculadora
{
    public class Basicos
    {
        public static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Por Favor, insira o primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Agora, insira o segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = primeiroValor + segundoValor;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadLine();
            Console.Clear();
            Menu.Mostrar();
        }

        public static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Por Favor, insira o primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Agora, insira o segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = primeiroValor - segundoValor;
            Console.WriteLine($"O resultado da Subtração é {resultado}");
            Console.ReadLine();
            Console.Clear();
            Menu.Mostrar();
        }

        public static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Por Favor, insira o primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Agora, insira o segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = primeiroValor / segundoValor;
            Console.WriteLine($"O resultado da Divisão é {resultado}");
            Console.ReadLine();
            Console.Clear();
            Menu.Mostrar();
        }
        public static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Por Favor, insira o primeiro Valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Agora, insira o segundo Valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = primeiroValor * segundoValor;
            Console.WriteLine($"O resultado da Multiplicação é {resultado}");
            Console.ReadLine();
            Console.Clear();
            Menu.Mostrar();
        }
    }
}