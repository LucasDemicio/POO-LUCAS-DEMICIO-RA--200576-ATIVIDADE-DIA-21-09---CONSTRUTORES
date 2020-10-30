using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercício_construtores___Lucas
{
    public class Produto
    {
        
        public string Nome;
        public double Preco;
        public int Quantidade;
        public double ValorTotalEmEstoque()
        { return Preco* Quantidade; }
        public void AdicionarProduto(int quantidade)
        { Quantidade += quantidade; }
        public void RemoverProdutos(int quantidade)
        { Quantidade = Quantidade - quantidade; }
        public override string ToString()
        {
            return Nome + ", R$ "
                   + Preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Quantidade
                   + " unidades, Total: R$ "
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
            //fiz o código, mas ele não roda.