
namespace ProdutoNamespace;
public class Produto{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(int id, string nome, double preco, int quantidade){
        Id = id;
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
}