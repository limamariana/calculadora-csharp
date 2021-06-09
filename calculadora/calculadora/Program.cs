using System;

namespace calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {
            bool exitChoice = false;

            while (!exitChoice)
            {
                Console.WriteLine("Seja bem vindo(a) a Calculadora! Selecione uma das opções");
                Console.WriteLine("1- Soma\n2- Subtração\n3- Divisão\n4- Multiplicação\n5- Potência\n6- Raiz\n7- Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine()); 

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        exitChoice = true;
                        break;
                }
                Console.Clear();
            }

        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int y = int.Parse(Console.ReadLine());

            int result = x + y;
            Console.WriteLine($"Resultado é {result}");
            Console.WriteLine("Aperte Enter para retornar ao menu");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int y = int.Parse(Console.ReadLine());

            int result = x - y;
            Console.WriteLine($"Resultado é {result}");
            Console.WriteLine("Aperte Enter para retornar ao menu");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int y = int.Parse(Console.ReadLine());

            float result = (float) x/(float) y;
            Console.WriteLine($"Resultado é {result}");
            Console.WriteLine("Aperte Enter para retornar ao menu");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int y = int.Parse(Console.ReadLine());

            int result = x * y;
            Console.WriteLine($"Resultado é {result}");
            Console.WriteLine("Aperte Enter para retornar ao menu");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potência de um número:  ");
            Console.WriteLine("Digite a base: ");
            int numBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int numExpo = int.Parse(Console.ReadLine());

            int result = (int)Math.Pow(numBase, numExpo);
            Console.WriteLine($"Resultado é {result}");
            Console.WriteLine("Aperte Enter para retornar ao menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz  de um número:  ");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
           

            double result = Math.Sqrt(a);
            Console.WriteLine($"Resultado é {result}");
            Console.WriteLine("Aperte Enter para retornar ao menu");
            Console.ReadLine();
        }
    }
}

