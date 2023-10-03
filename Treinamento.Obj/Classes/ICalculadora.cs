namespace Treinamento.Obj.Classes
{
    public interface ICalculadora
    {
        decimal Somar(decimal primeiroNumero, decimal segundoNumero);
        decimal Subtrair(decimal primeiroNumero, decimal segundoNumero);
        decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero);
        decimal Dividir(decimal primeiroNumero, decimal segundoNumero);
        decimal Resultado(Calcular calcular);
    }
}
