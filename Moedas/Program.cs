using System;
using System.Globalization;

namespace Moedas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      decimal valor = 10.25m;
      
      Console.WriteLine(Math.Floor(valor).ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
    }
  }
}
