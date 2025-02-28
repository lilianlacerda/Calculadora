using System.Diagnostics.Metrics;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                Console.WriteLine("Qual operação você deseja fazer?");
                Console.WriteLine("1-Adição");
                Console.WriteLine("2-Subtração");
                Console.WriteLine("3-Multiplicação");
                Console.WriteLine("4-Divisão");

                int operacao;
                bool operacaoValida = int.TryParse(Console.ReadLine(), out operacao);

                if (!operacaoValida)
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                    continue;
                }

                if (operacao == 6)
                {
                    break;
                    continuar = false;
                }

                Console.WriteLine("Digite o primeiro número: ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                int numero2 = int.Parse(Console.ReadLine());

                int resultado = 0;

                switch (operacao)
                {
                    case 1:
                        resultado = Adicao(numero1, numero2);
                        break;
                    case 2:
                        resultado = Subtracao(numero1, numero2);
                        break;
                    case 3:
                        resultado = Multiplicacao(numero1, numero2);
                        break;
                    case 4:
                        resultado = Divisao(numero1, numero2);
                        break;
                    case 5:
                        Console.WriteLine("Escolha outra operação.");
                        continue;
                    default:
                        Console.WriteLine("Número inválido, digite um número de 1 a 4.");
                        break;
                }

            Console.WriteLine($"O resultado entre {numero1} e {numero2} é igual a {resultado}");

            Console.WriteLine("Deseja fazer outra operação?");
            Console.WriteLine("1 - Voltar à tela inicial");
            Console.WriteLine("2 - Sair");

            int escolhaFinal = int.Parse(Console.ReadLine());

            if (escolhaFinal == 2)
            {
                continuar = false;
            }

            Console.WriteLine("Obrigado por usar a calculadora!");
            }
        }

        public static int Adicao(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int Subtracao(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        static int Multiplicacao(int numero1, int numero2)
        {

            return numero1 * numero2;
        }

        static int Divisao(int numero1, int numero2)
        {
            int resultado = 0;
            if (numero2 != 0)
            {
                resultado = numero1 / numero2;
            }
            else
            {
                Console.WriteLine("0 não pode ser dividido!");
            }

            return resultado;
        }
    }
}