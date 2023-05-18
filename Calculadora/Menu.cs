namespace Calculadora
{
    public class Menu
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?\n1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potenciação\n6 - Radiciação\n0 - Sair\n------------\nSelecione uma opção Por favor.");
            short escolha = short.Parse(Console.ReadLine());
            try
            {
                switch (escolha)
                {
                    case 1: Basicos.Soma(); break;
                    case 2: Basicos.Subtracao(); break;
                    case 3: Basicos.Divisao(); break;
                    case 4: Basicos.Multiplicacao(); break;
                    case 5: Racionais.Potencia(); break;
                    case 6: Racionais.MenuRaiz(); break;
                    case 0: Sair(); break;
                    default: Padrao(); break;
                }
            }
            catch
            {
                Console.WriteLine("Insira um valor Valido!\nTecle enter para reiniciar o programa...");
                Console.ReadKey();
                Mostrar();
            }
        }
        public static void Sair()
        {
            Console.WriteLine("Encerrando o programa\nTecle enter para finalizar");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
        public static void Padrao()
        {
            Console.WriteLine("Escolha uma oção valida!\nTecle enter para reiniciar o programa");
            Console.ReadKey();
            Mostrar();
        }
    }
}