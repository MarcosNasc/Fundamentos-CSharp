using System;

namespace datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = DateTime.Now;
            Console.WriteLine(data);

            var formatada = String.Format("{0:dd/MM/yyyy h:mm:ss: ff z}", data);
            Console.WriteLine(formatada);

        }
    }
}
