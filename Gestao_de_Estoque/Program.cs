using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//classe pedidos gerais com quantidade também
namespace Gestao_de_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "arquivo.txt";
            Fila[] vet_filas = new Fila[4];

            for(int i=0;i<4;i++)
            {
                vet_filas[i] = new Fila();
            }
            Fila pedidos_gerais = Arquivo.Carregar_dados(path,vet_filas);
            Console.WriteLine(pedidos_gerais.ToString());
            
            //TestarImplementacaoLista();
            //criar um vetor de filas 
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
            double preco = 0.50, pLucroMax = 0.3, pLucroMin = 0.2;

            Fila pedidos_gerais = new Fila(); // estrutura de armazenamento

            //IDado dado = null; // novo dado a ser inserido na fila
            IDado dado = new Material_Escritorio(id, nome, preco, pLucroMin, pLucroMax); //instanciando um novo produto
            IDado dado3 = new Bebidas(id, nome, preco, pLucroMin, pLucroMax); //instanciando um novo produto

            //Testando enfileirar
            Console.WriteLine("Inserindo Dados");
            pedidos_gerais.Enfileirar(dado); // chama o método que adiciona um novo elemento a fila
            pedidos_gerais.Enfileirar(dado3); // chama o método que adiciona um novo elemento a fila
            pedidos_gerais.Enfileirar(dado); // chama o método que adiciona um novo elemento a fila
            pedidos_gerais.Enfileirar(dado3); // chama o método que adiciona um novo elemento a fila
            pedidos_gerais.Enfileirar(dado); // chama o método que adiciona um novo elemento a fila
            pedidos_gerais.Enfileirar(dado3); // chama o método que adiciona um novo elemento a fila
                                              //Console.WriteLine(pedidos.ToString());
                                              //pedidos.ToString();

            Console.WriteLine("Desenfileirando");
            //Testando desenfileirar
            Fila aux = new Fila();
            while (!pedidos_gerais.Vazia())
            {
                aux.Enfileirar(pedidos_gerais.Desenfileirar());
            }


            //testando escrever Pilha
            Console.WriteLine("aux teste: " + aux.ToString());


            //passei o método carregar dados para dentro da fila
        }
    }
}
