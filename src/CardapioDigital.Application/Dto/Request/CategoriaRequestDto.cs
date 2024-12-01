using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CardapioDigital.Application.Dto.Request;

internal class CategoriaRequestDto
{
    [JsonPropertyName("nomeCategoria")]
    [Required(ErrorMessage = "O nome da categoria é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome da categoria deve ter no máximo 100 caracteres.")]
    public string NomeCategoria { get; set; }

    [JsonPropertyName("categoriaImagemUrl")]
    [Url(ErrorMessage = "A URL da imagem da categoria deve ser válida.")]
    public string CategoriaImagemUrl { get; set; }

    [JsonPropertyName("isPublico")]
    [Required(ErrorMessage = "O campo 'IsPublico' é obrigatório.")]
    public bool IsPublico { get; set; }

    [JsonPropertyName("restauranteId")]
    [Required(ErrorMessage = "O ID do restaurante é obrigatório.")]
    public int RestauranteId { get; set; }
}
