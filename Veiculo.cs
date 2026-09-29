namespace AtividadePOO;

public abstract class Veiculo
{
    protected Veiculo(string modelo, int ano)
    {
        Modelo = modelo;
        Ano = ano;
    }


    public int Ano { get; private set; }
    // Faltou o Private set
    public string Modelo { get; private set; }

    public void Ligar()
    {
        Console.WriteLine($"{Modelo} está ligado!");
    }

    public virtual void Acelerar()
    {
        Console.WriteLine($"{Modelo} está acelerando!");
    }
}