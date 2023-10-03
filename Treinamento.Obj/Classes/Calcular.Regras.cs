using System;
using System.Linq;
using Treinamento.Obj.Enums;

namespace Treinamento.Obj.Classes
{
    public partial class Calcular
    {

        public void SetarPrimeiroNumero(string primeiroNumero)
        {
            if (string.IsNullOrEmpty(primeiroNumero))
                throw new Exception("Não foi possível ler o número.");

            PrimeiroNumero = decimal.Parse(primeiroNumero);
        }

        public void SetarSegundoNumero(string segundoNumero)
        {
            if (string.IsNullOrEmpty(segundoNumero))
                throw new Exception("Não foi possível ler o número.");

            SegundoNumero = decimal.Parse(segundoNumero);
        }

        public void SetarOperacao(decimal operacao)
        {
            var operacoesValidas = new[]
            {
                EnumTipoOperacoes.Soma,
                EnumTipoOperacoes.Subtracao,
                EnumTipoOperacoes.Multiplicacao,
                EnumTipoOperacoes.Divisao,
                EnumTipoOperacoes.Porcentagem
            };

            var tipoOperacao = (EnumTipoOperacoes)operacao;

            if (!operacoesValidas.Contains(tipoOperacao))
                throw new Exception("Operação inválida");

            Operacao = tipoOperacao;
        }

        public decimal Dividir(decimal PrimeiroNumero, decimal SegundoNumero)
        {
            if (SegundoNumero <= 0)
                throw new Exception("Impossível dividir por 0");

            return PrimeiroNumero / SegundoNumero;
        }
    }
}
