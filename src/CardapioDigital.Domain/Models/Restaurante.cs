using System.ComponentModel.DataAnnotations;

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

    [Key]
    public int IdRestaurante { get; set; }
    public string NomeRestaurante { get; set; }
    public string ImagemRestaturanteUrl { get; set; }

    public IEnumerable<Produto> Produtos { get; set; }
}
