using Exercicio1;

Carro carro1 = new(0);

Console.WriteLine("Digite a quantidade de gasolina a ser colocada: ");
int gasolina = int.Parse(Console.ReadLine());

carro1.Abastecer(gasolina);
carro1.Dirigir();