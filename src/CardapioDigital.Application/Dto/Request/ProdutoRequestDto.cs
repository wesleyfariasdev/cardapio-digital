using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CardapioDigital.Application.Dto.Request;

internal class ProdutoRequestDto
{
    [JsonPropertyName("nomeProduto")]
    [Required(ErrorMessage = "O nome do produto é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome do produto deve ter no máximo 100 caracteres.")]
    public string NomeProduto { get; set; }

    [JsonPropertyName("descricaoProduto")]
    [StringLength(500, ErrorMessage = "A descrição do produto deve ter no máximo 500 caracteres.")]
    public string DescricaoProduto { get; set; }

    [JsonPropertyName("produtoImagemUrl")]
    [Url(ErrorMessage = "A URL da imagem do produto deve ser válida.")]
    public string ProdutoImagemUrl { get; set; }

    [JsonPropertyName("isPublico")]
    [Required(ErrorMessage = "O campo 'IsPublico' é obrigatório.")]
    [RegularExpression("^(true|false)$", ErrorMessage = "O campo 'IsPublico' deve ser 'true' ou 'false'.")]
    public string IsPublico { get; set; }

    [JsonPropertyName("preco")]
    [Required(ErrorMessage = "O preço do produto é obrigatório.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
    public decimal Preco { get; set; }

    [JsonPropertyName("precoComDesconto")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço com desconto deve ser maior que zero.")]
    public decimal? PrecoComDesconto { get; set; }

    [JsonPropertyName("categoriaId")]
    [Required(ErrorMessage = "O ID da categoria é obrigatório.")]
    public int CategoriaId { get; set; }
}
