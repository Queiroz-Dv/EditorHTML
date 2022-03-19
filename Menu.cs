namespace EditorHtml
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      // Background é a cor do fundo 
      Console.BackgroundColor = ConsoleColor.DarkGray;
      // Foreground é a cor da letra 
      Console.ForegroundColor = ConsoleColor.White;

      DrawScreen();
    }

    public static void DrawScreen()
    {
      //Top Base
      Console.WriteLine("+");
      for (int i = 0; i < 30; i++)
        Console.WriteLine("-");

      Console.WriteLine("+");
      Console.WriteLine("\n");

      //Colums
      for (int lines = 0; lines < 10; lines++)
      {
        Console.WriteLine("|");
        for (int i = 0; i < 30; i++)
          Console.WriteLine(" ");

        Console.WriteLine("|");
      }
      // Top Bottom
      Console.WriteLine("+");
      for (int i = 0; i < 30; i++)
        Console.WriteLine("-");

      Console.WriteLine("+");
      Console.WriteLine("\n");
    }
  }
}