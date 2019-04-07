using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* TRABALHO PRÁTICO DE ALGORITMOS E ESTRUTURAS DE DADOS - Primeira parte
 * Nomes: Gustavo Ribeiro de Freitas Sena, João Vitor Soares Mendes, Lorena Alves Aguilar e Nathan Ribeiro Ferreira Pinto
 * Data: 07/04/2019
 */
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
            Console.WriteLine("\n\t.:Fila de pedidos gerais:. \n");
            Console.WriteLine(pedidos_gerais.ToString());
            
            Console.WriteLine("\n\t.:Fila de pedidos da categoria bebidas:. \n");
            Console.WriteLine(vet_filas[0].ToString());

            Console.WriteLine("\n\t.:Fila de pedidos da categoria comidas:. \n");
            Console.WriteLine(vet_filas[1].ToString());

            Console.WriteLine("\n\t.:Fila de pedidos da categoria material de escritório:. \n");
            Console.WriteLine(vet_filas[2].ToString());

            Console.WriteLine("\n\t.:Fila de pedidos da categoria utensílios domésticos:. \n");
            Console.WriteLine(vet_filas[3].ToString());

            
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        
    }
}
