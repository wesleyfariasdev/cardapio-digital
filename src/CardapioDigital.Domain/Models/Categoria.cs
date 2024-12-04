using System.ComponentModel.DataAnnotations;

namespace CardapioDigital.Domain.Models;

internal sealed class Categoria
{
    private Categoria()
    {

    }

    public Categoria(string nomeCategoria, string imagemUrl, bool isPublico, int restauranteId)
    {
        NomeCategoria = nomeCategoria;
        CategoriaImagemUrl = imagemUrl;
        IsPublico = isPublico;
        RestauranteId = restauranteId;
    }

    [Key]
    public int IdCategoria { get; set; }
    public string NomeCategoria { get; set; }
    public string CategoriaImagemUrl { get; set; }
    public bool IsPublico { get; set; }

    public Restaurante Restaurante { get; set; }
    public int RestauranteId { get; set; }
}
