public class Livro : ItemBiblioteca
{
    public Livro(int id, string titulo, string autor) : base (id, titulo)
    {
        this.Autor = autor;
        Console.Write("Digite uma descrição interna para o livro ou pressione enter para manter o valor padrão:\n ");
        string descricao = Console.ReadLine();
        if (descricao == "")
        {
            this.DescricaoInterna = DescricaoInterna;
        }
        else
        {
            this.DescricaoInterna = descricao;
        }
    } 
    public string Autor { get; set; }
    
    public string ExibirDescricaoInterna()
    {
        return DescricaoInterna;
    }
}