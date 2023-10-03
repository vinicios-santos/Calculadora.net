using System;
using Treinamento.Obj.Classes;

namespace Treinamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular calcular = new Calcular();
            ICalculadora calculadora = new Calculadora();

            try 
            {
                Console.WriteLine("Escolha a operação: \n 1 - Somar \n 2 - Subtrair \n 3 - Dividir \n 4 - Multiplicar");
                calcular.SetarOperacao(decimal.Parse(Console.ReadLine()));

                Console.WriteLine("Digite o primeiro numero: ");
                calcular.SetarPrimeiroNumero(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero: ");
                calcular.SetarSegundoNumero(Console.ReadLine());

                Console.WriteLine($"\r\nResultado: {calculadora.Resultado(calcular)}");

                //Testando todas operações

                Console.WriteLine($"Somar: {calculadora.Somar(calcular.PrimeiroNumero, calcular.SegundoNumero)}");
                Console.WriteLine($"Dividir: {calculadora.Dividir(calcular.PrimeiroNumero, calcular.SegundoNumero)}");
                Console.WriteLine($"Multiplicar: {calculadora.Multiplicar(calcular.PrimeiroNumero, calcular.SegundoNumero)}");
                Console.WriteLine($"Subtrair: {calculadora.Subtrair(calcular.PrimeiroNumero, calcular.SegundoNumero)}");

                //Console.WriteLine($"O resultado é: {calcular.Resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }


        }
    }
}
