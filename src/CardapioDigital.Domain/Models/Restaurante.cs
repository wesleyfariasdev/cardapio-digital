namespace CardapioDigital.Domain.Models;

public sealed class Restaurante
{
    public Restaurante(string imagemRestaturanteUrl)
    {
        ImagemRestaturanteUrl = imagemRestaturanteUrl;
    }

    public int IdRestaurante { get; set; }
    public string ImagemRestaturanteUrl { get; set; }

    public IEnumerable<Produto> Produtos { get; set; }
}
