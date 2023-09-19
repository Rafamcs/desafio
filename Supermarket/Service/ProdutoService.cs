using Supermarket.Repository;

namespace Supermarket.Service;

public class ProdutoService
{
    private RepositorioProduto repositorio;

    public ProdutoService()
    {
        repositorio = new RepositorioProduto();
    }

    public void VerProdutos()
    {
        Console.Clear();
        var produtos = repositorio.GetProdutos();
        foreach (var produto in produtos)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco}");
        }
    }

    public void AdicionarProduto()
    {
        Console.Clear();
        Console.Write("Digite o nome do produto: ");
        var nome = Console.ReadLine();

        Console.Write("Digite o preço do produto: ");
        var preco = decimal.Parse(Console.ReadLine());

        repositorio.CreateProduto(nome, preco);
    }

    public void AtualizarProduto()
    {
        Console.Clear();
        Console.Write("Digite o ID do produto a ser atualizado: ");
        var id = int.Parse(Console.ReadLine());

        Console.Write("Digite o novo nome do produto: ");
        var nome = Console.ReadLine();

        Console.Write("Digite o novo preço do produto: ");
        var preco = decimal.Parse(Console.ReadLine());

        repositorio.UpdateProduto(id, nome, preco);
    }

    public void DeletarProduto()
    {
        Console.Clear();
        Console.Write("Digite o ID do produto a ser deletado: ");
        var id = int.Parse(Console.ReadLine());

        repositorio.DeleteProduto(id);
    }
}
