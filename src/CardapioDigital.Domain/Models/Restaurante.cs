namespace CardapioDigital.Domain.Models;

internal sealed class Restaurante
{
    private Restaurante()
    {
    }

    public Restaurante(string nomeRestaurante, string imagemRestaturanteUrl)
    {
        NomeRestaurante = nomeRestaurante;
        ImagemRestaturanteUrl = imagemRestaturanteUrl;
    }

    public int IdRestaurante { get; set; }
    public string NomeRestaurante { get; set; }
    public string ImagemRestaturanteUrl { get; set; }

    public IEnumerable<Produto> Produtos { get; set; }
    public IEnumerable<Categoria> Categorias { get; set; }
}