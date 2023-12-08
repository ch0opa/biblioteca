public class Biblioteca
{
    public Biblioteca()
    {
        ColecaoDaBiblioteca = new List<ItemBiblioteca>();
    } 

    public List<ItemBiblioteca> ColecaoDaBiblioteca { get; set; } 

    public void AdicionarItem()
    {
        Console.Clear();
        int id = ColecaoDaBiblioteca.Count() + 1;
        Console.Write("Titulo do livro:\n ");
        string titulo = Console.ReadLine();
        Console.Write("Autor do livro:\n ");
        string autor = Console.ReadLine();

        Livro livroAdicionado = new(id, titulo, autor);
        ColecaoDaBiblioteca.Add(livroAdicionado);
        Console.Write("\nO Livro foi adicionado! Pressione enter para continuar ");
        Console.ReadKey();
    }

    public void RemoverItem()
    {
        Console.Clear();
        foreach (Livro item in ColecaoDaBiblioteca)
        {
            Console.WriteLine($"{item.Id} - {item.Titulo}");
        }
        Console.WriteLine();
        Console.Write("Digite o Id do livro que deseja Remover e aperte enter:\n ");
        int idRemover = Convert.ToInt32(Console.ReadLine());
        while (idRemover < 1 || idRemover > ColecaoDaBiblioteca.Count())
        {
            Console.Write("Opção inválida, digite uma opção entre as disponíveis: ");
            idRemover = Convert.ToInt32(Console.ReadLine());
        }
        ColecaoDaBiblioteca.RemoveAt(idRemover - 1); 
        foreach (Livro item in ColecaoDaBiblioteca)
        {
            if (item.Id > idRemover)
            {
                item.Id--;
            }
        }
        
        Console.Write($"Livro selecionado removido com sucesso. Pressione enter para voltar ");
        Console.ReadLine();
    }

    public void BuscarItemPorTitulo()
    {
        Console.Clear();
        Console.Write("Digite o titulo ou uma palavra presente no titulo do livro que você procura:\n ");
        string tituloProcurado = Console.ReadLine().ToLower();
        bool encontrado = false;
        foreach (Livro item in ColecaoDaBiblioteca)
        {
            string itemTituloLower = item.Titulo.ToLower();
            if (itemTituloLower.Contains(tituloProcurado))
            {
                Console.WriteLine($"\nId - {item.Id}\nTitulo - {item.Titulo}\nAutor - {item.Autor} \nDescrição interna:\n {item.ExibirDescricaoInterna()}");
                encontrado = true;
                break;
            }
        }
        if (encontrado == false)
        {
            Console.WriteLine("\nO Livro não foi encontrado.");
        }
        Console.Write("Pressione enter para voltar ao menu ");
        Console.ReadKey();
    }
    public void BuscarItemPorTitulo(string titulo)
    {
        titulo = titulo.ToLower();
        bool encontrado = false;
        foreach (Livro item in ColecaoDaBiblioteca)
        {
            string itemTituloLower = item.Titulo.ToLower();
            if (itemTituloLower.Contains(titulo))
            {
                Console.WriteLine($"\nId - {item.Id}\nTitulo - {item.Titulo}\nAutor - {item.Autor} \nDescrição interna:\n {item.ExibirDescricaoInterna()}");
                encontrado = true;
                break;
            }
        }
        if (encontrado == false)
        {
            Console.WriteLine("\nO Livro não foi encontrado.");
        }
        Console.Write("\nPressione enter para voltar ao menu ");
        Console.ReadKey();
    }


    public void BuscarItemPorId() 
    {
        Console.Clear();
        Console.Write("Digite o id do livro que você procura:\n ");
        int idProcurado = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;
        foreach (Livro item in ColecaoDaBiblioteca)
        {
            if (idProcurado == item.Id)
            {
                Console.WriteLine($"\nId - {item.Id}\nTitulo - {item.Titulo}\nAutor - {item.Autor} \nDescrição interna:\n {item.ExibirDescricaoInterna()}");
                encontrado = true;
                break;
            }
        }
        if (encontrado == false)
        {
            Console.Write("\nO Livro não foi encontrado.");
        }
        Console.Write("\nPressione enter para voltar para o menu ");
        Console.ReadKey();
    }
    public void BuscarItemPorId(int idProcurado)
    {
        Console.Clear();
        bool encontrado = false;
        foreach (Livro item in ColecaoDaBiblioteca)
        {
            if (idProcurado == item.Id)
            {
                Console.WriteLine($"\nId - {item.Id}\nTitulo - {item.Titulo}\nAutor - {item.Autor} \nDescrição interna:\n {item.ExibirDescricaoInterna()}");
                encontrado = true;
                break;
            }
        }
        if (encontrado == false)
        {
            Console.Write("\nO Livro não foi encontrado.");
        }
        Console.Write("\nPressione enter para voltar para o menu ");
        Console.ReadKey();
    }
}   