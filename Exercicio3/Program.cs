using Exercicio3;

Pessoa[] pessoas = new Pessoa[3];

Console.WriteLine("Digite o nome do primeiro Aluno: ");
pessoas[0] = new Aluno(Console.ReadLine());

Console.WriteLine("Digite o nome do Segundo Aluno: ");
pessoas[1] = new Aluno(Console.ReadLine());

Console.WriteLine("Digite o nome do Professor: ");
pessoas[2] = new Professor(Console.ReadLine());


foreach (Pessoa pessoa in pessoas)
{
    Console.WriteLine($"\nNome: {pessoa.ToString()}\n");

    if(pessoa is Aluno aluno)
    {
        aluno.Estudar();
    }
    else if (pessoa is Professor professor)
    {
        professor.Explicar();
    }
}