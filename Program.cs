

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora");

            //Soma
            Soma soma = new Soma();
            Console.WriteLine(soma.Somar(2, 2));

            //Multiplicacao
            Multiplicacao multiplicacao = new Multiplicacao();
            Console.WriteLine(multiplicacao.Multiplicar(2,3));

            //Divisao
            Divisao divisao = new Divisao();
            Console.WriteLine(divisao.Dividir(10, 2));

            //Subtracao
            Subtracao subtracao = new Subtracao();
            Console.WriteLine(subtracao.Subtrair(10, 2));
        }
    }
}