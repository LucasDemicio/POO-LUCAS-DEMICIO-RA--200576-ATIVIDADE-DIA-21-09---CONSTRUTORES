using System;
using System.Globalization;

namespace Exercício_construtores___Lucas
{
    public class Program
     
    { static void Main (string[] args)
        
        { 
            Produto p = new Produto();
        
            Console.WriteLine("Entre com os dados do produto;");
            // PROGRAMAÇÃO REFERENTE AO NOME DO PRODUTO À SEGUIR:
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            string nome = Console.ReadLine();
            
            // PROGRAMAÇÃO REFERENTE AO PREÇO À SEGUIR:
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          
            //PROGRAMAÇÃO REFERENTE À QUANTIDADE À SEGUIR:
            Console.Write("Quantidade no estoque: ");
            p.Preco = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int quantidade = int.Parse(Console.ReadLine()); 
          
           //MOSTRAR OS DADOS ATÉ AGORA:
            Console.WriteLine("Dados do produto: " + p); 
            
            //ADIÇÃO DE PRODUTOS:
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: "); 
            int qt = int.Parse(Console.ReadLine()); 
          
            //DADOS ATUALIZADOS:
          p.AdicionarProduto(qt); Console.WriteLine("Dados do atualizados: " + p); 
          
            //PRODUTOS A SEREM REMOVIDOS DO ESTOQUE:
          Console.WriteLine("Digite o número de produtos a serem removidos do estoque: "); 
          qt = int.Parse(Console.ReadLine()); 
          p.RemoverProdutos(qt); 
            
            //DADOS ATUALIZADOS
          Console.WriteLine("Dados do atualizados: " + p); 
        }
    }
}
 // fiz o código, mas ele dá um erro, não tive cabeça de mandar uma mensagem, logo ficou assim.