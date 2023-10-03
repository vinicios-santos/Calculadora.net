using System.ComponentModel;

namespace Treinamento.Obj.Enums
{
    public enum EnumTipoOperacoes
    {
        [Description("Soma")]
        Soma = 1,
        [Description("Subtração")]
        Subtracao = 2,
        [Description("Multiplicação")]
        Multiplicacao = 3,
        [Description("Divisão")]
        Divisao = 4
    }
}
