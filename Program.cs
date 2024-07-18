namespace Calculadora 
{
    public class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Informe o primeiro valor"); 
            int valor1 = int.Parse(Console.ReadLine().ToString()); 

            Console.WriteLine("Informe o segundo valor"); 
            int valor2 = int.Parse(Console.ReadLine().ToString()); 

            Console.WriteLine("Informe a operação a ser execultada."); 
            Console.WriteLine("1 - Soma"); 
            Console.WriteLine("2 - Subtração."); 
            Console.WriteLine("3 - Multiplicação."); 
            Console.WriteLine("4 - Divisão.");
            int operacao = int.Parse(Console.ReadLine().ToString()); 

            double resultadooperacao = 0; 

            switch (operacao) 
            {
                case 1: 
                    resultadooperacao = Soma(valor1, valor2); 
                    break;

                case 2: 
                    resultadooperacao = Subtracao(valor1, valor2); 
                    break;

                case 3: 
                    resultadooperacao = Multiplicacao(valor1, valor2); 
                    break;

                case 4: 
                    resultadooperacao = Divisao(valor1, valor2); 
                    break;

                default: 
                    break;
            }

            Console.WriteLine($"O resultado da operação foi: {resultadooperacao}"); 
        }

        
        private static double Soma(int valor1, int valor2) => valor1 + valor2; 

        private static double Subtracao(int valor1, int valor2) => valor1 - valor2; 

        private static double Multiplicacao(int valor1, int valor2) => valor1 * valor2; 

        private static double Divisao(int valor1, int valor2) => valor1 / valor2; 
    }
}
