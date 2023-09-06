namespace MinhaCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o primeiro valor inteiro: ");
                int valorDigitadoUm;
                string valorDigitadoString = Console.ReadLine();
                valorDigitadoUm = int.Parse(valorDigitadoString);

                Console.WriteLine("Digite o segundo valor inteiro: ");
                int valorDigitadoDois;
                valorDigitadoString = Console.ReadLine();
                valorDigitadoDois = int.Parse(valorDigitadoString);

                Console.WriteLine("Resultados");
                Console.WriteLine("Soma:" + (valorDigitadoUm + valorDigitadoDois));
                Console.WriteLine("Subtração: " + (valorDigitadoUm - valorDigitadoDois));
                Console.WriteLine("Divisão: " + (valorDigitadoUm / valorDigitadoDois));
                Console.WriteLine("Multiplicação: " + (valorDigitadoUm * valorDigitadoDois));
                Console.WriteLine("Resto da divisão: " + (valorDigitadoUm % valorDigitadoDois));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}