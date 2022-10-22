using MaiorIade;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();
Pessoa p3 = new Pessoa();

Console.WriteLine("Determina qual pessoa é a mais velha");

// Leitura de dados da
Console.Write("Nome da 1ª pessoa: ");
p1.Nome = Console.ReadLine();

Console.Write("Idade da 1ª pessoa: ");
p1.Idade = Convert.ToInt32(Console.ReadLine());

Console.Write("Nome da 2ª pessoa: ");
p2.Nome = Console.ReadLine();

Console.Write("Idade da 2ª pessoa: ");
p2.Idade = Convert.ToInt32(Console.ReadLine());

Console.Write("Nome da 3ª pessoa: ");
p3.Nome = Console.ReadLine();

Console.Write("Idade da 3ª pessoa: ");
p3.Idade = Convert.ToInt32(Console.ReadLine());

if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
{
    Console.WriteLine("A pessoa mais velha é: ");
    p1.ExibirDados();
}
else
{
    if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
    {
        Console.WriteLine("A pessoa mais velha é: ");
        p2.ExibirDados();
    }
    else
    {
        if ((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
        {
            Console.WriteLine("A pessoa mais velha é: ");
            p3.ExibirDados();
        }
        else
        {
            Console.WriteLine("Todas as pessoa tem a mesma idade.");
        }
    }
}