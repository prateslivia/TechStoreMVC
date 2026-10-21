namespace TechStoreMVC.Models;

public class ProdutosDB
{
    // Metódo que vai listar novos objetos de um produto
    // e armazena-los na variavel produtos

    private static readonly List<Produto> produtos = new()
    {
          new Produto(1, "Mouse Gamer", 129.9m, 10),
          new Produto(2, "Teclado Mecânico", 249.9m, 5),
          new Produto(3, "Monitor 24 polegadas", 899.9m, 8),
          new Produto(4, "Headset Gamer", 179.9m, 15),
    };

     // Passo 02 - Criar os métodos CRUD e remover roda regra de negócio do Controller
    // Responsabilidade do Listar: Devolver/mostrar os produtos. Igual ao Index
    // Controller
    public List<Produto> Listar()
    {
         return produtos;
    }  

    public Produto? buscarPorId(int Id)
    {
        return produtos.FirstOrDefault(
            produto => produto.Id == Id

        );
    }

    public void Adicionar(Produto produto)
    {
        produto.Id = produtos.Count + 1;
        produtos.Add(produto);

    }

    public bool Atualizar(Produto produtoAtualizado)
    {
        Produto? produtoExistente =
        buscarPorId(produtoAtualizado.Id);

        if(produtoExistente is null)
        return false;

        produtoExistente.Nome = produtoAtualizado.Nome;
        produtoExistente.Preco = produtoAtualizado.Preco;
        produtoExistente.Estoque = produtoAtualizado.Estoque;
        return true;
    }

    public bool Excluir(int Id)
    {
        Produto? produto = buscarPorId(Id);
        if(produto is null)
          return false;
        produtos.Remove(produto);

        return true;
    }

    
}