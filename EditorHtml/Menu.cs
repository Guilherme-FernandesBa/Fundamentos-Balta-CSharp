namespace EditorHtml
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            DrawScreen();
            Escrever();
            var opcao = short.Parse(Console.ReadLine());
            HandleMenu(opcao);
        }
        public static void DrawScreen()
        {
            Linha();
            Coluna();
            Linha();
        }

        public static void Linha()
        {
            Console.Write("+");
            for (int largura = 0; largura < 30; largura++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }

        public static void Coluna()
        {
            for (int lines = 0; lines < 10; lines++)
            {
                Console.Write("|");
                for (int largura = 0; largura < 30; largura++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
        }


        public static void Escrever()
        {
            Console.SetCursorPosition(3, 2);
            Console.Write("Editor Html");
            Console.SetCursorPosition(3, 3);
            Console.Write("================");
            Console.SetCursorPosition(3, 4);
            Console.Write("Selecione Uma opção");
            Console.SetCursorPosition(3, 6);
            Console.Write("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.Write("2 - Abrir o Arquivo");
            Console.SetCursorPosition(3, 9);
            Console.Write("0 - Sair  ");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");


        }

        public static void HandleMenu(short opcao)
        {
            switch (opcao)
            {
                case 1: Editor.Show(); break;
                //case 2: Viewer.Show(); break;
                case 0: System.Environment.Exit(0); break;
                default:
                {
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                }
            }




        }

    }
}