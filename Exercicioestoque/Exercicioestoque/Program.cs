// Criando o programa do estoque do curso C# do Udemy

using System.Globalization;

Produto p = new Produto();

Console.WriteLine("Entre os dados do produto.");
Console.Write("Nome:"); 
p.Nome=Console.ReadLine();
Console.Write("Preço:");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque:");
p.Quantidade = int.Parse(Console.ReadLine());

// Console.WriteLine("Dados do Produto: "+p.Nome + ",$"+p.Preco ); ficaria muito longo e trabalhoso
//melhor criar a sob reposição na class e depois usar somente o p. 
Console.WriteLine(); 
Console.WriteLine("Dados do Produto: " + p);

Console.WriteLine();
Console.Write("Digite o número de produtos à ser adicionado ao estoque: ");
int qte = int.Parse(Console.ReadLine());
// adicionar a qte ao p por meio do AdicionarProduto
p.AdicionarProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " +p);

// alterado por mim
Console.WriteLine();
Console.Write("Digite o número de produtos à ser removido do estoque: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

