using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CardapioDigital.Application.Dto.Request;

internal class RestauranteRequestDto
{
    [JsonPropertyName("nomeRestaurante")]
    [Required(ErrorMessage = "O nome do restaurante é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome do restaurante deve ter no máximo 100 caracteres.")]
    public string NomeRestaurante { get; set; }

    [JsonPropertyName("imagemRestauranteUrl")]
    [Required(ErrorMessage = "A URL da imagem do restaurante é obrigatória.")]
    [Url(ErrorMessage = "A URL da imagem do restaurante deve ser válida.")]
    public string ImagemRestaturanteUrl { get; set; }
}