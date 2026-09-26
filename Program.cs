namespace AtividadePOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo[] veiculo =
        [
            new Caminhao("Volvo ", 1989),
            new Moto("BMW", 1987),
            new Carro("mercedes", 1999)
        ];
        foreach (var veiculoAtual in veiculo)
        {
            veiculoAtual.Ligar();
            veiculoAtual.Acelerar();
        }
    }
}