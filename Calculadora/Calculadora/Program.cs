namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double operador = 1;
            double resultado = 0;

            while (operador != 0 && operador < 6)
            {
                Console.WriteLine("Digite o tipo de opeção que deseja fazer: ");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                operador = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o primeiro número: ");
                double primeiroNumero = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                double segundoNumero = double.Parse(Console.ReadLine());

                switch (operador)
                {
                    case 3:
                        {
                            resultado = Multiplicacao(primeiroNumero, segundoNumero);
                            break;
                        }
                    case 4:
                        {
                            resultado = Divisao(primeiroNumero, segundoNumero);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Operação Inválida");
                            break;
                        }
                }

                Console.WriteLine($"O resultado entre {primeiroNumero} e {segundoNumero} é igual a {resultado}");

                    Console.WriteLine("Gostaria de fazer mais uma operação?");
                    Console.WriteLine("5 - Sim");
                    Console.WriteLine("0 - Sair");
                    operador = double.Parse(Console.ReadLine());
                
            }
            }
        static double Multiplicacao(double numero1, double numero2)
            {
                double resultado;
                resultado = numero1 * numero2;
                return resultado;
            }

        static double Divisao(double numero1, double numero2)
            {
                double resultado = 0;
                if (numero2 != 0) {
                    resultado = numero1 / numero2;
            }
                else {
                    Console.WriteLine("0 não pode ser dividido!");
                }

            return resultado;
        }


    }
}
