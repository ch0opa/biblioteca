﻿Biblioteca b1 = new();

while (true)
{
    Console.Clear();
    Console.WriteLine("Digite a opção que deseja executar:");
    Console.WriteLine("1 - Adicionar livro na biblioteca");
    Console.WriteLine("2 - Buscar livro pelo Id");
    Console.WriteLine("3 - Buscar livro pelo Titulo");
    Console.WriteLine("4 - Remover um livro");
    Console.WriteLine("5 - Fechar");
    Console.Write("\n opção: ");

    int opcao = Convert.ToInt32(Console.ReadLine());
    while (opcao < 1 || opcao > 5)
    {
        Console.Write("Opção inválida, escolha entre 1 a 5: ");
        opcao = Convert.ToInt32(Console.ReadLine());
    }

    switch (opcao)
    {
        case 1: b1.AdicionarItem(); break;
        case 2: b1.BuscarItemPorId(); break;
        case 3:
            Console.Clear();
            Console.Write("Digite o titulo ou alguma palavra do titulo para procurar o livro desejado:\n ");
            b1.BuscarItemPorTitulo(Console.ReadLine()); 
            break;
        case 4: b1.RemoverItem(); break;
        case 5: System.Environment.Exit(0); break;
    }
}