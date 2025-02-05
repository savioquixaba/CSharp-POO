
using Exercicio2;

LivroFotos livro1 = new LivroFotos();

Console.WriteLine($"O Numero de paginas é: {livro1.NumPaginas}");

LivroFotos livro2 = new LivroFotos(24);
Console.WriteLine($"O Numero de paginas é: {livro2.NumPaginas}");

SuperLivroFotos livro3 = new SuperLivroFotos();
Console.WriteLine($"O Numero de paginas é: {livro3.NumPaginas}");