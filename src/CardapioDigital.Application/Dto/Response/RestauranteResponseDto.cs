using System.Text.Json.Serialization;

namespace CardapioDigital.Application.Dto.Response;

internal class RestauranteResponseDto
{
    [JsonPropertyName("idRestaurante")]
    public int IdRestaurante { get; init; }

    [JsonPropertyName("nomeRestaurante")]
    public string NomeRestaurante { get; init; }

    [JsonPropertyName("imagemRestauranteUrl")]
    public string ImagemRestaturanteUrl { get; init; }

}
