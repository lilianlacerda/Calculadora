namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação você deseja faze?");
            Console.WriteLine("1-Adição");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão /n");
            Console.WriteLine("5-Outra operação");
            Console.WriteLine("6- sair");


            Console.ReadLine();

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int numero2= int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao (numero1,numero2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao (numero1, numero2);
                        break;
                    }
               
                    
                default:
                    Console.WriteLine("Numero invalido, digite outro numero de 1 a 4");
                    break;


            }

        }








        public static int Adicao(int numero1, int numero2)
        {
            int result = numero1 + numero2;
            return result;
        }
        public static int Subtracao(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;
        }
       
    }
}
