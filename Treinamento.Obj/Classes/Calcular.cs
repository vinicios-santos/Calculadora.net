using System;
using System.Collections.Generic;
using System.Text;
using Treinamento.Obj.Enums;

namespace Treinamento.Obj.Classes
{
    public partial class Calcular
    {
        public decimal PrimeiroNumero { get; private set; }
        public decimal SegundoNumero { get; private set; }
        public EnumTipoOperacoes Operacao { get; private set; }
        public decimal Resultado => Operacao switch
        {
            EnumTipoOperacoes.Soma => PrimeiroNumero + SegundoNumero,
            EnumTipoOperacoes.Subtracao => PrimeiroNumero - SegundoNumero,
            EnumTipoOperacoes.Multiplicacao => PrimeiroNumero * SegundoNumero,
            EnumTipoOperacoes.Divisao => Dividir(PrimeiroNumero, SegundoNumero),
            _ => throw new Exception("Não foi possível realizar a operação")
        };
    }
}