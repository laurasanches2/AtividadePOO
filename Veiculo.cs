namespace AtividadePOO;

public abstract class Veiculo
{
    protected Veiculo(string modelo, int ano)
    {
        Modelo = modelo;
        Ano = ano;
    }

    public string Modelo { get; }
    public int Ano { get; private set; }

    public void Ligar()
    {
        Console.WriteLine($"{Modelo} ligado com sucesso!");
    }

    public virtual void Acelerar()
    {
        Console.WriteLine($"{Modelo} está Acelerado !");
    }
}