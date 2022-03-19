using System.Text.RegularExpressions;

namespace EditorHtml
{
  public class Viewer
  {
    public static void Show(string text)
    {
      ShowMenu();
      Replace(text);
      Console.WriteLine("----------------");
      Console.ReadKey();
      Menu.Show();
    }

    private static void ShowMenu()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Console.WriteLine("Modo de Visualização");
      Console.WriteLine("----------------");
    }

    public static void Replace(string text)
    {
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
      
    }
  }
}