using System.Text.Json.Serialization;

namespace CardapioDigital.Application.Dto.Response;

internal class ProdutoResponseDto
{
    [JsonPropertyName("idProduto")]
    public int IdProduto { get; init; }

    [JsonPropertyName("nomeProduto")]
    public string NomeProduto { get; init; }

    [JsonPropertyName("descricaoProduto")]
    public string DescricaoProduto { get; init; }

    [JsonPropertyName("produtoImagemUrl")]
    public string ProdutoImagemUrl { get; init; }

    [JsonPropertyName("isPublico")]
    public string IsPublico { get; init; }

    [JsonPropertyName("preco")]
    public decimal Preco { get; init; }

    [JsonPropertyName("precoComDesconto")]
    public decimal? PrecoComDesconto { get; init; }

    [JsonPropertyName("categoriaId")]
    public int CategoriaId { get; init; }

    [JsonPropertyName("categoriaNome")]
    public string CategoriaNome { get; init; }
}
