namespace EditorHtml
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      // Background é a cor do fundo 
      Console.BackgroundColor = ConsoleColor.DarkBlue;
      // Foreground é a cor da letra 
      Console.ForegroundColor = ConsoleColor.White;

      DrawScreen();
      WriterOptions();

      var option = short.Parse(Console.ReadLine());
    }

    public static void WriterOptions()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("============");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione uma opção");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo Arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir");
      Console.SetCursorPosition(3, 9);
      Console.WriteLine("0 - Sair");
      Console.SetCursorPosition(3, 10);
      Console.Write("Opção: ");
    }


    public static void DrawScreen()
    {
      //Top Base
      Top();

      //Colums
      for (int lines = 0; lines <= 10; lines++)
      {
        Console.Write("|");
        for (int i = 0; i <= 30; i++)
        {
          Console.Write(" ");
        }
        Console.Write("|");
        Console.Write("\n");
      }

      // Top Bottom
      Top();
    }

    private static void Top()
    {
      Console.Write("+");
      for (int i = 0; i <= 30; i++)
      {
        Console.Write("-");
      }

      Console.Write("+");
      Console.Write("\n");
    }

    public static void HandleMenuOption(short option)
    {

      switch (option)
      {
        case 1:
          Editor.Show();
          break;
        case 2:
          Console.WriteLine("View");
          break;
        case 0:
          {
            Console.Clear();
            Environment.Exit(0);
            break;
          }
        default:
          Show();
          break;
      }
    }
  }

}