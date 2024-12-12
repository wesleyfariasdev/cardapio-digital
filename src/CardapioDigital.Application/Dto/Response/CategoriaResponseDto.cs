using System.Text.Json.Serialization;

namespace CardapioDigital.Application.Dto.Response;

public class CategoriaResponseDto
{
    [JsonPropertyName("idCategoria")] public int IdCategoria { get; init; }

    [JsonPropertyName("nomeCategoria")] public string NomeCategoria { get; init; }

    [JsonPropertyName("categoriaImagemUrl")]
    public string CategoriaImagemUrl { get; init; }

    [JsonPropertyName("isPublico")] public bool IsPublico { get; init; }

    [JsonPropertyName("restauranteId")] public int RestauranteId { get; init; }

    [JsonPropertyName("restauranteNome")] public string RestauranteNome { get; init; }
}