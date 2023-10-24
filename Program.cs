

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora");

            //Soma
            Console.WriteLine("Soma");
            Soma soma = new Soma();
            Console.WriteLine(soma.Somar(2, 2));

            //Multiplicacao
            Console.WriteLine("Multiplição");
            Multiplicacao multiplicacao = new Multiplicacao();
            Console.WriteLine(multiplicacao.Multiplicar(2,3));

            //Divisao
            Console.WriteLine("Divisão");
            Divisao divisao = new Divisao();
            Console.WriteLine(divisao.Dividir(10, 2));

            //Subtracao
            Console.WriteLine("Subtração");
            Subtracao subtracao = new Subtracao();
            Console.WriteLine(subtracao.Subtrair(5, 2));
        }
    }
}