public abstract class ItemBiblioteca
{
    public ItemBiblioteca(int id, string titulo)
    {
        this.Id = id;
        this.Titulo = titulo;
        this.DescricaoInterna = "Descrição ainda não alterada";
    } 

    public int Id { get; set; }
    public string Titulo { get; set; }
    protected string DescricaoInterna { get; set; }
}