using Supermarket.Domain;

namespace Supermarket.Repository;

public class RepositorioProduto
{
    public List<Produto> Produtos { get; set; }

    public RepositorioProduto()
    {
        Produtos = new List<Produto>();
    }

    // Cria um novo produto e adiciona à lista de produtos
    public bool CreateProduto(string nome, decimal preco)
    {
        var produto = new Produto
        {
            Id = Produtos.Count + 1,
            Nome = nome,
            Preco = preco
        };

        Produtos.Add(produto);
        return true;
    }

    // Retorna a lista de produtos
    public List<Produto> GetProdutos()
    {
        return Produtos;
    }

    // Atualiza um produto existente na lista de produtos
    public bool UpdateProduto(int id, string novoNome, decimal novoPreco)
    {
        var index = Produtos.FindIndex(p => p.Id == id);
        if (index != -1)
        {
            Produtos[index].Nome = novoNome;
            Produtos[index].Preco = novoPreco;
            return true;
        }

        return false;
    }

    // Remove um produto da lista de produtos pelo ID
    public bool DeleteProduto(int id)
    {
        var produto = Produtos.FirstOrDefault(p => p.Id == id);
        if (produto != null)
        {
            Produtos.Remove(produto);
            return true;
        }

        return false;
    }
}