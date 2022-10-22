namespace MaiorIade;

public class Pessoa
{
    public Pessoa()
    {
        Nome = "";
        Idade = 0;
    }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    private int idade;

    public string Nome { get; set; }
    public int Idade
    {
        get
        { return idade; }
        set
        {
            if (value >= 0)
            {
                idade = value;
            }
            else
            {
                idade = 0;
            }
        }
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
    }
}