using System;
using System.IO;
using System.Text.RegularExpressions;

namespace EditorHtml
{
  public class Viewer
  {
    public static void Show(string text)
    {
      Console.Clear();

      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Clear();
      Console.WriteLine("Qual o caminho do arquivo?");
      string path = Console.ReadLine();
      Console.WriteLine("MODO VISUALIZAÇÃO");
      Console.WriteLine("----------------------------------------");
      if (!(path.Equals("")))
      {
        using (var doc = new StreamReader(path))
        {
          string file = doc.ReadToEnd();
          Console.WriteLine(file);
        }
      }

      Replace(text);

      Console.WriteLine("----------------------------------------");
      Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
      Console.ReadKey();
      Menu.Show();
    }



    public static void Replace(string text)
    {
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
      var words = text.Split(' ');
      for (var i = 0; i < words.Length; i++)
      {
        if (strong.IsMatch(words[i]))
        {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write(
              words[i].Substring(
                  words[i].IndexOf('>') + 1,
                  ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
              )
          );
          Console.Write(" ");
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write(words[i]);
          Console.Write(" ");
        }
      }
    }
  }
}
