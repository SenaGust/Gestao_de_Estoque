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
            TestarImplementacaoLista();

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void TestarImplementacaoLista()
        {
            /*
                ID; NomeProduto; Categoria
                ID; QuantidadeProduto
                ID_Pedido; ID_Produto; Qtd
            */

            string id = "1-4287", nome = "Caneta";
            int tipo = 1;
            double preco = 0.50;

            Fila pedidos = new Fila(); // estrutura de armazenamento

            //IDado dado = null; // novo dado a ser inserido na fila
            IDado dado = new Material_Escritorio(id, nome, tipo, preco); //instanciando um novo produto
            IDado dado3 = new Bebidas(id, nome, tipo, preco); //instanciando um novo produto

            //Testando enfileirar
            Console.WriteLine("Inserindo Dados");
            pedidos.Enfileirar(dado); // chama o método que adiciona um novo elemento a fila
            pedidos.Enfileirar(dado3); // chama o método que adiciona um novo elemento a fila
            pedidos.Enfileirar(dado); // chama o método que adiciona um novo elemento a fila
            pedidos.Enfileirar(dado3); // chama o método que adiciona um novo elemento a fila
            pedidos.Enfileirar(dado); // chama o método que adiciona um novo elemento a fila
            pedidos.Enfileirar(dado3); // chama o método que adiciona um novo elemento a fila
            Console.WriteLine(pedidos.ToString());

            Console.WriteLine("Desenfileirando");
            //Testando desenfileirar
            pedidos.Desenfileirar();

            //testando escrever Pilha
            Console.WriteLine(pedidos.ToString());
        }
    }
}
