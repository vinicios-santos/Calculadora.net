using System;
using Treinamento.Obj.Enums;

namespace Treinamento.Obj.Classes
{
    public class Calculadora : ICalculadora
    {
        public decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            if (segundoNumero <= 0)
                throw new Exception("Não foi possível realizar a operação");

            return primeiroNumero / segundoNumero;
        }

        public decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }

        public decimal Somar(decimal primeiroNumero, decimal segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        public decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }

        public decimal Resultado (Calcular calcular)
        {
            return calcular.Operacao switch
            {
                EnumTipoOperacoes.Soma => Somar(calcular.PrimeiroNumero, calcular.SegundoNumero),
                EnumTipoOperacoes.Subtracao => Subtrair(calcular.PrimeiroNumero, calcular.SegundoNumero),
                EnumTipoOperacoes.Multiplicacao => Multiplicar(calcular.PrimeiroNumero, calcular.SegundoNumero),
                EnumTipoOperacoes.Divisao => Dividir(calcular.PrimeiroNumero, calcular.SegundoNumero),
                _ => throw new Exception("Não foi possível realizar a operação")
            };
        }
    }
}
