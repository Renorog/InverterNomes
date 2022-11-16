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

nomePessoas.Reverse();

nomePessoas.ForEach(i => Console.WriteLine(i));

    //Console.WriteLine("Digite o nome #1: ");
    //nome1 = Console.ReadLine();

    //Console.WriteLine("Digite o nome #2: ");
    //nome2 = Console.ReadLine();

    //Console.WriteLine("Digite o nome #3: ");
    //nome3 = Console.ReadLine();

    //Console.WriteLine("Digite o nome #4: ");
    //nome4 = Console.ReadLine();

    // Mecanismo para inverter os nomes
    //auxiliar = nome1;
    //nome1 = nome4;
    //nome4 = auxiliar;
    //auxiliar = nome2;
    //nome2 = nome3;
    //nome3 = auxiliar;

    //Console.WriteLine();

    //Console.WriteLine("Nomes inseridos na sequência invertida.");
    //Console.WriteLine(nome1);
    //Console.WriteLine(nome2);
    //Console.WriteLine(nome3);
    //Console.WriteLine(nome4);

   // Console.ReadKey();