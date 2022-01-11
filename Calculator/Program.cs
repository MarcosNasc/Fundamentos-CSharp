namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja fazer? ");
            Console.WriteLine("1 -Soma");
            Console.WriteLine("2 -Subtração");
            Console.WriteLine("3 -Multiplicação");
            Console.WriteLine("4 -Divisão");
            Console.WriteLine("5 -Exit");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Selecione uma opção: ");

            short opcao = short.Parse(Console.ReadLine());
            float valor1 = 0, valor2 = 0;

            if (opcao != 5)
            {
                Console.WriteLine("Primeiro valor: ");
                valor1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Segundo valor: ");
                valor2 = float.Parse(Console.ReadLine());
            }

            Operacoes(opcao, valor1, valor2);
        }

        static void Operacoes(short opcao, float valor1, float valor2)
        {

            switch (opcao)
            {
                case 1:
                    Soma(valor1, valor2);
                    break;
                case 2:
                    Subtracao(valor1, valor2);
                    break;
                case 3:
                    Multiplicacao(valor1, valor2);
                    break;
                case 4:
                    Divisao(valor1, valor2);
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Soma(float valor1, float valor2)
        {
            Console.Clear();
            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da  soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(float valor1, float valor2)
        {
            Console.Clear();
            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();

        }


        static void Multiplicacao(float valor1, float valor2)
        {
            Console.Clear();
            float resultado = valor1 * valor2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao(float valor1, float valor2)
        {
            Console.Clear();
            float resultado = valor1 / valor2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

    }
}
