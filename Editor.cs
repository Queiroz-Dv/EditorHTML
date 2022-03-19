using System.Text;

namespace EditorHtml
{
  public static class Editor
  {
    public static void Show()
    {
      ShowMenu();

      Start();
    }

    private static void ShowMenu()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.DarkCyan;
      Console.ForegroundColor = ConsoleColor.White;
      Console.Clear();
      Console.WriteLine("Modo de Edição");
      Console.WriteLine("----------------");
    }

    public static void Start()
    {
      var file = new StringBuilder();

      do
      {
        file.Append(Console.ReadLine());
        file.Append(Environment.NewLine);
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("----------------");
      Console.WriteLine(" Deseja salvar o arquivo? (S|N)");
      Viewer.Show(file.ToString());
    }
  }
}