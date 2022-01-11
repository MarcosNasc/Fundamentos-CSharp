using System;
using System.IO;
using System.Text;

namespace EditorHtml
{
  public class Editor
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Clear();
      Console.WriteLine("MODO EDITOR");
      Console.WriteLine("----------------------------------------");
      Start();
    }

    public static void Start()
    {
      var file = new StringBuilder();

      do
      {
        file.Append(Console.ReadLine());
        file.Append(Environment.NewLine);
      }
      while (Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("----------------------------------------");
      Console.WriteLine(" Deseja salvar este arquivo?[S/N]");
      char option = char.Parse(Console.ReadLine());
      if (option == 'S' || option == 's')
      {
        Console.WriteLine("Qual caminho deseja salvar o arquivo?");
        string path = Console.ReadLine();

        using (var doc = new StreamWriter(path))
        {
          doc.Write(file);
        }
      }
      else if (option == 'N' || option == 'n')
      {
        Viewer.Show(file.ToString());
      }
    }
  }
}