namespace AtividadePOO;

public class Program
{
    public static void Main(string[] args)
    {
        Veiculo[] veiculos =
        [
            new Carro("Fusca", 1978),
            new Moto("Honda", 1980),
            new Caminhao("Fiat", 1890)
        ];
        foreach (var veiculo in veiculos)
        {
            veiculo.Ligar();
            veiculo.Acelerar();
        }
    }
}