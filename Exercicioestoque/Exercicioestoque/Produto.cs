using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Produto
{
    // acrescentando os métodos
    public string Nome;
    public double Preco;
    public int Quantidade;


    // acrescentando as operações
    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }



    // a função será void, porque a operação não retorna o valor de saída. Ela vai buscar a quantidade do produto e mudar o valor dela. Uma operação que muda apenas a quantidade.
    // void significa vazio
    // entrada de função é minúsculo "quantidade"
    public void AdicionarProdutos(int quantidade)
    {
        Quantidade = Quantidade + quantidade;
        // ou Quantidade +=quantidade
    }

    // alterado por mim
    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }

    // até aqui
    // sobreposição: override
    override public string ToString()
    {
        // return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture);
        // nova forma de concatenar
        return Nome 
            + ", $" 
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);  

            }
}