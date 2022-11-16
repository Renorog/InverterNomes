using System.ComponentModel;
// Declaração da lista
List<string> nomePessoas = new List<string>();

for (int i = 1; i <= 4; i++)
{
    Console.WriteLine($"Digite o nome #{i}: ");
    string nome = Console.ReadLine();
    // Adiciona o item à lista
    nomePessoas.Add(nome);
}

Console.WriteLine();
// método usado para reverter a lista
nomePessoas.Reverse();
nomePessoas.ForEach(i => Console.WriteLine(i));

