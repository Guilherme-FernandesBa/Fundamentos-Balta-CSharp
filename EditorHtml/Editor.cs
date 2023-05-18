using System.Text;

namespace EditorHtml
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;   
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor!");
            Console.WriteLine("-------------");
            Start();

        }
        public static void Start()
        {   
            var file = new StringBuilder();
            do
            {
                file.AppendLine(Console.ReadLine());
                file.AppendLine(Environment.NewLine);
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("DDejesa salvar o arquivo?");
            Viewer.Show(file.ToString());
        }


    }
}