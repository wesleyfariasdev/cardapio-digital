namespace CardapioDigital.Domain.Models;

internal sealed class Produto
{
    private Produto()
    {
    }

    public Produto(string nomeProduto, string descricaoProduto, string produtoImagemUrl, bool isPublico, decimal preco,
        decimal? precoComDesconto, int categoriaId)
    {
        NomeProduto = nomeProduto;
        DescricaoProduto = descricaoProduto;
        ProdutoImagemUrl = produtoImagemUrl;
        IsPublico = isPublico;
        Preco = preco;
        PrecoComDesconto = precoComDesconto;
        CategoriaId = categoriaId;
    }

    public int IdProduto { get; set; }
    public string NomeProduto { get; set; }
    public string DescricaoProduto { get; set; }
    public string ProdutoImagemUrl { get; set; }
    public bool IsPublico { get; set; }
    public decimal Preco { get; set; }
    public decimal? PrecoComDesconto { get; set; }

    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; }

    public int RestauranteId { get; set; }
    public Restaurante Restaurante { get; set; }
}