using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                ID; NomeProduto; Categoria
                ID; QuantidadeProduto
                ID_Pedido; ID_Produto; Qtd
            */

            #region teste
            string id = "1-4287", nome = "Caneta";
            int tipo = 1;
            double preco = 0.50;

            Fila pedidos = new Fila(); // estrutura de armazenamento

           
            IDado dado = null; // novo dado a ser inserido na fila
            
            dado.Produto = new Material_Escritorio(id, nome, tipo, preco); //instanciando um novo produto
                                                                           // a classe filha vai mudar dependendo do produto

            pedidos.Enfileirar(dado); // chama o método que adiciona um novo elemento a fila
            Console.ReadKey();
            #endregion
        }
    }
}
