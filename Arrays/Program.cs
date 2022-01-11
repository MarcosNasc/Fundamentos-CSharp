using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var funcionarios = new Funcionario[] { new Funcionario() { Id = 200, Name = "Marcos" } };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Name);
            }

        }
    }

    struct Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

