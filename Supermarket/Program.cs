using Supermarket.Service;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new ProdutoService();
            while (true)
            {
                Console.WriteLine("============================================");
                Console.WriteLine("=    1. Ver lista de produtos              =");
                Console.WriteLine("=                                          =");
                Console.WriteLine("=    2. Adicionar produto                  =");
                Console.WriteLine("=                                          =");
                Console.WriteLine("=    3. Atualizar produto                  =");
                Console.WriteLine("=                                          =");
                Console.WriteLine("=    4. Deletar produto                    =");
                Console.WriteLine("=                                          =");
                Console.WriteLine("=    5. Sair                               =");
                Console.WriteLine("============================================");

                Console.WriteLine("Digite uma operação: ");
                var opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        service.VerProdutos();
                        break;
                    case 2:
                        service.AdicionarProduto();
                        break;
                    case 3:
                        service.AtualizarProduto();
                        break;
                    case 4:
                        service.DeletarProduto();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}